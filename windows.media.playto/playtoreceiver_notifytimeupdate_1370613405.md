---
-api-id: M:Windows.Media.PlayTo.PlayToReceiver.NotifyTimeUpdate(Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public void NotifyTimeUpdate(Windows.Foundation.TimeSpan currentTime)
-->

# Windows.Media.PlayTo.PlayToReceiver.NotifyTimeUpdate

## -description
Notifies the Play To receiver that the time location of the audio or video playback has changed.

## -parameters
### -param currentTime
The new time location of the playback.

## -remarks
For an example of creating a software Play To receiver, see [Media casting](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-casting) or [Media casting](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-casting).



[!code-csharp[TimeUpdateRequested](../windows.media.playto/code/PlayTo_Receiver1/csharp/MainPage.xaml.cs#SnippetTimeUpdateRequested)]

[!code-js[TimeUpdateRequested](../windows.media.playto/code/PlayTo_Receiver1/javascript/default.js#SnippetTimeUpdateRequested)]

[!code-vb[TimeUpdateRequested](../windows.media.playto/code/PlayTo_Receiver1/vbnet/MainPage.xaml.vb#SnippetTimeUpdateRequested)]

## -examples

## -see-also
[Play To sample](https://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](https://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](https://go.microsoft.com/fwlink/p/?linkid=245168)

## -capabilities
privateNetworkClientServer
