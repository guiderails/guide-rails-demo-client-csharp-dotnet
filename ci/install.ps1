Add-Type -assembly "system.io.compression.filesystem"
$archiveName = "$env:PKG_BASE_DIR\$env:APPLICATION_NAME\netdemo-client.zip"
$installdir = "C:\Program Files\$env:APPLICATION_NAME"
Write-Output "Extracting Archive: $archiveName"

if (Test-Path -Path $installdir) {
    Remove-Item "$installdir\*" -Force -ErrorAction SilentlyContinue
}

[io.compression.zipfile]::ExtractToDirectory($archiveName, $installdir)
Write-Output "Done Extracting"

Write-Host 'Creating shortcut....'
$WshShell = New-Object -comObject WScript.Shell
$Shortcut = $WshShell.CreateShortcut("C:\Users\Public\Desktop\netdemo-client.lnk")
$Shortcut.TargetPath = "$installdir\$env:APPLICATION_NAME.exe"
$Shortcut.Save()