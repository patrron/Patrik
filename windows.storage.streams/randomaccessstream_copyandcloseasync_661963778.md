---
-api-id: M:Windows.Storage.Streams.RandomAccessStream.CopyAndCloseAsync(Windows.Storage.Streams.IInputStream,Windows.Storage.Streams.IOutputStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<ulong, ulong> CopyAndCloseAsync(Windows.Storage.Streams.IInputStream source, Windows.Storage.Streams.IOutputStream destination)
-->

# Windows.Storage.Streams.RandomAccessStream.CopyAndCloseAsync

## -description
Copies a source stream to a destination stream and waits for the copy operation to complete.

## -parameters
### -param source
The stream to copy data from.

### -param destination
The stream to copy data to.

## -returns
The asynchronous operation.

## -remarks
The CopyAndCloseAsync method is similar to [CopyAsync](randomaccessstream_copyasync_1577084715.md) but also calls and waits for [FlushAsync](ioutputstream_flushasync_491532439.md) and [Close](https://docs.microsoft.com/windows/desktop/api/windows.foundation/nf-windows-foundation-iclosable-close) on the output stream before its asynchronous operation completes.

## -examples

## -see-also
