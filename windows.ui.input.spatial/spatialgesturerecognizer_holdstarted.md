---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.HoldStarted
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler HoldStarted<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialHoldStartedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.HoldStarted

## -description

Occurs when an interaction becomes a [Hold](spatialgesturesettings.md) gesture.

## -remarks

For hand interactions, the [SpatialHoldStartedEventArgs](spatialholdstartedeventargs.md) event fires when a finger is held pressed for longer than the Hold time threshold.

For speech interactions, this event does not fire.

For motion controller interactions, this event fires when the Select trigger or button is held pressed for longer than the Hold time threshold.

## -examples

## -see-also
