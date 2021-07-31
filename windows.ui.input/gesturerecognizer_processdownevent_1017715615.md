---
-api-id: M:Windows.UI.Input.GestureRecognizer.ProcessDownEvent(Windows.UI.Input.PointerPoint)
-api-type: winrt method
---

<!-- Method syntax
public void ProcessDownEvent(Windows.UI.Input.PointerPoint value)
-->

# Windows.UI.Input.GestureRecognizer.ProcessDownEvent

## -description
Processes pointer input and raises the [GestureRecognizer](gesturerecognizer.md) events appropriate to a pointer down action for the gestures and manipulations specified by the [GestureSettings](gesturerecognizer_gesturesettings.md) property.




<!--Performs gesture detection and manipulation calculations based on pointer input, and raises various gesture/manipulation events.-->

<!--GestureRecognizer – The ProcessMoveEvents description sounds like it will raise pointer events.  You might want to word it “and raises the various GestureRecognizer events based on the pointer moved events”.  Same thing goes for the other Process* methods.-->

<!--GestureRecognizer.ProcessFoo() -  For all of the process methods, we should say something like, “processes the given input and raises gesture events as appropriate.”  The current wording is a little confusing – we don’t really have “pointer detected events” (on GR at least) or “pointer removed events”.-->



<!--This method is used to send PointerPoint input to the GestureRecognizer.  This is used with the ProcessMoves, ProcessUp and ProcessMouseWheel methods to send input to the GestureRecognizer to be recognized and triggered the various gesture events that have been configured via the GestureSettings flags.-->

## -parameters
### -param value
The input point.

## -remarks

## -examples

## -see-also
[Input and interactions](/windows/uwp/design/input/), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](/samples/browse/), [Input: Ink sample](/samples/browse/), [Input: Manipulations and gestures (JavaScript) sample](/samples/browse/), [Input: Simplified ink  sample](/samples/browse/), [Input: Windows 8 gestures sample](/samples/browse/), [Input: XAML user input events sample](/samples/browse/), [XAML scrolling, panning, and zooming sample](/samples/browse/), [DirectX touch input sample](/samples/browse/), [Input: Manipulations and gestures (C++) sample](/samples/browse/), [Input: Touch hit testing sample](/samples/browse/), [Input source identification sample](/samples/browse/), [Touch injection sample](/samples/browse/), [Win32 touch hit-testing sample](/samples/browse/)