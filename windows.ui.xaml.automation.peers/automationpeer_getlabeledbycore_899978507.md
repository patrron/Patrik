---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetLabeledByCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.UI.Xaml.Automation.Peers.AutomationPeer GetLabeledByCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetLabeledByCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetLabeledBy](automationpeer_getlabeledby_1845689.md) or an equivalent Microsoft UI Automation client API.

## -returns
The [AutomationPeer](automationpeer.md) for the element that is targeted by the [UIElement](../windows.ui.xaml/uielement.md).

## -remarks
Specifying a control behavior for labeling is uncommon except for composite data presentation controls that use headers or similar metaphors. In most cases apps establish labeling information between the elements in an app-specific UI by applying the [AutomationProperties.LabeledBy](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property to the UI definition XAML.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](https://docs.microsoft.com/windows/uwp/accessibility/custom-automation-peers), [Accessibility](https://docs.microsoft.com/windows/uwp/accessibility/accessibility)
