---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.SearchForAllUpdatesAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem>> SearchForAllUpdatesAsync(System.String correlationVector)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.SearchForAllUpdatesAsync

## -description
Searches for all available updates to apps installed on the current computer or device, with the option to generate telemetry data.

## -parameters
### -param correlationVector
A correlation vector string that can be used to generate telemetry data.

## -returns
An asynchronous operation that, on successful completion, returns the collection of apps that have available updates. If you use [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [AppInstallItem](appinstallitem.md) items. (You can use APIs of [IVectorView&lt;AppInstallItem&gt;](../windows.foundation.collections/ivectorview_1.md) for C++ or JavaScript, APIs of [IReadOnlyList&lt;AppInstallItem&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1?redirectedfrom=MSDN) for .NET.)

## -remarks

## -examples

## -see-also
[SearchForAllUpdatesAsync](appinstallmanager_searchforallupdatesasync_1093998542.md)

## -capabilities
runFullTrust
