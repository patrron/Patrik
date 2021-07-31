---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObject.FindAllAsync(Windows.Devices.Enumeration.Pnp.PnpObjectType,Windows.Foundation.Collections.IIterable{System.String},System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Enumeration.Pnp.PnpObjectCollection> FindAllAsync(Windows.Devices.Enumeration.Pnp.PnpObjectType type, Windows.Foundation.Collections.IIterable<System.String> requestedProperties, System.String aqsFilter)
-->

# Windows.Devices.Enumeration.Pnp.PnpObject.FindAllAsync

## -description
Returns all of the PnP objects of a specified type that match the specified filter.

## -parameters
### -param type
The type of the [PnpObject](pnpobject.md).

### -param requestedProperties
An iterable list of additional properties to include in the [Properties](pnpobject_properties.md) property of the [PnpObject](pnpobject.md) objects included in enumeration results. For more info on what the properties represent, see [Device information properties](https://docs.microsoft.com/windows/uwp/devices-sensors/device-information-properties).

### -param aqsFilter
An AQS string that filters the PnP objects that will be returned. Typically, this string is retrieved from the  method of a class that interacts with devices.

## -returns
An object that represents the asynchronous operation.

## -remarks

## -examples

## -see-also
[FindAllAsync(PnpObjectType, IIterable_1)](pnpobject_findallasync_1097308762.md)