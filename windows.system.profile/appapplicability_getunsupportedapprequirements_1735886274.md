---
-api-id: M:Windows.System.Profile.AppApplicability.GetUnsupportedAppRequirements(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public IVectorView<UnsupportedAppRequirement> AppApplicability.GetUnsupportedAppRequirements(IIterable<String> capabilities)
-->

# Windows.System.Profile.AppApplicability.GetUnsupportedAppRequirements

## -description

Given a list of [App Capabilities](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations) required by an app, returns a list of [UnsupportedAppRequirement](unsupportedapprequirement.md) objects representing capabilities in the list that are not supported on the current device

## -parameters

### -param capabilities

A list of [App Capability](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations) strings

## -returns

A collection of [UnsupportedAppRequirement](unsupportedapprequirement.md) objects that represents the requested capabilities not supported on the current device.

## -remarks

## -see-also

[App Capability Declarations](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations)

## -examples

