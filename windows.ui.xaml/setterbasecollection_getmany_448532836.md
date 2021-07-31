---
-api-id: M:Windows.UI.Xaml.SetterBaseCollection.GetMany(System.UInt32,Windows.UI.Xaml.SetterBase[])
-api-type: winrt method
---

<!-- Method syntax
public uint GetMany(System.UInt32 startIndex, Windows.UI.Xaml.SetterBase[] items)
-->

# Windows.UI.Xaml.SetterBaseCollection.GetMany

## -description
Retrieves multiple elements in a single pass through the iterator.

Equivalent WinUI method: [Microsoft.UI.Xaml.SetterBaseCollection.GetMany](/windows/winui/api/microsoft.ui.xaml.setterbasecollection.getmany).

## -parameters
### -param startIndex
The index from which to start retrieval.

### -param items
Provides the destination for the result. Size the initial array size as a *capacity* in order to specify how many results should be retrieved.

## -returns
The number of items returned.

## -remarks
> [!NOTE]
> The equivalent Microsoft .NET  API is [CopyTo](setterbasecollection_copyto.md).

## -examples

## -see-also
[CopyTo](setterbasecollection_copyto.md)
