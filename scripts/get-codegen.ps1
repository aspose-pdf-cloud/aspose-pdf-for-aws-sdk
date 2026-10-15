<#
.SYNOPSIS
    Downloads the swagger-codegen CLI jar pinned in codegen/codegen.json into tools/ and verifies its SHA-256.
    Prints the jar path. Does nothing if a verified jar is already present.
#>
[CmdletBinding()]
param()

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$manifest = Get-Content (Join-Path $repoRoot 'codegen/codegen.json') -Raw | ConvertFrom-Json
$codegen = $manifest.codegen

$toolsDir = Join-Path $repoRoot 'tools'
$jar = Join-Path $toolsDir "swagger-codegen-cli-$($codegen.version).jar"

function Test-JarHash([string]$path) {
    (Get-FileHash -Path $path -Algorithm SHA256).Hash -eq $codegen.sha256.ToUpperInvariant()
}

if ((Test-Path $jar) -and (Test-JarHash $jar)) {
    return $jar
}

New-Item -ItemType Directory -Force -Path $toolsDir | Out-Null
$tmp = "$jar.download"
Write-Host "Downloading swagger-codegen-cli $($codegen.version)..."
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
Invoke-WebRequest -Uri $codegen.url -OutFile $tmp -UseBasicParsing

if (-not (Test-JarHash $tmp)) {
    Remove-Item $tmp -Force
    throw "SHA-256 mismatch for $($codegen.url); expected $($codegen.sha256)"
}
Move-Item -Force $tmp $jar
return $jar
