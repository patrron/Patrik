---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.StartProductInstallAsync(System.String,System.String,System.String,System.String,System.Boolean,System.Boolean,System.String,Windows.Management.Deployment.PackageVolume)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem>> StartProductInstallAsync(System.String productId, System.String catalogId, System.String flightId, System.String clientId, System.Boolean repair, System.Boolean forceUseOfNonRemovableStorage, System.String correlationVector, Windows.Management.Deployment.PackageVolume targetVolume)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.StartProductInstallAsync

## -description
Starts the installation of the specified app or app bundle.

## -parameters
### -param productId
The product ID of the app to install.

### -param catalogId
The catalog ID of the app to install.

### -param flightId
The flight ID of the app to install.

### -param clientId
The ID of the caller.

### -param repair
True to attempt to repair the installation of an app that is already installed; otherwise, false.

### -param forceUseOfNonRemovableStorage
True to install the app to non-removable storage even if the user has configured apps to install to SD card; false to install the app to non-removable storage or SD card according to the user's settings.

### -param correlationVector
A correlation vector string that can be used to generate telemetry data.

### -param targetVolume
The package storage volume where the app or app bundle will be installed.

## -returns
An asynchronous operation that, on successful completion, returns the app or set of apps (for an app bundle) that were added to the installation queue. If you use [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [AppInstallItem](appinstallitem.md) items. (You can use APIs of [IVectorView&lt;AppInstallItem&gt;](../windows.foundation.collections/ivectorview_1.md) for C++ or JavaScript, APIs of [IReadOnlyList&lt;AppInstallItem&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1?redirectedfrom=MSDN) for .NET.)

## -remarks

## -examples

## -see-also

## -capabilities
runFullTrust
