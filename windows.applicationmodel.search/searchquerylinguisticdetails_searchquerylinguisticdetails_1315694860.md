---
-api-id: M:Windows.ApplicationModel.Search.SearchQueryLinguisticDetails.#ctor(Windows.Foundation.Collections.IIterable{System.String},System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public SearchQueryLinguisticDetails(Windows.Foundation.Collections.IIterable<System.String> queryTextAlternatives, System.UInt32 queryTextCompositionStart, System.UInt32 queryTextCompositionLength)
-->

# Windows.ApplicationModel.Search.SearchQueryLinguisticDetails.SearchQueryLinguisticDetails

## -description

Initializes a new instance of the [SearchQueryLinguisticDetails](searchquerylinguisticdetails.md) class.

## -parameters

### -param queryTextAlternatives

A list of the text alternatives for the current query text.

### -param queryTextCompositionStart

The starting location of the text that the user is composing with an Input Method Editor (IME).

### -param queryTextCompositionLength

The length of the portion of the query text that the user is composing with an Input Method Editor (IME).

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), [SearchContract](/uwp/api/windows.applicationmodel.search.searchcontract)) or SearchBox ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) APIs in apps for Windows 10.

## -examples

## -see-also
