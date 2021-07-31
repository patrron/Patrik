---
-api-id: T:Windows.Storage.ApplicationDataCreateDisposition
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.ApplicationDataCreateDisposition : int
-->

# ApplicationDataCreateDisposition

## -description
Specifies options for creating application data containers or returning existing containers. This enumeration is used by the [ApplicationDataContainer.CreateContainer](applicationdatacontainer_createcontainer_1839874827.md) method.

## -enum-fields
### -field Always:0
Always returns the specified container. Creates the container if it does not exist.

### -field Existing:1
Returns the specified container only if it already exists. Raises an exception of type **System.Exception** if the specified container does not exist.

## -remarks

## -examples
See the code example in [ApplicationDataContainer](applicationdatacontainer.md).

## -see-also
[Quickstart: Local application data (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/hh465118(v=win.10)), [Store and retrieve settings and other app data](https://docs.microsoft.com/windows/uwp/app-settings/store-and-retrieve-app-data), [Quickstart: Roaming application data (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/hh465123(v=win.10)), [Store and retrieve settings and other app data](https://docs.microsoft.com/windows/uwp/app-settings/store-and-retrieve-app-data), [Store and retrieve settings and other app data](https://docs.microsoft.com/windows/uwp/app-settings/store-and-retrieve-app-data), [ApplicationDataContainer.CreateContainer](applicationdatacontainer_createcontainer_1839874827.md)
