---
-api-id: T:Windows.Devices.Sensors.ActivitySensor
-api-type: winrt class
---

<!-- Class syntax.
public class ActivitySensor : Windows.Devices.Sensors.IActivitySensor
-->

# Windows.Devices.Sensors.ActivitySensor

## -description

Represents an activity sensor that provides the activity and status of a sensor.

For an example implementation, see the [activity sensor sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ActivitySensor).

## -remarks

> [!NOTE]
> This class is not supported in JavaScript

In order to use ActivitySensor, you need to define the activity device capability in your app manifest file.

```
<Capabilities>
    <DeviceCapability Name="activity"/>
</Capabilities>
```

## -examples

## -see-also

[Activity detection sensor sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ActivitySensor)
