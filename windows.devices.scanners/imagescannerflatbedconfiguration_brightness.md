---
-api-id: P:Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.Brightness
-api-type: winrt property
---

<!-- Property syntax
public int Brightness { get;  set; }
-->

# Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.Brightness

## -description
Gets or sets the current brightness level for capturing image data from the scanner's Flatbed. At the beginning of a new scan session, this property is set to the [DefaultBrightness](imagescannerflatbedconfiguration_defaultbrightness.md) property.

## -property-value
The current brightness level.

## -remarks
Your app can set the value of this property to any [Int32](https://docs.microsoft.com/dotnet/api/system.int32?redirectedfrom=MSDN) value between the [MinBrightness](imagescannerflatbedconfiguration_minbrightness.md) and [MaxBrightness](imagescannerflatbedconfiguration_maxbrightness.md) values, and also relates to the [BrightnessStep](imagescannerflatbedconfiguration_brightnessstep.md) value with this equation:

**Brightness = MinBrightness + (N * BrightnessStep)**

where N is a positive integer smaller than or equal to **(MaxBrightness - MinBrightness) / BrightnessStep**.

The app can return the brightness level to default by setting the value of this property to [DefaultBrightness](imagescannerflatbedconfiguration_defaultbrightness.md).

If the scanner doesn't allow brightness adjustments, **MinBrightness**, **MaxBrightness** and **DefaultBrightness** are set to the same value-oftentimes 0, the **BrightnessStep** value is 0, and the app can't set the **Brightness** property to a value other than **DefaultBrightness**.

## -examples

## -see-also
