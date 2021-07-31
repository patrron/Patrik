---
-api-id: P:Windows.Phone.UI.Core.ICoreWindowKeyboardInput.IsKeyboardInputEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsKeyboardInputEnabled { get;  set; }
-->

# Windows.Phone.UI.Core.ICoreWindowKeyboardInput.IsKeyboardInputEnabled

## -description
> [!NOTE]
> **IsKeyboardInputEnabled** may be altered or unavailable for releases after Windows Phone 8.1 GDR2.

Gets or sets whether the touch keyboard is displayed to the user for text input.

## -property-value
True if touch keyboard is enabled. Otherwise, false.

## -remarks
If all of the following conditions occur, the value of the **IsKeyboardInputEnabled** property might not be accurate:

+ 1. You use the default buffer. (For example, you do not provide your own [KeyboardInputBuffer](keyboardinputbuffer.md).)
+ 2. You programmatically open the touch keyboard by setting **IsKeyboardInputEnabled** to true.
+ 3. The user presses the back button, which closes the touch keyboard.
+ 4. You read **IsKeyboardInputEnabled** and expect the value to be false (since the touch keyboard was closed), but the value is true.
There are multiple workarounds for this scenario:

+ Do not use the default buffer.
+ Do not use **IsKeyboardInputEnabled**.
+ Listen to the [Hiding](../windows.ui.viewmanagement/inputpane_hiding.md) event and set **IsKeyboardInputEnabled** to false.
+ Use the [OccludedRect](../windows.ui.viewmanagement/inputpane_occludedrect.md) property to see if the touch keyboard is open.

## -examples

## -see-also
