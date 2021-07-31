---
-api-id: M:Windows.Devices.Sensors.OrientationSensor.GetCurrentReading
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.OrientationSensorReading GetCurrentReading()
-->

# Windows.Devices.Sensors.OrientationSensor.GetCurrentReading

## -description
Gets the current sensor reading.

## -returns
The current sensor reading.

## -remarks
An application may use this method to poll the sensor for the current reading as an alternative to registering a [ReadingChanged](orientationsensor_readingchanged.md) event handler. This would be the preferred alternative for an application that updates its user interface at a specific frame rate. Whether polling once or many times, the application must establish a desired [ReportInterval](orientationsensor_reportinterval.md). This informs the sensor driver that resources should be allocated to satisfy subsequent polling requests

Before using the return value from this method, the application must first check that the value is not null. (If the value is null and you attempt to retrieve it, Windows will generate an exception.)

The following example demonstrates how a UWP app built with XAML and C# retrieves the current reading for the orientation sensor.



[!code-csharp[GetCurrentReadingCS](../windows.devices.sensors/code/orientation/csharp/Scenario2.xaml.cs#SnippetGetCurrentReadingCS)]

The following example demonstrates how a UWP app built for Windows using JavaScript retrieves the current reading for the orientation sensor.



[!code-js[GetReadingJS](../windows.devices.sensors/code/orientation/javascript/scenario2.js#SnippetGetReadingJS)]

## -examples

## -see-also
