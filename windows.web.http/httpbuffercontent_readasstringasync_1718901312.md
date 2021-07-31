---
-api-id: M:Windows.Web.Http.HttpBufferContent.ReadAsStringAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync()
-->

# Windows.Web.Http.HttpBufferContent.ReadAsStringAsync

## -description
Serialize the [HttpBufferContent](httpbuffercontent.md) to a [String](https://docs.microsoft.com/dotnet/api/system.string?redirectedfrom=MSDN) as an asynchronous operation.

## -returns
The object that represents the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(String, UInt64)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after all of the content has been written to the [String](https://docs.microsoft.com/dotnet/api/system.string?redirectedfrom=MSDN).

## -examples

## -see-also
