param ($pfx, $pw, $sha, $vsix)
&nuget install Microsoft.VSSDK.VsixSignTool -ExcludeVersion -OutputDirectory Build
$signtool = Get-ChildItem -Path "Build/Microsoft.VSSDK.Vsixsigntool" -Recurse -Include vsixsigntool.exe 
&$signtool sign /v /f "$pfx" /sha1 $sha /p $pw /fd sha256 /tr http://timestamp.digicert.com /td sha256 $vsix
