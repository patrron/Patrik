---
-api-id: P:Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.MinBrightness
-api-type: winrt property
---

<!-- Property syntax
public int MinBrightness { get; }
-->

# Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.MinBrightness

## -description
Gets the minimum brightness level supported by the scanner's Flatbed.

## -property-value
The minimum brightness level, typically -1000.

## -remarks
This property's value must be smaller than or equal to the value of the [MaxBrightness](imagescannerflatbedconfiguration_maxbrightness.md) property. A scan source that doesn't allow brightness adjustments can have **MinBrightness**, **MaxBrightness** and [DefaultBrightness](imagescannerflatbedconfiguration_defaultbrightness.md) set to the same value-oftentimes 0, and the [BrightnessStep](imagescannerflatbedconfiguration_brightnessstep.md) value set to 0.

## -examples

## -see-also
