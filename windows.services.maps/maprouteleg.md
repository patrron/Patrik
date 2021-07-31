---
-api-id: T:Windows.Services.Maps.MapRouteLeg
-api-type: winrt class
---

<!-- Class syntax.
public class MapRouteLeg : Windows.Services.Maps.IMapRouteLeg, Windows.Services.Maps.IMapRouteLeg2
-->

# Windows.Services.Maps.MapRouteLeg

## -description
Represents the set of actions (maneuvers) required to travel between two waypoints along a route.

## -remarks
A collection of MapRouteLeg objects is returned through the [Legs](maproute_legs.md) property of a [MapRoute](maproute.md) object. A [MapRoute](maproute.md) object is returned through the [Route](maproute.md) property of the [MapRouteFinderResult](maproutefinderresult.md) when you call the methods of the [MapRouteFinder](maproutefinder.md) class.

Your [Universal Windows app](https://docs.microsoft.com/windows/uwp/get-started/universal-application-platform-guide) must be authenticated before it can use the [MapControl](../windows.ui.xaml.controls.maps/mapcontrol.md) and map services in the [Windows.Services.Maps](windows_services_maps.md) namespace. To authenticate your app, you must specify a maps authentication key.

See [Request a maps authentication key](https://docs.microsoft.com/windows/uwp/maps-and-location/authentication-key).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | DurationWithoutTraffic |
| 1703 | 15063 | TrafficCongestion |

## -examples

## -see-also
[Display  routes and directions on a map](https://docs.microsoft.com/windows/uwp/maps-and-location/routes-and-directions)
