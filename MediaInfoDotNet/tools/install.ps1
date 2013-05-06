###############################################################################
#
# install.ps1 --
#
# Set CopyToOutputDirectory for content files
#
###############################################################################

param($installPath, $toolsPath, $package, $project)

$platformNames = "", "x86", "x64"
$fileNames = "MediaInfo.dll", "MediaInfoDotNet.dll.config"
$propertyName = "CopyToOutputDirectory"

foreach($platformName in $platformNames) {
  $folder = $project.ProjectItems.Item($platformName)
  if ($folder -eq $null) {
    continue
  }
  foreach($fileName in $fileNames) {
	$item = $folder.ProjectItems.Item($fileName)
	if ($item -eq $null) {
		continue
	}
	$property = $item.Properties.Item($propertyName)
	if ($property -eq $null) {
		continue
	}
	$property.Value = 1
  }
}

