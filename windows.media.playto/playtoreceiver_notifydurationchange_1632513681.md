---
-api-id: M:Windows.Media.PlayTo.PlayToReceiver.NotifyDurationChange(Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public void NotifyDurationChange(Windows.Foundation.TimeSpan duration)
-->

# Windows.Media.PlayTo.PlayToReceiver.NotifyDurationChange

## -description
Notifies the Play To receiver that the duration of the audio or video playback has changed.

## -parameters
### -param duration
The new duration of the audio or video media.

## -remarks
For an example of creating a software Play To receiver, see [Media casting](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-casting) or [Media casting](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-casting).



[!code-csharp[NotifyDurationChange](../windows.media.playto/code/PlayTo_Receiver1/csharp/MainPage.xaml.cs#SnippetNotifyDurationChange)]

[!code-js[NotifyDurationChange](../windows.media.playto/code/PlayTo_Receiver1/javascript/default.js#SnippetNotifyDurationChange)]

[!code-vb[NotifyDurationChange](../windows.media.playto/code/PlayTo_Receiver1/vbnet/MainPage.xaml.vb#SnippetNotifyDurationChange)]

## -examples

## -see-also
[Play To sample](https://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](https://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](https://go.microsoft.com/fwlink/p/?linkid=245168)

## -capabilities
privateNetworkClientServer
