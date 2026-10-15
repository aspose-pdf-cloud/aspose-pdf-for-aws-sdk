<#
.SYNOPSIS
    Raises the generated Java client's language level from 1.7 (codegen default) to Java 21 and adds
    javax.annotation-api, which the generated @javax.annotation.Generated needs on Java 11+.
    Idempotent.

.PARAMETER ClientDir
    Root of the generated Java client.
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)][string]$ClientDir
)

$ErrorActionPreference = 'Stop'

# file -> list of (regex pattern, replacement)
$annotationApi = 'javax.annotation:javax.annotation-api:1.3.2'
$edits = [ordered]@{
    'build.gradle' = @(
        @('JavaVersion\.VERSION_1_7\b', 'JavaVersion.VERSION_21'),
        @("(?m)^(\s*)implementation 'io\.swagger\.core\.v3:swagger-annotations:([^']+)'\r?\n(?!\s*implementation '$([regex]::Escape($annotationApi))')",
          "`$0`${1}implementation '$annotationApi'`n")
    )
    'pom.xml'      = @(
        @('<java\.version>1\.7</java\.version>', '<java.version>21</java.version>'),
        # top-level <dependencies> only (2-space indent), not plugin ones
        @('(?ms)^(  <dependencies>)(?!.*<artifactId>javax\.annotation-api</artifactId>)',
          "`$1`n    <dependency>`n      <groupId>javax.annotation</groupId>`n      <artifactId>javax.annotation-api</artifactId>`n      <version>1.3.2</version>`n    </dependency>")
    )
    'README.md'    = @(, @('Java 1\.7\+', 'Java 21+'))
}

$utf8NoBom = New-Object System.Text.UTF8Encoding($false)
$changed = 0
foreach ($name in $edits.Keys) {
    $path = Join-Path $ClientDir $name
    if (-not (Test-Path $path)) { continue }
    $original = [IO.File]::ReadAllText($path)
    $content = $original
    foreach ($r in $edits[$name]) { $content = $content -creplace $r[0], $r[1] }
    if ($content -ne $original) {
        [IO.File]::WriteAllText($path, $content, $utf8NoBom)
        $changed++
    }
}

Write-Host "java post-process: $changed file(s) updated."
