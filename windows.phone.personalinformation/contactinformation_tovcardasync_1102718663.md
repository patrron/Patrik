---
-api-id: M:Windows.Phone.PersonalInformation.ContactInformation.ToVcardAsync(Windows.Phone.PersonalInformation.VCardFormat)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IRandomAccessStream> ToVcardAsync(Windows.Phone.PersonalInformation.VCardFormat format)
-->

# Windows.Phone.PersonalInformation.ContactInformation.ToVcardAsync

## -description
Retrieves a vCard representation of the contact using the specified vCard format.

## -parameters
### -param format
The format that the returned vCard will use.

## -returns
When this method completes, it returns a stream containing the vCard data. If you use [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md), which is the data.

## -remarks
*vCard* is a file format standard for electronic business cards.

## -examples

## -see-also
[ToVcardAsync](contactinformation_tovcardasync_1389129276.md), [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]
