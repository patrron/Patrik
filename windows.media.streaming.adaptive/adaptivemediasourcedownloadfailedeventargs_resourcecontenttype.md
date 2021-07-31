---
-api-id: P:Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadFailedEventArgs.ResourceContentType
-api-type: winrt property
---

<!-- Property syntax.
public string ResourceContentType { get; }
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadFailedEventArgs.ResourceContentType

## -description
Gets a string representing the content type associated with the event.

## -property-value
The content type associated with the event.

## -remarks
This value is optional. The property will be set if the value is found in the DASH manifest. For content with a [ResourceType](adaptivemediasourcedownloadfailedeventargs_resourcetype.md) of **MediaSegment**, the property value is set using the DASH manifest’s *AdaptationSet@mimeType* attribute. 

## -see-also

## -examples

