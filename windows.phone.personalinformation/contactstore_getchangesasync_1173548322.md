---
-api-id: M:Windows.Phone.PersonalInformation.ContactStore.GetChangesAsync(System.UInt64)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Phone.PersonalInformation.ContactChangeRecord>> GetChangesAsync(System.UInt64 baseRevisionNumber)
-->

# Windows.Phone.PersonalInformation.ContactStore.GetChangesAsync

## -description
Gets the list of changes to the contact store associated with the provided revision number.

## -parameters
### -param baseRevisionNumber
The revision number for which changes should be retrieved.

## -returns
When this method completes, it returns a [VectorView](https://docs.microsoft.com/previous-versions/br224594(v=vs.85)) containing a [ContactChangeRecord](contactchangerecord.md) object for each change associated with the revision number. If you use [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [ContactChangeRecord](contactchangerecord.md) items. (You can use APIs of [IVectorView&lt;ContactChangeRecord&gt;](../windows.foundation.collections/ivectorview_1.md) for C++, APIs of [IReadOnlyList<ContactChangeRecord>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1) for .NET.)

## -remarks

## -examples

## -see-also
[ContactChangeRecord](contactchangerecord.md), [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]
