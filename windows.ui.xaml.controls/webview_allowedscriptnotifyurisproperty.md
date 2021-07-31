---
-api-id: P:Windows.UI.Xaml.Controls.WebView.AllowedScriptNotifyUrisProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty AllowedScriptNotifyUrisProperty { get; }
-->

# Windows.UI.Xaml.Controls.WebView.AllowedScriptNotifyUrisProperty

## -description
> [!NOTE]
> AllowedScriptNotifyUrisProperty is not supported in apps compiled for Windows 8.1. Instead, update the **ApplicationContentUriRules** section of the app manifest. For more info, see the Remarks section.

Identifies the [AllowedScriptNotifyUris](webview_allowedscriptnotifyuris.md) dependency property.

## -property-value
The identifier for the [AllowedScriptNotifyUris](webview_allowedscriptnotifyuris.md) dependency property.

## -remarks
### Windows 8.1

AllowedScriptNotifyUrisProperty is not supported in apps compiled for Windows 8.1. To enable an external web page to fire the [ScriptNotify](webview_scriptnotify.md) event when calling **window.external.notify**, you must include the page's URI in the **ApplicationContentUriRules** section of the app manifest. (You can do this in Visual Studio on the Content URIs tab of the **Package.appxmanifest** designer.) The URIs in this list must use HTTPS, and may contain subdomain wildcards (for example, https://*.microsoft.com) but they cannot contain domain wildcards (for example, https://*.com and https://*.*). The manifest requirement does not apply to content that originates from the app package, uses an ms-local-stream:// URI, or is loaded using [NavigateToString](webview_navigatetostring_1924125949.md).

### Windows 8

These remarks apply only to apps compiled for Windows 8, even when running on Windows 8.1.

To enable an external web page to fire the [ScriptNotify](webview_scriptnotify.md) event when calling **window.external.notify**, you must include the page's URI in the list returned by the [AllowedScriptNotifyUris](webview_allowedscriptnotifyuris.md) property. Set this property to [AnyScriptNotifyUri](webview_anyscriptnotifyuri.md) to indicate that any page can fire [ScriptNotify](webview_scriptnotify.md) events for this [WebView](webview.md) control. This requirement does not apply to content loaded using the [NavigateToString](webview_navigatetostring_1924125949.md) method.

## -examples

## -see-also
