.Synopsis
Generates the index.html file in any subdirectories named "HTML".
.Example
.\Out-Index.ps1
Wrote C:\Projects\CUFX\trunk\CUFX\Generator\bin\Debug\GeneratedFiles\HTML\index.html
#>
Set-StrictMode -Version 2.0
#requires -version 3
$HtmlFolders = ls -Recurse -Filter HTML -Directory |% FullName
if(!$HtmlFolders) { Write-Error "No HTML folders found. Make sure you run the generator tool first." }
else { write "$HtmlFolders" }
$HtmlFolders |% {
    pushd $_
    gc -raw $PSScriptRoot\index.prefix |Out-File -enc utf8 index-iframe.html
    ls *.html |
        % {"<li><a href='$([IO.Path]::GetFileName($_.FullName))'>$([IO.Path]::GetFileNameWithoutExtension($_.FullName))</a></li>"} |
        Out-File -enc utf8 index-iframe.html -Append
    Out-File -enc utf8 index-iframe.html -InputObject "</ul></body></html>" -Append
    write "Wrote $PWD\index.html"
    popd
}
