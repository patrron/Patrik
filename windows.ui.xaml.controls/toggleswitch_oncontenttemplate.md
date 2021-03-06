---
-api-id: P:Windows.UI.Xaml.Controls.ToggleSwitch.OnContentTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate OnContentTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.ToggleSwitch.OnContentTemplate

## -description
Gets or sets the [DataTemplate](../windows.ui.xaml/datatemplate.md) used to display the control's content while in "On" state.

Equivalent WinUI property: [Microsoft.UI.Xaml.Controls.ToggleSwitch.OnContentTemplate](/windows/winui/api/microsoft.ui.xaml.controls.toggleswitch.oncontenttemplate).

## -xaml-syntax
```xaml
<ToggleSwitch>
  <ToggleSwitch.OnContentTemplate>
    singleDataTemplate
  </ToggleSwitch.OnContentTemplate>
</ToggleSwitch>
- or -
<ToggleSwitchÂ OnContentTemplate="resourceReferenceToDataTemplate"/>
```


## -xaml-values
<dl><dt>singleDataTemplate</dt><dd>singleDataTemplateA single DataTemplate object element. That DataTemplate would typically have multiple child elements that define the visual appearance of the data representation.</dd>
<dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key.</dd>
</dl>
## -property-value
The [DataTemplate](../windows.ui.xaml/datatemplate.md) that displays the control's content while in "On" state.

## -remarks

## -examples

## -see-also
