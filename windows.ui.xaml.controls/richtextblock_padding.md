---
-api-id: P:Windows.UI.Xaml.Controls.RichTextBlock.Padding
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness Padding { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichTextBlock.Padding

## -description
Gets or sets a value that indicates the thickness of padding space between the boundaries of the content area and the content displayed by a [RichTextBlock](richtextblock.md).

## -xaml-syntax
```xaml
<RichTextBlock Padding="uniform"/>
- or -
<RichTextBlock Padding="left&Right,top&Bottom"/>
- or -
<RichTextBlock Padding="left,top,right,bottom"/>
```


## -xaml-values
<dl><dt>uniform</dt><dd>uniform A value that specifies a uniform Thickness. The uniform value is applied to all four Thickness member values (Left, Top, Right, Bottom).</dd>
<dt>left&amp;Right</dt><dd>left&amp;Right A value that specifies the Left and Right of a symmetrical Thickness.</dd>
<dt>top&amp;Bottom</dt><dd>top&amp;Bottom A value that specifies the Top and Bottom of a symmetrical Thickness.</dd>
<dt>left right top bottom</dt><dd>left right top bottom Values that specify the four possible dimension properties of a Thickness structure (Left, Top, Right, Bottom).</dd>
</dl>
## -property-value
A [Thickness](../windows.ui.xaml/thickness.md) structure that specifies the amount of padding to apply.

## -remarks
A related property is [Margin](../windows.ui.xaml/frameworkelement_margin.md) (a property of [FrameworkElement](../windows.ui.xaml/frameworkelement.md)). For more info about the relationship between margin and padding, see [Alignment, margin, and padding](https://docs.microsoft.com/windows/uwp/layout/alignment-margin-padding) or [Define layouts with XAML](https://docs.microsoft.com/windows/uwp/layout/layouts-with-xaml).

## -examples

## -see-also
[Thickness](../windows.ui.xaml/thickness.md), [RichTextBlockOverflow.Padding](richtextblockoverflow_padding.md), [Alignment, margin, and padding](https://docs.microsoft.com/windows/uwp/layout/alignment-margin-padding)
