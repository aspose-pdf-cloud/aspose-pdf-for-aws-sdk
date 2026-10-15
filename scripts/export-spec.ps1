<#
.SYNOPSIS
    Builds the Aspose.PDF for AWS service and exports its OpenAPI spec to spec/swagger.json,
    then prints which endpoints and schemas were added, removed or changed.

.PARAMETER ServiceRepo
    Path to the AsposePdfForAws service repository.

.PARAMETER Configuration
    Build configuration of the service.

.PARAMETER NoBuild
    Use the existing service build output instead of rebuilding.

.OUTPUTS
    $true if the spec changed, $false otherwise.
#>
[CmdletBinding()]
param(
    [string]$ServiceRepo = 'D:\r\AsposePdfForAws',
    [string]$Configuration = 'Debug',
    [switch]$NoBuild
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$manifest = Get-Content (Join-Path $repoRoot 'codegen/codegen.json') -Raw | ConvertFrom-Json
$specPath = Join-Path $repoRoot $manifest.spec
$project = Join-Path $ServiceRepo 'Aspose.Pdf.RestApi'

if (-not (Test-Path (Join-Path $project 'Aspose.Pdf.RestApi.csproj'))) {
    throw "Service project not found under $project"
}

if (-not $NoBuild) {
    Write-Host "Building service ($Configuration)..."
    & dotnet build (Join-Path $project 'Aspose.Pdf.RestApi.csproj') -c $Configuration -v quiet -nologo -clp:ErrorsOnly | Out-Host
    if ($LASTEXITCODE -ne 0) { throw "Service build failed" }
}

# bin/<Configuration>/<tfm>/Aspose.Pdf.RestApi.dll; take the newest if several TFMs exist
$dll = Get-ChildItem (Join-Path $project "bin/$Configuration") -Filter 'Aspose.Pdf.RestApi.dll' -Recurse -Depth 1 |
    Sort-Object LastWriteTime -Descending | Select-Object -First 1
if (-not $dll) { throw "Aspose.Pdf.RestApi.dll not found under $project\bin\$Configuration" }

$tmpSpec = Join-Path ([IO.Path]::GetTempPath()) "aspose-pdf-aws-swagger-$PID.json"
Push-Location $dll.DirectoryName
try {
    & dotnet $dll.FullName --export-swagger $tmpSpec | Out-Host
    if ($LASTEXITCODE -ne 0) { throw "Spec export failed" }
}
finally {
    Pop-Location
}

$new = Get-Content $tmpSpec -Raw | ConvertFrom-Json
$changed = $true
if (Test-Path $specPath) {
    $old = Get-Content $specPath -Raw | ConvertFrom-Json

    function Compare-Section($title, $oldObj, $newObj) {
        $oldMap = @{}; foreach ($p in $oldObj.PSObject.Properties) { $oldMap[$p.Name] = ($p.Value | ConvertTo-Json -Depth 50 -Compress) }
        $newMap = @{}; foreach ($p in $newObj.PSObject.Properties) { $newMap[$p.Name] = ($p.Value | ConvertTo-Json -Depth 50 -Compress) }
        $added = $newMap.Keys | Where-Object { -not $oldMap.ContainsKey($_) } | Sort-Object
        $removed = $oldMap.Keys | Where-Object { -not $newMap.ContainsKey($_) } | Sort-Object
        $modified = $newMap.Keys | Where-Object { $oldMap.ContainsKey($_) -and $oldMap[$_] -ne $newMap[$_] } | Sort-Object
        Write-Host "${title}: $(@($added).Count) added, $(@($removed).Count) removed, $(@($modified).Count) changed"
        foreach ($k in $added) { Write-Host "  + $k" -ForegroundColor Green }
        foreach ($k in $removed) { Write-Host "  - $k" -ForegroundColor Red }
        foreach ($k in $modified) { Write-Host "  ~ $k" -ForegroundColor Yellow }
    }

    Compare-Section 'Endpoints' $old.paths $new.paths
    Compare-Section 'Schemas' $old.components.schemas $new.components.schemas
    $changed = (Get-FileHash $tmpSpec).Hash -ne (Get-FileHash $specPath).Hash
}

New-Item -ItemType Directory -Force -Path (Split-Path $specPath) | Out-Null
Move-Item -Force $tmpSpec $specPath
Write-Host ($(if ($changed) { "Spec updated: $specPath" } else { "Spec unchanged." }))
return $changed
