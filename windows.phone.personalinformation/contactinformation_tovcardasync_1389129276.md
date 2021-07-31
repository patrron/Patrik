---
-api-id: M:Windows.Phone.PersonalInformation.ContactInformation.ToVcardAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IRandomAccessStream> ToVcardAsync()
-->

# Windows.Phone.PersonalInformation.ContactInformation.ToVcardAsync

## -description
Retrieves a vCard representation of the contact using the vCard version 3.0 format.

## -returns
When this method completes, it returns a stream containing the vCard data. If you use [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md), which is the data.

## -remarks
*vCard* is a file format standard for electronic business cards.

## -examples

## -see-also
[ToVcardAsync(VCardFormat)](contactinformation_tovcardasync_1102718663.md), [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]
