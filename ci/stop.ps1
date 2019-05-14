$healthprocess = Get-Process netdemo-client -ErrorAction SilentlyContinue
if ($healthprocess -and !$healthprocess.HasExited) {
	$healthprocess | Stop-Process -Force
}