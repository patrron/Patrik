---
-api-id: M:Windows.ApplicationModel.Wallet.WalletItemStore.GetItemsAsync(Windows.ApplicationModel.Wallet.WalletItemKind)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Wallet.WalletItem>> GetItemsAsync(Windows.ApplicationModel.Wallet.WalletItemKind kind)
-->

# Windows.ApplicationModel.Wallet.WalletItemStore.GetItemsAsync

## -description
Returns the collection of wallet items of the given type that are owned by this app.

## -parameters
### -param kind
The type of wallet item to retrieve.

## -returns
An asynchronous operation that, on successful completion, returns the collection of wallet items of the specified type that are accessible by this app. If you use [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [WalletItem](walletitem.md) items. (You can use APIs of [IVectorView&lt;WalletItem&gt;](../windows.foundation.collections/ivectorview_1.md) for C++ or JavaScript, APIs of [IReadOnlyList<WalletItem>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1) for .NET.)

## -remarks

## -examples

## -see-also
[GetItemsAsync()](walletitemstore_getitemsasync_1518547059.md), [WalletItem](walletitem.md), GetItemsAsync(WalletItemKind), [IVectorView&lt;T&gt;](../windows.foundation.collections/ivectorview_1.md), [IReadOnlyList<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1), [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)
