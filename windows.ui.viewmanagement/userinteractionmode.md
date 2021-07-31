---
-api-id: T:Windows.UI.ViewManagement.UserInteractionMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.ViewManagement.UserInteractionMode : int
-->

# UserInteractionMode

## -description
Specifies the UI view, optimized for input device type.

## -enum-fields
### -field Mouse:0
The device UI is optimized for mouse input.

### -field Touch:1
The device UI is optimized for touch input.


## -remarks
Some devices (PC, laptop, tablet) support both a Desktop (mouse-optimized) and a Tablet (touch-optimized) mode.

Users can switch between running in Tablet mode and Desktop mode by going to **Settings &gt; System &gt; Tablet mode** and setting **Make Windows more touch-friendly when using your device as a tablet**.

## -examples

## -see-also
[Windows.UI.ViewManagement](windows_ui_viewmanagement.md), [UserInteractionMode](uiviewsettings_userinteractionmode.md)