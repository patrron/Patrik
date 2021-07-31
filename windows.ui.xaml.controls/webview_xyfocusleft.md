---
-api-id: P:Windows.UI.Xaml.Controls.WebView.XYFocusLeft
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyObject XYFocusLeft { get;  set; }
-->

# Windows.UI.Xaml.Controls.WebView.XYFocusLeft

## -description
Gets or sets the object that gets focus when a user presses the Directional Pad (D-pad) left.

## -xaml-syntax
```xaml
<WebView XYFocusLeft="{x:Bind dependencyObjectValue}"/>
```


## -property-value
The object that gets focus when a user presses the Directional Pad (D-pad).

## -remarks
XYFocusLeft is supported only on the Xbox device family, and only when using a game pad or remote control. The property is ignored otherwise.

For more info about this property, see the [XY focus navigation and interaction](https://docs.microsoft.com/windows/uwp/input-and-devices/designing-for-tv) section of the [Designing for Xbox and TV](https://docs.microsoft.com/windows/uwp/input-and-devices/designing-for-tv) article.

### Version compatibility

The XYFocusLeft property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](https://docs.microsoft.com/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you set it.

```csharp

if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.WebView", "XYFocusLeft"))
{
    webView1.XYFocusLeft = button1;
}
```



## -examples

## -see-also
