---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetClickablePointCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.Foundation.Point GetClickablePointCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetClickablePointCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetClickablePoint](automationpeer_getclickablepoint_955785073.md) or an equivalent Microsoft UI Automation client API.

## -returns
A point within the clickable area of the element.

## -remarks
The base implementation returns a default [Point](../windows.foundation/point.md) (coordinates 0,0). Peers that represent items defer to the container. [ScrollBarAutomationPeer](scrollbarautomationpeer.md) and [SliderAutomationPeer](sliderautomationpeer.md) both have behavior that can't adequately express one point for the purposes of [GetClickablePoint](automationpeer_getclickablepoint_955785073.md) scenarios, so these return a [Point](../windows.foundation/point.md) where the coordinate values are [Double.NaN](https://docs.microsoft.com/dotnet/api/system.double.nan?redirectedfrom=MSDN).

> [!NOTE]
> Visual C++ component extensions (C++/CX) doesn't have a constant for **NaN**, it uses a value, which appears as "-1.#IND" followed by zeros. Automation clients using languages other than C# or Visual C++ component extensions (C++/CX) may see **NaN** represented in a different form.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](https://docs.microsoft.com/windows/uwp/accessibility/custom-automation-peers), [Accessibility](https://docs.microsoft.com/windows/uwp/accessibility/accessibility)
