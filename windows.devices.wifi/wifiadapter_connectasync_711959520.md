---
-api-id: M:Windows.Devices.WiFi.WiFiAdapter.ConnectAsync(Windows.Devices.WiFi.WiFiAvailableNetwork,Windows.Devices.WiFi.WiFiReconnectionKind,Windows.Security.Credentials.PasswordCredential,System.String,Windows.Devices.WiFi.WiFiConnectionMethod)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<WiFiConnectionResult> WiFiAdapter.ConnectAsync(WiFiAvailableNetwork availableNetwork, WiFiReconnectionKind reconnectionKind, PasswordCredential passwordCredential, String ssid, WiFiConnectionMethod connectionMethod)
-->

# Windows.Devices.WiFi.WiFiAdapter.ConnectAsync

## -description
Connect this Wi-Fi device to a hidden network, with the given passphrase, connection method, and reconnection policy.
## -parameters
### -param availableNetwork
Specifies the Wi-Fi network to connect to.
### -param reconnectionKind
Specifies how to reconnect if the connection is lost.
### -param passwordCredential
The passphrase to be used to connect to the access point.
### -param ssid
When the network SSID is hidden, use this parameter to provide the SSID.
### -param connectionMethod
A WiFiConnectionMethod enumeration member indicating the connection method.
## -returns
An asynchronous connect operation. On successful conclusion of the operation, returns an object that describes the result of the connect operation.
## -remarks

## -see-also
[ConnectAsync(WiFiAvailableNetwork, WiFiReconnectionKind, PasswordCredential)](wifiadapter_connectasync_1490922496.md), [ConnectAsync(WiFiAvailableNetwork, WiFiReconnectionKind, PasswordCredential, String)](wifiadapter_connectasync_1798151424.md)
## -examples

