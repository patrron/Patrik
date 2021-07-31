---
-api-id: P:Windows.Foundation.IAsyncInfo.ErrorCode
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.HResult ErrorCode { get; }
-->

# Windows.Foundation.IAsyncInfo.ErrorCode

## -description
Gets a string that describes an error condition of the asynchronous operation.

## -property-value
The error string.

## -remarks
Error codes are exposed as different types depending on the programming language you are using. Similarly, each language has different techniques for wrapping asynchronous method calls so that error conditions or cancellation can be handled. For more info see one of these topics:
+ [Exception handling for  in C# or Visual Basic](https://docs.microsoft.com/previous-versions/windows/apps/dn532194(v=win.10))
+ [Exceptions (C++/CX)](https://docs.microsoft.com/cpp/cppcx/exceptions-c-cx)
+ [JavaScript Run-time Errors](https://docs.microsoft.com/scripting/javascript/reference/javascript-run-time-errors)


## -examples

## -see-also
[HResult](hresult.md), [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)
