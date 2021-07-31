---
-api-id: M:Windows.ApplicationModel.Search.LocalContentSuggestionSettings.#ctor
-api-type: winrt method
---

<!-- Method syntax
public LocalContentSuggestionSettings()
-->

# Windows.ApplicationModel.Search.LocalContentSuggestionSettings.LocalContentSuggestionSettings

## -description

Creates a new instance of the [LocalContentSuggestionSettings](localcontentsuggestionsettings.md) class.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), [SearchContract](/uwp/api/windows.applicationmodel.search.searchcontract)) or SearchBox ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) APIs in apps for Windows 10.

When you create a new [LocalContentSuggestionSettings](localcontentsuggestionsettings.md) object, the [Enabled](localcontentsuggestionsettings_enabled.md) property is `true` by default.

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [LocalContentSuggestionSettings class](localcontentsuggestionsettings.md), [LocalContentSuggestionSettings.Enabled property](localcontentsuggestionsettings_enabled.md), [SearchPane.SetLocalContentSuggestionSettings method](searchpane_setlocalcontentsuggestionsettings_156524340.md)
