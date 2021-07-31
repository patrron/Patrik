---
-api-id: P:Windows.ApplicationModel.Activation.LaunchActivatedEventArgs.TileId
-api-type: winrt property
---

<!-- Property syntax
public string TileId { get; }
-->

# Windows.ApplicationModel.Activation.LaunchActivatedEventArgs.TileId

## -description
Gets the ID of the tile that was invoked to launch the app.


<!-- Launch activations correspond to invocations of tiles (both primary and secondary) as well as toasts. Launch activations also occur when an app is activated for debugging using F5 in Visual Studio.-->

## -property-value
The ID of the tile that launched the app. If the app's main tile was used, this value is "App". If a secondary tile is used, the [SecondaryTile.TileId](../windows.ui.startscreen/secondarytile_tileid.md) value, assigned to the secondary tile when it was created, is returned.

## -remarks
Starting with Windows 10, **TileId** behavior is different for apps that are launched after having been terminated. Previously, the **TileId** always returned the ID of the tile that launched the app. The **TileId** behavior now depends on how the app is reactivated:<table>
   <tr><td>How the app is reactivated</td><td>Behavior of **TileId**</td></tr>
   <tr><td>The user switches to the app by using the task switcher or by using the global back key</td><td>Returns the empty string `("")`.</td></tr>
   <tr><td>The user taps the app tile</td><td>Returns the tile ID.</td></tr>
</table>

The new behavior makes it possible to differentiate between a switch to the app versus a re-launch of the app. If your app uses tile ID information during activation, handle the `TileId==""` case. For example:



```csharp
protected override void OnLaunched(LaunchActivatedEventArgs e)
{
...
  if (e.TileId == "")
  {
    // resumed from switch/backstack
  }
  else
  {
    // resumed from tile launch
  }
...
}
```



## -examples

## -see-also
