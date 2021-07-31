---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandSarManager.HysteresisTimerPeriod
-api-type: winrt property
---

<!-- Property syntax.
public TimeSpan HysteresisTimerPeriod { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandSarManager.HysteresisTimerPeriod

## -description
Gets the time window of the hysteresis timer that is used to determine antenna's transmission state.

> [!NOTE]
> To use this API you will need to contact Microsoft to request the special capability **microsoft.cellularSARConfiguration_8wekyb3d8bbwe**. For more info, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations?branch=live), and [Creating a custom capability to pair a driver with a Hardware Support App](/windows-hardware/drivers/devapps/creating-a-custom-capability-to-pair-driver-with-hsa?branch=live).

## -property-value
The time window of the hysteresis timer.

## -remarks
This value is in the range 1 ~ 5, in seconds.

## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl, microsoft.cellularSARConfiguration_8wekyb3d8bbwe