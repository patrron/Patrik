---
-api-id: T:Windows.Services.Maps.OfflineMaps.OfflineMapPackage
-api-type: winrt class
---

<!-- Class syntax.
public class OfflineMapPackage
-->

# Windows.Services.Maps.OfflineMaps.OfflineMapPackage

## -description
Represents the map data for a particular geographical region. The data can be downloaded and used offline.

## -remarks
Use this class to asynchronously find map packages that you are interested in using offline. You can check the status of packages to determine whether those packages exist on your local system. If they do not, you can asynchronously download them to your system.

You can then access that data in system controls such as the [MapControl](../windows.ui.xaml.controls.maps/mapcontrol.md), and from other objects in the [Windows.Services.Maps](../windows.services.maps/windows_services_maps.md) namespace.

## -see-also

## -examples
The following example finds a map packages by using a geographical location. If the map package has not been previously downloaded to the local system, this code asynchronously downloads that map.

> [!NOTE]
> The points near a border or large boxes and circles might return multiple map package matches.

```csharp

private async Task getMapPackages()
{
    Geopoint myPoint = new Geopoint(new BasicGeoposition()
    {
        //Geopoint for Seattle
        Latitude = 47.604,
        Longitude = -122.329
    });

    var queryResult = await OfflineMapPackage.FindPackagesAsync(myPoint);

    if (queryResult.Status == OfflineMapPackageQueryStatus.Success)
    {
        foreach (OfflineMapPackage package in queryResult.Packages)
        {
            if (package.Status != OfflineMapPackageStatus.Downloaded)
            {
                var downloadRequestResult = await package.RequestStartDownloadAsync();

                if (downloadRequestResult.Status == OfflineMapPackageStartDownloadStatus.Success)
                {
                    // do something with the offline map package.
                }
            }
        }
    }
}

```
