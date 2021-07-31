---
-api-id: M:Windows.Media.PlayTo.PlayToReceiver.NotifyVolumeChange(System.Double,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void NotifyVolumeChange(System.Double volume, System.Boolean mute)
-->

# Windows.Media.PlayTo.PlayToReceiver.NotifyVolumeChange

## -description
Notifies the Play To receiver that the volume of the audio or video playback has changed.

## -parameters
### -param volume
The new value for the volume.

### -param mute
True if the volume was muted; otherwise false.

## -remarks
For an example of creating a software Play To receiver, see [Media casting](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-casting) or [Media casting](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-casting).



[!code-csharp[NotifyVolumeChanged](../windows.media.playto/code/PlayTo_Receiver1/csharp/MainPage.xaml.cs#SnippetNotifyVolumeChanged)]

[!code-js[NotifyVolumeChanged](../windows.media.playto/code/PlayTo_Receiver1/javascript/default.js#SnippetNotifyVolumeChanged)]

[!code-vb[NotifyVolumeChanged](../windows.media.playto/code/PlayTo_Receiver1/vbnet/MainPage.xaml.vb#SnippetNotifyVolumeChanged)]

## -examples

## -see-also
[Play To sample](https://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](https://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](https://go.microsoft.com/fwlink/p/?linkid=245168)

## -capabilities
privateNetworkClientServer
