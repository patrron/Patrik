---
-api-id: P:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest.SearchSuggestionCollection
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Search.SearchSuggestionCollection SearchSuggestionCollection { get; }
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest.SearchSuggestionCollection

## -description
 The suggestions to display in the search pane for the current query. Apps provide suggestions to display by appending them to this [searchSuggestionCollection](searchsuggestioncollection.md) object. 

## -property-value
The suggestions to display. Apps provide suggestions by appending them to this [searchSuggestionCollection](searchsuggestioncollection.md) object.

## -remarks
The search pane can display 5 suggestions, at most. Additionally, each separator you use takes the place of a suggestion and lowers the number of suggestions that you can display.

Use the [SearchSuggestionCollection](searchsuggestioncollection.md) object to append app-provided suggestions and search separators to display in the search pane.

When the request for suggestions is completed, either by returning from the [suggestionsrequested](searchpane_suggestionsrequested.md) event handler or by calling [searchPaneSuggestionsRequestDeferral.complete](searchpanesuggestionsrequestdeferral_complete_1807836922.md), the search pane displays the suggestions in the [searchSuggestionCollection](searchsuggestioncollection.md).

## -examples

## -see-also
[SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequest.GetDeferral method](searchpanesuggestionsrequest_getdeferral_254836512.md), [SearchPaneSuggestionsRequestDeferral class](searchpanesuggestionsrequestdeferral.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md)