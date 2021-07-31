---
-api-id: E:Windows.UI.Xaml.Controls.WebView.FrameNavigationCompleted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler FrameNavigationCompleted<Windows.UI.Xaml.Controls.WebView,  Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs>
-->

# Windows.UI.Xaml.Controls.WebView.FrameNavigationCompleted

## -description
Occurs when a frame in the [WebView](webview.md) has finished loading its content.

## -xaml-syntax
```xaml
<WebView FrameNavigationCompleted="eventhandler"/>

```


## -remarks
[WebView](webview.md) navigation events occur in the following order:


+ [NavigationStarting](webview_navigationstarting.md)
+ [ContentLoading](webview_contentloading.md)
+ [DOMContentLoaded](webview_domcontentloaded.md)
+ [NavigationCompleted](webview_navigationcompleted.md)


Similar events occur in the same order for each **iframe** in the [WebView](webview.md) content: 
+ [FrameNavigationStarting](webview_framenavigationstarting.md)
+ [FrameContentLoading](webview_framecontentloading.md)
+ [FrameDOMContentLoaded](webview_framedomcontentloaded.md)
+ FrameNavigationCompleted


## -examples

## -see-also
