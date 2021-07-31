---
-api-id: M:Windows.Services.Cortana.CortanaSettings.GetDefault
-api-type: winrt method
---

<!-- Method syntax.
public CortanaSettings CortanaSettings.GetDefault()
-->

# Windows.Services.Cortana.CortanaSettings.GetDefault

## -description

Retrieves the Cortana settings for the current user.

## -returns

A CortanaSettings object.

## -remarks

The [CortanaSettings](cortanasettings.md) class requires the following be added to the Package.appmanifest:

- To \<Package\>
  - `IgnorableNamespaces="iot"`
- Under \<Capabilities\>
  - `<iot:Capability Name="systemManagement"/>`

## -see-also

## -examples
