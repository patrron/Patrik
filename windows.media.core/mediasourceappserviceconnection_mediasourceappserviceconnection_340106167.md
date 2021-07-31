---
-api-id: M:Windows.Media.Core.MediaSourceAppServiceConnection.#ctor(Windows.ApplicationModel.AppService.AppServiceConnection)
-api-type: winrt method
---

<!-- Method syntax.
public MediaSourceAppServiceConnection.MediaSourceAppServiceConnection(AppServiceConnection appServiceConnection)
-->

# Windows.Media.Core.MediaSourceAppServiceConnection.MediaSourceAppServiceConnection

## -description
Initializes a new instance of the **MediaSourceAppServiceConnection** class.

## -parameters
### -param appServiceConnection
An [AppServiceConnection](https://docs.microsoft.com/uwp/api/windows.applicationmodel.appservice.appserviceconnection) object representing the connection to the endpoint for an app service.

## -remarks
Get an instance of the **AppServiceConnection** class by casting the [TriggerDetails](https://docs.microsoft.com/uwp/api/windows.applicationmodel.background.ibackgroundtaskinstance.TriggerDetails) property of the [IBackgroundTaskInstance](https://docs.microsoft.com/uwp/api/windows.applicationmodel.background.ibackgroundtaskinstance) object passed into the background task's [Run](https://docs.microsoft.com/uwp/api/Windows.ApplicationModel.Background.IBackgroundTask#Windows_ApplicationModel_Background_IBackgroundTask_Run_Windows_ApplicationModel_Background_IBackgroundTaskInstance_) method to an [AppServiceTriggerDetails](https://docs.microsoft.com/uwp/api/windows.applicationmodel.appservice.appservicetriggerdetails) object and then accessing the [AppServiceConnection](https://docs.microsoft.com/uwp/api/windows.applicationmodel.appservice.appservicetriggerdetails.AppServiceConnection) property. 

## -see-also

## -examples

