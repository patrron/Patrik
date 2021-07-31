---
-api-id: T:Windows.Networking.NetworkOperators.ESimWatcherStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ESimWatcherStatus : int 
-->

# Windows.Networking.NetworkOperators.ESimWatcherStatus

## -description
Defines constants that specify the status of an [ESimWatcher](esimwatcher.md).

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -enum-fields
### -field Created:0
Indicates that the watcher has been created.

### -field Started:1
Indicates that the watcher has been started.

### -field EnumerationCompleted:2
Indicates that the watcher has finished enumerating eSIMS.

### -field Stopping:3
Indicates that the watcher is stopping.

### -field Stopped:4
Indicates that the watcher has been stopped.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe