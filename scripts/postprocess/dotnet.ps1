<#
.SYNOPSIS
    Ports csharp-dotnet2 generated code (written for RestSharp 105) to RestSharp 110.
    Replaces Client/dotnet-client-port.sh and Client/dotnet-client-prt.ps1 from the service repo.
    Idempotent: running it on already ported code changes nothing.
    ApiClient.cs is hand-maintained (see dotnet-client/.swagger-codegen-ignore) and is not touched here.

.PARAMETER ClientDir
    Root of the generated .NET client.
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)][string]$ClientDir
)

$ErrorActionPreference = 'Stop'

# Regex pattern -> replacement, applied in order to every generated .cs file
$replacements = @(
    @('\bIRestResponse\b', 'RestResponse'),
    @('\bMethod\.POST\b', 'Method.Post'),
    @('\bMethod\.GET\b', 'Method.Get'),
    @('\bMethod\.PUT\b', 'Method.Put'),
    @('\bMethod\.DELETE\b', 'Method.Delete'),
    @('\bMethod\.PATCH\b', 'Method.Patch'),
    @('IList<Parameter> headers\s*=\s*null', 'IReadOnlyCollection<Parameter> headers=null'),
    @('RestSharp\.Contrib\.HttpUtility\.UrlEncode\(', 'HttpUtility.UrlEncode('),
    # uploaded files are sent as multipart file parameters, not as a form field
    @('List<byte\[\]> files\b', 'List<FileParameter> files'),
    @('if \(files != null\) formParams\.Add\("files", ApiClient\.ParameterToString\(files\)\);',
      'if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f);')
)

$utf8NoBom = New-Object System.Text.UTF8Encoding($false)
$changed = 0
Get-ChildItem -Path $ClientDir -Filter *.cs -Recurse |
    Where-Object { $_.FullName -notmatch '[\\/](bin|obj)[\\/]' -and $_.Name -ne 'ApiClient.cs' } |
    ForEach-Object {
        $original = [IO.File]::ReadAllText($_.FullName)
        $content = $original
        foreach ($r in $replacements) { $content = $content -creplace $r[0], $r[1] }

        if ($content -ne $original) {
            [IO.File]::WriteAllText($_.FullName, $content, $utf8NoBom)
            $changed++
        }
    }

Write-Host "dotnet post-process: $changed file(s) updated."
