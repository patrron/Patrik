---
-api-id: T:Windows.Media.MediaTimelineController
-api-type: winrt class
---

<!-- Class syntax.
public class MediaTimelineController : Windows.Media.IMediaTimelineController, Windows.Media.IMediaTimelineController2
-->

# Windows.Media.MediaTimelineController

## -description

Provides information about and control over the rate, position, and state of a [MediaPlayer](../windows.media.playback/mediaplayer.md). This class makes it possible to control and synchronize multiple media players from a single controller and makes it easier to create custom transport controls.

## -remarks

Get an instance of this class using the constructor or by accessing the [TimelineController](../windows.media.playback/mediaplayer_timelinecontroller.md) property of a [MediaPlayer](../windows.media.playback/mediaplayer.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Duration |
| 1703 | 15063 | Ended |
| 1703 | 15063 | Failed |
| 1703 | 15063 | IsLoopingEnabled |

## -examples

## -see-also

[Video playback synchronization sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/VideoPlaybackSynchronization)
