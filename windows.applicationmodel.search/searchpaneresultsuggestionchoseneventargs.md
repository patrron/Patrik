---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneResultSuggestionChosenEventArgs : Windows.ApplicationModel.Search.ISearchPaneResultSuggestionChosenEventArgs
-->

# Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs

## -description

Provides data for a [ResultSuggestionChosen](searchpane_resultsuggestionchosen.md) event that is associated with a [SearchPane](searchpane.md) object.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), [SearchContract](/uwp/api/windows.applicationmodel.search.searchcontract)) or SearchBox ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) APIs in apps for Windows 10.

This object is passed to an app's [ResultSuggestionChosen](searchpane_resultsuggestionchosen.md) event handler.

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [SearchPane class](searchpane.md), [SearchPane.ResultSuggestionChosen event](searchpane_resultsuggestionchosen.md), [SearchSuggestionCollection.AppendResultSuggestion method](searchsuggestioncollection_appendresultsuggestion_603544202.md)
