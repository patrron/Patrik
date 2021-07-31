---
-api-id: P:Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter.SelectedForeground
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush SelectedForeground { get;  set; }
-->

# Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter.SelectedForeground

## -description
Gets or sets the brush used to render the foreground of an item that's selected.

## -xaml-syntax
```xaml
<ListViewItemPresenter SelectedForeground="themeResourceReference"/>

```


## -xaml-values
<dl><dt>themeResourceReference</dt><dd>themeResourceReferenceA ThemeResource markup extension reference to an existing keyed resource that defines a Brush-type resource in a XAML resource dictionary. For example, to reference a resource with the key ListViewItemSelectedForegroundThemeBrush, the string is {ThemeResource ListViewItemSelectedForegroundThemeBrush}.</dd>
</dl>
## -property-value
The brush used to render the foreground of an item that's selected.

## -remarks
### Notes on XAML syntax

The XAML usage shown is for referencing a theme resource. This is how [Brush](../windows.ui.xaml.media/brush.md) values for a presenter are typically defined, so that the values can be changed when the theme changes, and potentially so that [Brush](../windows.ui.xaml.media/brush.md) values can be shared by different templates. It's possible but less common to use a XAML syntax that refers to a [Brush](../windows.ui.xaml.media/brush.md) value directly. For examples of direct XAML usages for a [Brush](../windows.ui.xaml.media/brush.md), see the XAML section in the [Brush](../windows.ui.xaml.media/brush.md) class topic.

If you're setting this property as an attribute on a custom [ListViewItemPresenter](listviewitempresenter.md) , substitute the prefixed name of your custom class in the XAML usage shown.

## -examples

## -see-also
[XAML theme resources](https://docs.microsoft.com/windows/uwp/controls-and-patterns/xaml-theme-resources)
