---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandModemIsolation.ClearConfigurationAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction MobileBroadbandModemIsolation.ClearConfigurationAsync()
-->

# Windows.Networking.NetworkOperators.MobileBroadbandModemIsolation.ClearConfigurationAsync

## -description
Asynchronously allows all traffic through the modem.

## -returns
An asynchronous action.

## -remarks
If you called [ApplyConfigurationAsync](mobilebroadbandmodemisolation_applyconfigurationasync_10015633.md) to isolate the modem, then calling this method clears that isolation configuration. If you called [AllowDataProvisioning](mobilebroadbandmodemisolation_allowdataprovisioning_1931471842.md) to add data-provisioning rules, then calling this method clears those rules.

## -see-also

## -examples

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
