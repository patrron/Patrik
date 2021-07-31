---
-api-id: T:Windows.Graphics.Display.DisplayPropertiesEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void DisplayPropertiesEventHandler(System.Object sender)
-->
# Windows.Graphics.Display.DisplayPropertiesEventHandler

## -description
> [!NOTE]
> The [DisplayProperties](displayproperties.md) type and related event handlers may be altered or unavailable for releases after Windows 8.1. Instead, use [DisplayInformation](displayinformation.md).

Represents a method that handles display property events.

## -parameters
### -param sender
The object that raised the event.

## -remarks
We recommend that applications use a single delegate to handle most display events because in most cases the change to each display property requires that the application redraw itself. Also, many property changes result from a single mode change that affects the entire operating system.

The [Direct3D 11.1 Simple Stereo 3D Sample](https://go.microsoft.com/fwlink/p/?linkid=238402) shows how to handle system stereo changes.

## -examples

```cpp
void GameRenderer::Initialize()
{
    DisplayProperties::StereoEnabledChanged += 
        ref new DisplayPropertiesEventHandler(this, &GameRenderer::OnStereoEnableChanged);
}

void GameRenderer::OnStereoEnableChanged(_In_ Platform::Object^ sender)
{
    UpdateForStereoChange();
}
```

## -see-also