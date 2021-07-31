---
-api-id: P:Windows.Storage.ApplicationData.RoamingFolder
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.StorageFolder RoamingFolder { get; }
-->

# Windows.Storage.ApplicationData.RoamingFolder

## -description
Gets the root folder in the roaming app data store.

## -property-value
The file system folder that contains the files.

## -remarks
The sync engine has restrictions on the file name conventions that you must follow to ensure the items in the roaming folder can roam. Be sure that your file and folder names do not contain leading whitespace. The sync engine may limit the total size of settings and files that can roam.

You can access files in the roaming app data store using the "ms-appdata:///roaming/" protocol. For example:

`<img src="ms-appdata:///roaming/myFile.png" alt="" />`

## -examples

## -see-also
[Quickstart: Roaming application data (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/hh465123(v=win.10)), [Store and retrieve settings and other app data](https://docs.microsoft.com/windows/uwp/app-settings/store-and-retrieve-app-data), [Store and retrieve settings and other app data](https://docs.microsoft.com/windows/uwp/app-settings/store-and-retrieve-app-data)
