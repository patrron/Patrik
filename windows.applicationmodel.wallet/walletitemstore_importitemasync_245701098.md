---
-api-id: M:Windows.ApplicationModel.Wallet.WalletItemStore.ImportItemAsync(Windows.Storage.Streams.IRandomAccessStreamReference)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Wallet.WalletItem> ImportItemAsync(Windows.Storage.Streams.IRandomAccessStreamReference stream)
-->

# Windows.ApplicationModel.Wallet.WalletItemStore.ImportItemAsync

## -description
Imports data from a ".mswallet" XML file into the wallet store.".mswallet" is an XML serialization format for wallet item info. For a guide to the ".mswallet" format (and a link to schema in XSD), see [Quickstart: Creating and distributing .mswallet files](https://docs.microsoft.com/previous-versions/windows/apps/dn631256(v=win.10)).

## -parameters
### -param stream
The ".mswallet" file to import.

## -returns
An asynchronous operation that, on successful completion, returns the wallet item that was imported into the wallet. If you use [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type on successful completion is a single [WalletItem](walletitem.md).

## -remarks

## -examples

## -see-also
[Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), [Quickstart: Creating and distributing .mswallet files](https://docs.microsoft.com/previous-versions/windows/apps/dn631256(v=win.10)), [Quickstart: Using the   APIs](https://docs.microsoft.com/previous-versions/windows/apps/dn631257(v=win.10))
