<#
.SYNOPSIS
    Regenerates the client SDKs from the Aspose.PDF for AWS service's OpenAPI spec.

.DESCRIPTION
    1. Exports the spec from the service into spec/swagger.json (scripts/export-spec.ps1).
    2. Generates every client with the pinned swagger-codegen into a temp folder and syncs it into
       the client folder: files listed in the client's .swagger-codegen-ignore are kept as they are,
       files the generator no longer produces are deleted.
    3. Runs the client's post-process script, if any.
    4. Checks that every endpoint of the spec is present in every client.
    5. Builds every client whose toolchain is available.
    6. Optionally (-Readme) regenerates README.md with the service's Aspose.Pdf.RestApi.Generator.
    The result is left uncommitted for review.

.PARAMETER Version
    Package version written into the generated clients (pom.xml, build.gradle, ...).
    When omitted, the value from codegen/<client>.json is used.

.PARAMETER Clients
    Subset of clients to update (names from codegen/codegen.json). All by default.

.PARAMETER ServiceRepo
    Path to the AsposePdfForAws service repository.

.PARAMETER SkipExport
    Use spec/swagger.json as is instead of exporting it from the service.

.PARAMETER Force
    Regenerate even if the exported spec did not change.

.PARAMETER SkipBuild
    Skip step 5.

.PARAMETER Readme
    Run step 6. Note: the service's generator also rewrites docs, examples and tests inside the service repo.

.EXAMPLE
    .\scripts\update-sdks.ps1
.EXAMPLE
    .\scripts\update-sdks.ps1 -SkipExport -Clients dotnet,java -Version 1.1.0
#>
[CmdletBinding()]
param(
    [string]$Version,
    [string[]]$Clients,
    [string]$ServiceRepo = 'D:\r\AsposePdfForAws',
    [switch]$SkipExport,
    [switch]$Force,
    [switch]$SkipBuild,
    [switch]$Readme
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$manifest = Get-Content (Join-Path $repoRoot 'codegen/codegen.json') -Raw | ConvertFrom-Json
$specPath = Join-Path $repoRoot $manifest.spec

# never synced or deleted: build output and tool caches inside client folders
$protectedDirs = @('bin', 'obj', 'build', 'target', '.gradle', 'node_modules', '.idea', '.vs')

$targets = $manifest.clients
if ($Clients) {
    $unknown = $Clients | Where-Object { $_ -notin $manifest.clients.name }
    if ($unknown) { throw "Unknown client(s): $($unknown -join ', '). Known: $($manifest.clients.name -join ', ')" }
    $targets = $manifest.clients | Where-Object { $_.name -in $Clients }
}

function Write-Step([string]$text) { Write-Host "`n=== $text" -ForegroundColor Cyan }

function Get-IgnorePatterns([string]$dir) {
    $file = Join-Path $dir '.swagger-codegen-ignore'
    if (-not (Test-Path $file)) { return @() }
    Get-Content $file | ForEach-Object { $_.Trim() } | Where-Object { $_ -and -not $_.StartsWith('#') }
}

function Test-Ignored([string]$relPath, [string[]]$patterns) {
    foreach ($p in $patterns) {
        if ($p.EndsWith('/')) { if ($relPath.StartsWith($p)) { return $true } }
        elseif ($relPath -like $p) { return $true }
    }
    return $false
}

function Get-RelativeFiles([string]$dir) {
    $root = (Resolve-Path $dir).Path.TrimEnd('\') + '\'
    Get-ChildItem $dir -Recurse -File -Force | ForEach-Object {
        $rel = $_.FullName.Substring($root.Length).Replace('\', '/')
        $top = $rel.Split('/')[0]
        $inProtected = $rel.Split('/') | Where-Object { $_ -in $protectedDirs }
        if (-not $inProtected -and $top -ne '.git') { $rel }
    }
}

function Sync-Client([string]$generated, [string]$target, [string[]]$patterns) {
    $genFiles = @(Get-RelativeFiles $generated | Where-Object { $_ -ne '.swagger-codegen-ignore' })
    $genSet = @{}; foreach ($f in $genFiles) { $genSet[$f] = $true }
    $stats = @{ Added = 0; Updated = 0; Deleted = @(); Kept = 0; Renamed = @() }

    foreach ($rel in $genFiles) {
        $src = Join-Path $generated $rel
        $dst = Join-Path $target $rel
        $exists = Test-Path $dst
        if ($exists -and (Test-Ignored $rel $patterns)) { $stats.Kept++; continue }
        if ($exists) {
            # case-only rename (e.g. VerifyEsign -> Verifyesign): the file system and git ignore case,
            # so drop the old name explicitly or it would survive under its old spelling
            # Get-Item echoes the requested casing; a directory listing returns the real one
            $leaf = Split-Path $rel -Leaf
            $item = Get-ChildItem -LiteralPath (Split-Path $dst) -File -Force | Where-Object { $_.Name -eq $leaf } | Select-Object -First 1
            if ($item.Name -cne $leaf) {
                $oldRepoPath = $item.FullName.Substring($repoRoot.Length + 1).Replace('\', '/')
                Remove-Item -Force $item.FullName
                $ErrorActionPreference = 'Continue'
                & git -C $repoRoot rm --cached -q --ignore-unmatch -- $oldRepoPath 2>$null
                $ErrorActionPreference = 'Stop'
                $stats.Renamed += "$($item.Name) -> $leaf"
                $exists = $false
            }
        }
        if ($exists) {
            # compare ignoring line endings: git normalizes them anyway
            $a = [IO.File]::ReadAllText($src).Replace("`r`n", "`n")
            $b = [IO.File]::ReadAllText($dst).Replace("`r`n", "`n")
            if ($a -eq $b) { continue }
            $stats.Updated++
        }
        else {
            New-Item -ItemType Directory -Force -Path (Split-Path $dst) | Out-Null
            $stats.Added++
        }
        Copy-Item -Force $src $dst
    }

    foreach ($rel in @(Get-RelativeFiles $target)) {
        if ($genSet.ContainsKey($rel) -or $rel -eq '.swagger-codegen-ignore' -or (Test-Ignored $rel $patterns)) { continue }
        Remove-Item -Force (Join-Path $target $rel)
        $stats.Deleted += $rel
    }
    # drop directories left empty by deletions
    Get-ChildItem $target -Recurse -Directory -Force | Sort-Object { $_.FullName.Length } -Descending |
        Where-Object { $_.Name -notin $protectedDirs -and -not (Get-ChildItem $_.FullName -Force) } |
        ForEach-Object { Remove-Item -Force $_.FullName }
    return $stats
}

# --- 1. spec ---------------------------------------------------------------
if (-not $SkipExport) {
    Write-Step 'Exporting spec from service'
    $specChanged = & (Join-Path $PSScriptRoot 'export-spec.ps1') -ServiceRepo $ServiceRepo
    if (-not $specChanged -and -not $Force) {
        Write-Host 'Spec unchanged; nothing to do (use -Force to regenerate anyway).'
        return
    }
}
if (-not (Test-Path $specPath)) { throw "Spec not found: $specPath" }
$spec = Get-Content $specPath -Raw | ConvertFrom-Json

# --- 2-3. generate, sync, post-process -------------------------------------
$javaHome = & (Join-Path $PSScriptRoot 'get-java.ps1')
$java = Join-Path $javaHome 'bin\java.exe'
$jar = & (Join-Path $PSScriptRoot 'get-codegen.ps1')
$workDir = Join-Path ([IO.Path]::GetTempPath()) "aspose-pdf-aws-sdk-$PID"
New-Item -ItemType Directory -Force -Path $workDir | Out-Null

$failures = @()
try {
    foreach ($client in $targets) {
        Write-Step "Generating $($client.name) ($($client.generator))"
        $target = Join-Path $repoRoot $client.output
        $generated = Join-Path $workDir $client.name
        $patterns = @(Get-IgnorePatterns $target)

        $config = Get-Content (Join-Path $repoRoot $client.config) -Raw | ConvertFrom-Json
        if ($Version) { $config | Add-Member -Force -NotePropertyName $client.versionKey -NotePropertyValue $Version }
        $configPath = Join-Path $workDir "$($client.name).json"
        $config | ConvertTo-Json | Set-Content -Encoding ASCII $configPath

        $log = Join-Path $workDir "$($client.name).log"
        $ErrorActionPreference = 'Continue'   # java logs to stderr; must not be treated as a failure
        & $java -jar $jar generate -l $client.generator -i $specPath -o $generated -c $configPath *> $log
        $exit = $LASTEXITCODE
        $ErrorActionPreference = 'Stop'
        if ($exit -ne 0 -or -not (Test-Path $generated)) {
            Get-Content $log | Select-Object -Last 30 | Out-Host
            throw "swagger-codegen failed for $($client.name)"
        }
        Get-Content $log | Where-Object { $_ -cmatch '\bERROR\b' } | ForEach-Object { Write-Host "  $_" -ForegroundColor Red }

        if ($client.generatedSubdir) { $generated = Join-Path $generated $client.generatedSubdir }

        # post-process before syncing, so an unchanged spec yields no changes
        if ($client.postprocess) {
            & (Join-Path $repoRoot $client.postprocess) -ClientDir $generated
        }

        New-Item -ItemType Directory -Force -Path $target | Out-Null
        $s = Sync-Client $generated $target $patterns
        Write-Host "  $($s.Added) added, $($s.Updated) updated, $($s.Deleted.Count) deleted, $($s.Renamed.Count) renamed, $($s.Kept) kept (hand-maintained)"
        foreach ($d in $s.Deleted) { Write-Host "  - $d" -ForegroundColor DarkYellow }
        foreach ($r in $s.Renamed) { Write-Host "  ~ $r" -ForegroundColor DarkYellow }
    }
}
finally {
    Remove-Item -Recurse -Force $workDir -ErrorAction SilentlyContinue
}

# --- 4. endpoint coverage --------------------------------------------------
Write-Step 'Checking endpoint coverage'
# path templates differ per language ({id} vs ${...}), so match the literal part before the first parameter
$endpoints = $spec.paths.PSObject.Properties.Name | ForEach-Object { ($_ -split '\{')[0] } | Sort-Object -Unique
foreach ($client in $targets) {
    $srcDir = Join-Path (Join-Path $repoRoot $client.output) $client.sources
    $code = (Get-ChildItem $srcDir -Recurse -File | ForEach-Object { [IO.File]::ReadAllText($_.FullName) }) -join "`n"
    # match the endpoint followed by a non-path character, so /remove does not match /remove-watermark
    $missing = $endpoints | Where-Object { $code -notmatch ([regex]::Escape($_) + '(?![\w-])') }
    if ($missing) {
        $failures += "$($client.name): missing endpoints $($missing -join ', ')"
        Write-Host "  $($client.name): MISSING $($missing -join ', ')" -ForegroundColor Red
    }
    else {
        Write-Host "  $($client.name): all $(@($endpoints).Count) endpoints present" -ForegroundColor Green
    }
}

# --- 5. build ----------------------------------------------------------------
function Invoke-Build([string]$name, [scriptblock]$build) {
    Write-Host "  $name..." -NoNewline
    $log = Join-Path ([IO.Path]::GetTempPath()) "aspose-pdf-aws-sdk-build-$name.log"
    $ErrorActionPreference = 'Continue'   # build tools write progress to stderr
    $global:LASTEXITCODE = 0
    try { & $build 2>&1 | ForEach-Object { "$_" } | Out-File -Encoding utf8 $log; $ok = ($LASTEXITCODE -eq 0) }
    catch { "$_" | Out-File -Encoding utf8 -Append $log; $ok = $false }
    if ($ok) { Write-Host ' ok' -ForegroundColor Green }
    else {
        Write-Host " FAILED (log: $log)" -ForegroundColor Red
        Get-Content $log | Select-String -CaseSensitive -Pattern 'error:|error [A-Z]+\d+|What went wrong|^> |^e: ' |
            Select-Object -First 15 | ForEach-Object { Write-Host "    $($_.Line)" }
        $script:failures += "$name build failed (log: $log)"
    }
}

if (-not $SkipBuild) {
    Write-Step 'Building clients'
    $env:JAVA_HOME = $javaHome
    foreach ($client in $targets) {
        $dir = Join-Path $repoRoot $client.output
        switch ($client.name) {
            'dotnet' {
                $proj = Get-ChildItem $dir -Filter *.csproj | Select-Object -First 1
                Invoke-Build 'dotnet' { dotnet build $proj.FullName -nologo -v quiet }
            }
            { $_ -in 'java', 'kotlin' } {
                $task = if ($_ -eq 'java') { 'compileJava' } else { 'compileKotlin' }
                Invoke-Build $_ { Push-Location $dir; try { & .\gradlew.bat $task --no-daemon -q } finally { Pop-Location } }
            }
            'php' {
                if (Get-Command php -ErrorAction SilentlyContinue) {
                    Invoke-Build 'php' {
                        $bad = 0
                        Get-ChildItem (Join-Path $dir 'lib') -Recurse -Filter *.php | ForEach-Object {
                            & php -l $_.FullName | Out-Null; if ($LASTEXITCODE -ne 0) { $bad++; Write-Output "error in $($_.FullName)" }
                        }
                        $global:LASTEXITCODE = [int]($bad -gt 0)
                    }
                }
                else { Write-Host '  php... skipped (php not on PATH)' -ForegroundColor DarkYellow }
            }
            'typescript' {
                if (Get-Command npm -ErrorAction SilentlyContinue) {
                    Invoke-Build 'typescript' {
                        # compile against Angular in a scratch project; the client itself ships no package.json
                        $tsDir = Join-Path ([IO.Path]::GetTempPath()) 'aspose-pdf-aws-sdk-tscheck'
                        if (-not (Test-Path (Join-Path $tsDir 'node_modules/@angular/common'))) {
                            New-Item -ItemType Directory -Force -Path $tsDir | Out-Null
                            Push-Location $tsDir
                            try {
                                npm init -y | Out-Null
                                npm install --no-audit --no-fund typescript@5.4.5 '@angular/core@17.3.12' '@angular/common@17.3.12' rxjs@7.8.1
                            } finally { Pop-Location }
                        }
                        $src = Join-Path $tsDir 'client'
                        if (Test-Path $src) { Remove-Item -Recurse -Force $src }
                        Copy-Item -Recurse $dir $src
                        & node (Join-Path $tsDir 'node_modules/typescript/bin/tsc') --noEmit --strict false --skipLibCheck `
                            --experimentalDecorators --target es2020 --moduleResolution node --module es2020 `
                            --typeRoots (Join-Path $tsDir 'node_modules/@types') (Join-Path $src 'index.ts')
                    }
                }
                else { Write-Host '  typescript... skipped (npm not on PATH)' -ForegroundColor DarkYellow }
            }
        }
    }
}

# --- 6. README ---------------------------------------------------------------
if ($Readme) {
    Write-Step 'Regenerating README.md'
    $genProject = Join-Path $ServiceRepo 'Aspose.Pdf.RestApi.Generator'
    Copy-Item -Force $specPath (Join-Path $ServiceRepo 'Aspose.Pdf.RestApi\swagger.json')
    # code examples in the README are extracted from this repository's client docs
    $env:ASPOSE_PDF_SDK_DIR = $repoRoot
    Push-Location $genProject
    try {
        & dotnet run -c Release
        if ($LASTEXITCODE -ne 0) { throw 'README generator failed' }
    }
    finally { Pop-Location }
    Copy-Item -Force (Join-Path $ServiceRepo 'Aspose.Pdf.RestApi\Docs\aspose_pdf_for_aws.md') (Join-Path $repoRoot 'README.md')
    Write-Host "README.md updated. The generator also changed files in $ServiceRepo; review them there."
}

# --- summary -----------------------------------------------------------------
Write-Step 'Summary'
$ErrorActionPreference = 'Continue'   # git warns about line endings on stderr
$status = @(& git -c core.safecrlf=false -C $repoRoot status --porcelain -- $targets.output 2>$null)
Write-Host "$($status.Count) path(s) changed in client folders:"
& git -c core.safecrlf=false -C $repoRoot diff --shortstat -- $targets.output 2>$null
$ErrorActionPreference = 'Stop'
$new = @($status | Where-Object { $_.StartsWith('??') }).Count
if ($new) { Write-Host " plus $new untracked path(s) (new files)" }
if ($failures) {
    Write-Host "`n$($failures.Count) problem(s):" -ForegroundColor Red
    $failures | ForEach-Object { Write-Host "  - $_" -ForegroundColor Red }
    exit 1
}
Write-Host 'All clients regenerated and verified. Review with `git diff` and commit.' -ForegroundColor Green
