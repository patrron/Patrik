---
-api-id: M:Windows.UI.Input.Inking.InkManager.SetDefaultDrawingAttributes(Windows.UI.Input.Inking.InkDrawingAttributes)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetDefaultDrawingAttributes(Windows.UI.Input.Inking.InkDrawingAttributes drawingAttributes)
-->

# Windows.UI.Input.Inking.InkManager.SetDefaultDrawingAttributes

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Sets the default [InkDrawingAttributes](inkdrawingattributes.md) for all new [InkStroke](inkstroke.md) objects added to the [InkStroke](inkstroke.md) collection managed by the [InkManager](inkmanager.md).

SetDefaultDrawingAttributes does not affect the current stroke, or any existing strokes.

## -parameters
### -param drawingAttributes
The default attributes applied to a new ink stroke.

## -remarks

## -examples

## -see-also

[Pen and stylus interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

