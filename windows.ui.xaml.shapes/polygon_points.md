---
-api-id: P:Windows.UI.Xaml.Shapes.Polygon.Points
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.PointCollection Points { get;  set; }
-->

# Windows.UI.Xaml.Shapes.Polygon.Points

## -description
Gets or sets a collection that contains the vertex points of the polygon.

Equivalent WinUI property: [Microsoft.UI.Xaml.Shapes.Polygon.Points](/windows/winui/api/microsoft.ui.xaml.shapes.polygon.points).

## -xaml-syntax
```xaml
<Polygon Points="pointSet"/>
```


## -xaml-values
<dl><dt>pointSet</dt><dd>pointSetOne or more Point values with each x-y pair delimited by a single comma and/or one or more spaces. Either a space or a comma can be the delimiter and they can be used interchangeably. For example, "0,0 100,100", "0,0,100,100" and "0 0 100 100" are all valid and equivalent. The usual convention is to use a comma between the x and y of a point, and spaces between the x,y pairs.</dd>
</dl>
## -property-value
A collection of [Point](../windows.foundation/point.md) structures that describes the vertex points of the polygon. The default is null. The value can be expressed as a string for XAML or type conversion.

## -remarks

## -examples

## -see-also
