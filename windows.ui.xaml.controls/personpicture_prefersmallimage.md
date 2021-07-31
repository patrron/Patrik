---
-api-id: P:Windows.UI.Xaml.Controls.PersonPicture.PreferSmallImage
-api-type: winrt property
---

<!-- Property syntax.
public bool PreferSmallImage { get;  set; }
-->

# Windows.UI.Xaml.Controls.PersonPicture.PreferSmallImage

## -description

Gets or sets a value that indicates whether a small image is displayed rather than a large image when both are available.

## -xaml-syntax

```xaml
<PersonPicture PreferSmallImage="bool"/>
```

## -property-value

**true** to display a small image even when a large image is available; otherwise, **false**. The default is **false**.

## -remarks

If an image is available, the control displays the first image it finds, in this order:

1. LargeDisplayPicture
1. SmallDisplayPicture
1. Thumbnail

You can change which image is chosen by setting the PreferSmallImage property to **true**. This gives the SmallDisplayPicture a higher priority than LargeDisplayPicture.

## -see-also

## -examples

