---
-api-id: M:Windows.Networking.NetworkOperators.ESim.DownloadProfileMetadataAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ESimDownloadProfileMetadataResult> ESim.DownloadProfileMetadataAsync(String activationCode)
-->

# Windows.Networking.NetworkOperators.ESim.DownloadProfileMetadataAsync

## -description
Asynchronously downloads installation metadata for the eSIM profile that corresponds to the specified activation code.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -parameters
### -param activationCode
The activation code for the eSIM profile installation metadata to download.

## -returns
An asynchronous download operation. On successful completion, contains an [ESimDownloadProfileMetadataResult](esimdownloadprofilemetadataresult.md) object representing the result of the download operation.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe