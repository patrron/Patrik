---
-api-id: P:Windows.UI.Xaml.Input.CharacterReceivedRoutedEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax.
public bool Handled { get;  set; }
-->

# Windows.UI.Xaml.Input.CharacterReceivedRoutedEventArgs.Handled

## -description
Gets or sets a value that marks the routed event as handled. A **true** value for **Handled** prevents most handlers along the event route from handling the same event again.

Equivalent WinUI property: [Microsoft.UI.Xaml.Input.CharacterReceivedRoutedEventArgs.Handled](/windows/winui/api/microsoft.ui.xaml.input.characterreceivedroutedeventargs.handled).

## -property-value
**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.

## -remarks

## -examples

## -see-also
[Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview)