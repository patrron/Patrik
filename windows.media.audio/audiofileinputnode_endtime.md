---
-api-id: P:Windows.Media.Audio.AudioFileInputNode.EndTime
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.TimeSpan> EndTime { get;  set; }
-->

# Windows.Media.Audio.AudioFileInputNode.EndTime

## -description
Gets or sets the end time for the audio file input node, which determines when playback of the media content ends.

## -property-value
A value indicating the end time.

## -remarks
**EndTime** defines where in the file playback ends. If **EndTime** is **null**, playback will end at the end of the file. **EndTime** can't be set to a time greater than the duration of the file. Attempting to do so will result in an invalid argument error.

Set the point within the media content at which playback starts with the [StartTime](audiofileinputnode_starttime.md) property.

## -examples

## -see-also
