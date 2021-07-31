---
-api-id: M:Windows.Storage.FileIO.ReadLinesAsync(Windows.Storage.IStorageFile,Windows.Storage.Streams.UnicodeEncoding)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVector<string>> ReadLinesAsync(Windows.Storage.IStorageFile file, Windows.Storage.Streams.UnicodeEncoding encoding)
-->

# Windows.Storage.FileIO.ReadLinesAsync

## -description
Reads the contents of the specified file using the specified character encoding and returns lines of text.

## -parameters
### -param file
The file to read.

### -param encoding
The character encoding to use.

## -returns
When this method completes successfully, it returns the contents of the file as a list (type [IVector](../windows.foundation.collections/ivector_1.md)) of lines of text. Each line of text in the list is represented by a [String](https://docs.microsoft.com/dotnet/api/system.string?redirectedfrom=MSDN) object.

## -remarks

## -examples

## -see-also
[ReadLinesAsync(IStorageFile)](fileio_readlinesasync_209353873.md)