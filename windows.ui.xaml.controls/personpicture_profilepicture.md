---
-api-id: P:Windows.UI.Xaml.Controls.PersonPicture.ProfilePicture
-api-type: winrt property
---

<!-- Property syntax.
public ImageSource ProfilePicture { get;  set; }
-->

# Windows.UI.Xaml.Controls.PersonPicture.ProfilePicture

## -description

Gets or sets the source of the contact's profile picture.

## -xaml-syntax

```xaml
<PersonPicture ProfilePicture="uri"/>
```

## -xaml-values

<dl><dt>uri</dt><dd>uriThe location of the image source file. In XAML syntax, you can specify what appears to be a relative that is relative to a base . The base is interpreted based on the location of the XAML file that loads it, and uses the ms-appx: scheme implicitly. For more info see Image.Source.</dd>
</dl>

## -property-value

An object that represents the image source file for the drawn image. Typically you set this with a [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a [BitmapSource](../windows.ui.xaml.media.imaging/bitmapsource.md) with a stream, perhaps a stream from a storage file.

## -remarks

## -see-also

## -examples

