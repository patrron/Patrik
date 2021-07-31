---
-api-id: M:Windows.Devices.Sensors.Gyrometer.GetDefault
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.Gyrometer GetDefault()
-->

# Windows.Devices.Sensors.Gyrometer.GetDefault

## -description
Returns the default gyrometer.

## -returns
The default gyrometer or null if no integrated gyrometers are found.

## -remarks
This method only returns values for a gyrometer that has been integrated into the computer by the manufacturer. A null value will be returned if the specified sensor is not available in the system.

When a system is in Connected Standby, a call to the GetDefault method will return immediately with a null result.

The following example demonstrates how a UWP app built with XAML and C# used this method to establish a connection to the default gyrometer.



[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/gyrometer/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

The following example demonstrates how a UWP app built for Windows using JavaScript used this method to establish a connection to the default gyrometer.



[!code-js[GetDefaultJS](../windows.devices.sensors/code/gyrometer/javascript/scenario1.js#SnippetGetDefaultJS)]

## -examples

## -see-also
