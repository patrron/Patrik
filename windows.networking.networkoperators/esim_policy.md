---
-api-id: P:Windows.Networking.NetworkOperators.ESim.Policy
-api-type: winrt property
---

<!-- Property syntax.
public ESimPolicy Policy { get; }
-->

# Windows.Networking.NetworkOperators.ESim.Policy

## -description
Gets the policy for the eSIM, regarding whether the eSIM should be shown on the Local User Interface (LUI) for eSIM management.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store then you will need to request special approval to use the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Special and restricted capabilities](/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -property-value
The policy for the eSIM, regarding whether the eSIM should be shown on the LUI for eSIM management.

## -remarks
LUI is defined in [SGP.22](https://www.gsma.com/newsroom/all-documents/sgp-22-v2-2-technical-specification) (the published eSIM standard).

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe