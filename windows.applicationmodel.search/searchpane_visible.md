---
-api-id: P:Windows.ApplicationModel.Search.SearchPane.Visible
-api-type: winrt property
---

<!-- Property syntax
public bool Visible { get; }
-->

# Windows.ApplicationModel.Search.SearchPane.Visible

## -description
Indicates whether the search pane is open.

## -property-value
True if the search pane is being displayed; otherwise false.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](https://docs.microsoft.com/previous-versions/windows/apps/dn301949(v=win.10)) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

## -examples

## -see-also
[SearchPane class](searchpane.md), [SearchPane.Show methods](searchpane_show_1323631364.md), [SearchPane.VisibilityChanged event](searchpane_visibilitychanged.md), [SearchPaneVisibilityChangedEventArgs class](searchpanevisibilitychangedeventargs.md)