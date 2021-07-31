---
-api-id: P:Windows.Storage.ApplicationData.RoamingStorageQuota
-api-type: winrt property
---

<!-- Property syntax
public ulong RoamingStorageQuota { get; }
-->

# Windows.Storage.ApplicationData.RoamingStorageQuota

## -description
Gets the maximum size of the data that can be synchronized to the cloud from the roaming app data store.

## -property-value
The maximum size of the data, in KB.

## -remarks
If the current size of the roaming data in the roaming app data store exceeds the maximum size specified by RoamingStorageQuota, the system suspends data replication for all apps in the package to the cloud until the current size no longer exceeds the maximum size.

## -examples

## -see-also
