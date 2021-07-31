---
-api-id: T:Windows.Media.DialProtocol.DialDevice
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class DialDevice : Windows.Media.DialProtocol.IDialDevice, Windows.Media.DialProtocol.IDialDevice2
-->

# Windows.Media.DialProtocol.DialDevice

## -description
Represents the remote device capable of running DIAL apps.

## -remarks
Get an instance of this class by handling the [DialDeviceSelected](dialdevicepicker_dialdeviceselected.md) event and accessing the [DialDeviceSelectedEventArgs.SelectedDialDevice](dialdeviceselectedeventargs_selecteddialdevice.md) or by handling the [DisconnectButtonClicked](dialdevicepicker_disconnectbuttonclicked.md) handler and accessing the [DialDisconnectButtonClickedEventArgs.Device](dialdisconnectbuttonclickedeventargs_device.md) property.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | FriendlyName |
| 1511 | 10586 | Thumbnail |

## -examples

## -see-also
