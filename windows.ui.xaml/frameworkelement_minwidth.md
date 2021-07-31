---
-api-id: P:Windows.UI.Xaml.FrameworkElement.MinWidth
-api-type: winrt property
---

<!-- Property syntax
public double MinWidth { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.MinWidth

## -description
Gets or sets the minimum width constraint of a [FrameworkElement](frameworkelement.md).

## -xaml-syntax
```xaml
<frameworkElement MinWidth="double"/>
```


## -property-value
The minimum width of the object, in pixels. The default is 0. This value can be any value equal to or greater than 0. However, [PositiveInfinity](https://msdn.microsoft.com/library/system.double.positiveinfinity.aspx) is not valid.

## -remarks
[MinWidth](frameworkelement_minwidth.md) is one of three writable properties on [FrameworkElement](frameworkelement.md) that specify width information. The other two are [MaxWidth](frameworkelement_maxwidth.md) and [Width](frameworkelement_width.md). If there is a conflict between these values, the order of application for actual width determination is that first [MinWidth](frameworkelement_minwidth.md) must be honored, then [MaxWidth](frameworkelement_maxwidth.md), and finally, if it is within bounds, [Width](frameworkelement_width.md). All of these properties are recommendations to the layout behavior of the element's parent in the object tree. The width of the object after layout runs is available as the [ActualWidth](frameworkelement_actualwidth.md) property value.

## -examples

## -see-also
[MaxWidth](frameworkelement_maxwidth.md), [Width](frameworkelement_width.md), [HorizontalAlignment](frameworkelement_horizontalalignment.md), [Define layouts with XAML](https://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079)
