param ($pfx, $pw, $sha, $vsix)

&packages\Microsoft.VSSDK.VsixSignTool.16.0.28727\tools\vssdk\vsixsigntool.exe sign /v `
	/f $pfx `
	/sha1 $sha `
	/p $pw `
	/fd sha256 `
	/tr http://timestamp.digicert.com /td sha256 `
	$vsix
