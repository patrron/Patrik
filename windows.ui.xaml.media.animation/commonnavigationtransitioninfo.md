---
-api-id: T:Windows.UI.Xaml.Media.Animation.CommonNavigationTransitionInfo
-api-type: winrt class
---

<!-- Class syntax.
public class CommonNavigationTransitionInfo : Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo, Windows.UI.Xaml.Media.Animation.ICommonNavigationTransitionInfo
-->

# Windows.UI.Xaml.Media.Animation.CommonNavigationTransitionInfo

## -description
Provides common parameters for navigation transition animations.

## -xaml-syntax
```xaml
<NavigationThemeTransition>
  <CommonNavigationTransitionInfo ... />
</NavigationThemeTransition>
```


## -remarks

### XAML attached properties

CommonNavigationTransitionInfo is the host service class for a [XAML attached property](https://docs.microsoft.com/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| IsStaggerElement | Gets or sets a value that indicates whether this element is the stagger element for the navigation transition.<ul><li>Type: Boolean</li><li>Identifier field: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.animation.commonnavigationtransitioninfo.isstaggerelementproperty">IsStaggerElementProperty</a></li><li>Accessor methods: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.animation.commonnavigationtransitioninfo.getisstaggerelement">GetIsStaggerElement</a>, <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.animation.commonnavigationtransitioninfo.setisstaggerelement">SetIsStaggerElement</a></li></ul>

## -examples

## -see-also
[NavigationTransitionInfo](navigationtransitioninfo.md)