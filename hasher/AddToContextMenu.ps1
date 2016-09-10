###
# This PS script will add a shortcut to
# hasher.exe to the right-click menu of files.
# Make sure to run it as admin and 
# from the same folder as hasher.exe
###

# all keys go in here
$regpath = 'HKEY_CLASSES_ROOT\*\Shell\hasher'
# path to hasher.exe
$path = "$($PSScriptRoot)\hasher.exe"

if (-not (Test-Path $path)) {
    # we need hasher.exe in this folder
    Write-Warning "Could not find hasher.exe in the current folder"
}
else {
    # add keys to registry
    reg add $regpath /v 'MUIVerb' /d 'Get Checksums' /f
    reg add "$($regpath)\Command" /ve /d $path' \"%1\"' /f
}
# wait for user to read any warnings
Read-Host -Prompt "Hit Enter to exit..."