---
-api-id: M:Windows.Storage.KnownFolders.GetFolderForUserAsync(Windows.System.User,Windows.Storage.KnownFolderId)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> GetFolderForUserAsync(Windows.System.User user, Windows.Storage.KnownFolderId folderId)
-->

# Windows.Storage.KnownFolders.GetFolderForUserAsync

## -description
Static method that returns a specified known folder for a [User](../windows.system/user.md).

## -parameters
### -param user
The [User](../windows.system/user.md) for which the folder is returned. Use `null` for the current user. In context of this API, current user refers to the user context of the process from where the API call is made.

### -param folderId
The ID of the folder to be returned.

## -returns
When this method completes, it returns the requested [StorageFolder](storagefolder.md) object.

## -remarks

## -examples

## -see-also
[KnownFolderId](knownfolderid.md), [StorageFolder](storagefolder.md)
