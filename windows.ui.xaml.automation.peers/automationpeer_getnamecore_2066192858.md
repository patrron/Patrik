---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetNameCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected string GetNameCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetNameCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetName](automationpeer_getname_1386609741.md) or an equivalent Microsoft UI Automation client API.

## -returns
The name as used by assistive technology and other Microsoft UI Automation clients.

## -remarks
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) introduces behavior to [GetName](automationpeer_getname_1386609741.md) by providing an intermediate GetNameCore implementation. If an element has a value for the **LabeledBy**Microsoft UI Automation property, the labeling element's **Name** value is used as the **Name**.

[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) also introduces behavior through an internal **GetPlainText** method that other default peer classes may override in order to access the content model of that control and return a useful default for **Name**. For example, any [ContentControl](../windows.ui.xaml.controls/contentcontrol.md) derived class will use a string representation of its [Content](../windows.ui.xaml.controls/contentcontrol_content.md) value as the default **Name**. This is enabled because internally [ContentControl](../windows.ui.xaml.controls/contentcontrol.md) implements **GetPlainText** and imparts that behavior to all [ContentControl](../windows.ui.xaml.controls/contentcontrol.md) derived classes. This is how you get a useful **Name** default from the string value of a [Button](../windows.ui.xaml.controls/button.md), for example.

Other specific peers also may have an intermediate GetNameCore implementation that provides a useful way for that particular Windows Runtime control to provide built-in values for **Name**. The source of these values comes from other UI properties that are typically set in XAML or as app user code. For example, [TextBoxAutomationPeer](textboxautomationpeer.md) implements behavior that uses the value of the [Text](../windows.ui.xaml.controls/textbox_text.md) property from the owner [TextBox](../windows.ui.xaml.controls/textbox.md) as the default **Name**. From the user code perspective, the default behavior can be overridden by applying a different [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) value. From the peer implementer / provider perspective, the default behavior of the peer can be changed by deriving a new peer class from the existing peer, overriding GetNameCore, and giving it a new implementation that wouldn't call the base implementation in at least some cases.

To learn more about the possible default behavior of specific peer classes for default Windows Runtime controls, see the reference topic for that particular peer class and look for implementation notes in the Remarks section.

## -examples

## -see-also
[GetName](automationpeer_getname_1386609741.md), [Custom automation peers](https://docs.microsoft.com/windows/uwp/accessibility/custom-automation-peers)
