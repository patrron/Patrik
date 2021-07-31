---
-api-id: T:Windows.UI.Xaml.Automation.ValuePatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class ValuePatternIdentifiers : Windows.UI.Xaml.Automation.IValuePatternIdentifiers
-->

# Windows.UI.Xaml.Automation.ValuePatternIdentifiers

## -description
Contains values used as identifiers by [IValueProvider](../windows.ui.xaml.automation.provider/ivalueprovider.md).

## -remarks
Classes such as ValuePatternIdentifiers are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [IValueProvider](../windows.ui.xaml.automation.provider/ivalueprovider.md) in its [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) implementation. These identifiers are needed for the [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md) calls that you make from control code that references your own peer, or for [FindItemByProperty](../windows.ui.xaml.automation.provider/iitemcontainerprovider_finditembyproperty_1997743353.md) in an items container peer.

This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [IValueProvider](https://docs.microsoft.com/windows/desktop/api/uiautomationcore/nn-uiautomationcore-ivalueprovider) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[IValueProvider](../windows.ui.xaml.automation.provider/ivalueprovider.md), [IRangeValueProvider](../windows.ui.xaml.automation.provider/irangevalueprovider.md), [Control patterns and interfaces](https://docs.microsoft.com/windows/uwp/accessibility/control-patterns-and-interfaces), [Custom automation peers](https://docs.microsoft.com/windows/uwp/accessibility/custom-automation-peers)
