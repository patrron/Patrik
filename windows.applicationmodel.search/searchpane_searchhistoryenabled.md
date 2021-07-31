---
-api-id: P:Windows.ApplicationModel.Search.SearchPane.SearchHistoryEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool SearchHistoryEnabled { get;  set; }
-->

# Windows.ApplicationModel.Search.SearchPane.SearchHistoryEnabled

## -description
Indicates whether the user's previous searches with the app are automatically tracked and used to provide suggestions.

## -property-value
True if the user's search history is automatically tracked and used to provide suggestions; otherwise false. The default value is true.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](https://docs.microsoft.com/previous-versions/windows/apps/dn301949(v=win.10)) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

You can set this property to false to opt out of automatic suggestions; your app can optionally provide its own suggestions to users instead. If you decide to have your app track its own search history, you should also give the user some control over their history through the Settings charm, like the ability to clear the history.

If you set this property while the search pane is open, the change won't take effect until the user enters the next character of their query.

## -examples

## -see-also
[Guidelines and checklist for search](https://docs.microsoft.com/windows/uwp/controls-and-patterns/search), [SearchPane class](searchpane.md), [SearchPane.SearchHistoryContext property](searchpane_searchhistorycontext.md)
