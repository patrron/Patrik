---
-api-id: M:Windows.Media.Playback.MediaPlayer.RenderSubtitlesToSurface(Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax.
public bool MediaPlayer.RenderSubtitlesToSurface(IDirect3DSurface destination, Rect targetRectangle)
-->

# Windows.Media.Playback.MediaPlayer.RenderSubtitlesToSurface

## -description
Requests for the system to render the current subtitle text to the specified target rectangle within the provided [IDirect3DSurface](https://docs.microsoft.com/uwp/api/Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface).

## -parameters
### -param destination
The object that implements **IDirect3DSurface**  to which the subtitle text is rendered.

### -param targetRectangle
The rectangle within the provided surface within which the subtitles are rendered.

## -returns
True if the system rendered subtitles to the surface; otherwise false.

## -remarks
Note that this method is less efficient than the other overload of **RenderSubtitleToSurface**, but it allows you to use the same surface for rendering video and subtitles rather than requiring a separate surface for subtitles.

Handle the [SubtitleFrameChanged](https://docs.microsoft.com/uwp/api/windows.media.playback.mediaplayer.SubtitleFrameChanged) event to receive a notification that the subtitle content has changed. Check the return value to see if subtitles were rendered.

In order to use this feature, you must place the [MediaPlayer](https://docs.microsoft.com/uwp/api/windows.media.playback.mediaplayer) into frame server mode by setting [IsVideoFrameServerEnabled](https://docs.microsoft.com/uwp/api/windows.media.playback.mediaplayer.IsVideoFrameServerEnabled) to **true**, and the playing media content must have at least one timed metadata track that has had its presentation mode set to [PlatformPresented](https://docs.microsoft.com/uwp/api/windows.media.playback.timedmetadatatrackpresentationmode) with a call to [Media​Playback​Timed​Metadata​Track​List.SetPresentationMode](https://docs.microsoft.com/uwp/api/windows.media.playback.mediaplaybacktimedmetadatatracklist#Windows_Media_Playback_MediaPlaybackTimedMetadataTrackList_SetPresentationMode_System_UInt32_Windows_Media_Playback_TimedMetadataTrackPresentationMode_). For more information on using MediaPlayer in frame server mode, see [Play audio and video with MediaPlayer](https://docs.microsoft.com/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer). For more information on working with metadata tracks, see [Media items, playlists, and tracks](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -see-also
[IDirect3DSurface](https://docs.microsoft.com/uwp/api/Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface)
[MediaPlayer](https://docs.microsoft.com/uwp/api/windows.media.playback.mediaplayer)
[SubtitleFrameChanged](https://docs.microsoft.com/uwp/api/windows.media.playback.mediaplayer.SubtitleFrameChanged)
[Play audio and video with MediaPlayer](https://docs.microsoft.com/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer)
[Media items, playlists, and tracks](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-playback-with-mediasource)

## -examples

