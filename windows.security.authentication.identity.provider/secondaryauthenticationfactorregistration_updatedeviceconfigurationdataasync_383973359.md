---
-api-id: M:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration.UpdateDeviceConfigurationDataAsync(System.String,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction UpdateDeviceConfigurationDataAsync(System.String deviceId, Windows.Storage.Streams.IBuffer deviceConfigurationData)
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration.UpdateDeviceConfigurationDataAsync

## -description
Updates the configuration data of a companion device.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](https://aka.ms/appcap). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](https://docs.microsoft.com/windows/uwp/security/companion-device-unlock) overview.

## -parameters
### -param deviceId
The Id of the device to update.

### -param deviceConfigurationData
The updated configuration data. This data is capped at 4KB.

## -returns
This method does not return a value.

## -remarks

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](https://docs.microsoft.com/windows/uwp/security/companion-device-unlock)