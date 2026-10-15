<#
.SYNOPSIS
    Prints the JAVA_HOME to use: $env:JAVA_HOME, else the JDK of `java` on PATH,
    else the portable Temurin JDK pinned in codegen/codegen.json (downloaded to tools/ and SHA-256 verified).
#>
[CmdletBinding()]
param()

$ErrorActionPreference = 'Stop'

if ($env:JAVA_HOME -and (Test-Path (Join-Path $env:JAVA_HOME 'bin\java.exe'))) {
    return $env:JAVA_HOME
}

$onPath = Get-Command java -ErrorAction SilentlyContinue
if ($onPath) {
    return (Split-Path -Parent (Split-Path -Parent $onPath.Source))
}

$repoRoot = Split-Path -Parent $PSScriptRoot
$jdk = (Get-Content (Join-Path $repoRoot 'codegen/codegen.json') -Raw | ConvertFrom-Json).jdk
$toolsDir = Join-Path $repoRoot 'tools'
$jdkDir = Join-Path $toolsDir "jdk-$($jdk.version)"

if (Test-Path (Join-Path $jdkDir 'bin\java.exe')) {
    return $jdkDir
}

New-Item -ItemType Directory -Force -Path $toolsDir | Out-Null
$zip = Join-Path $toolsDir "jdk-$($jdk.version).zip"
Write-Host "No Java found; downloading Temurin JDK $($jdk.version)..."
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
$ProgressPreference = 'SilentlyContinue'
Invoke-WebRequest -Uri $jdk.url -OutFile $zip -UseBasicParsing

if ((Get-FileHash -Path $zip -Algorithm SHA256).Hash -ne $jdk.sha256.ToUpperInvariant()) {
    Remove-Item $zip -Force
    throw "SHA-256 mismatch for $($jdk.url); expected $($jdk.sha256)"
}

# the archive contains a single top-level folder (jdk-<version>)
$extractDir = "$jdkDir.extract"
if (Test-Path $extractDir) { Remove-Item -Recurse -Force $extractDir }
New-Item -ItemType Directory -Force -Path $extractDir | Out-Null
if (Get-Command tar.exe -ErrorAction SilentlyContinue) {
    & tar.exe -xf $zip -C $extractDir
    if ($LASTEXITCODE -ne 0) { throw "Failed to extract $zip" }
}
else {
    Expand-Archive -Path $zip -DestinationPath $extractDir
}
$inner = Get-ChildItem $extractDir -Directory | Select-Object -First 1
Move-Item $inner.FullName $jdkDir
Remove-Item -Recurse -Force $extractDir
Remove-Item -Force $zip

return $jdkDir
