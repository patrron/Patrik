---
-api-id: P:Windows.Networking.Sockets.MessageWebSocketControl.SupportedProtocols
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> SupportedProtocols { get; }
-->

# Windows.Networking.Sockets.MessageWebSocketControl.SupportedProtocols

## -description
Gets a collection that can be used to add a list of supported sub-protocols that will be advertised to the server during the connect handshake.

## -property-value
A collection that contains the WebSocket sub-protocols supported by the [MessageWebSocket](messagewebsocket.md) object.

## -remarks
The SupportedProtocols property contains a collection of WebSocket sub-protocols supported by the [MessageWebSocket](messagewebsocket.md) object. Before calling the [ConnectAsync](messagewebsocket_connectasync_682685111.md) method, additional supported sub-protocol strings can be added to this collection, which will be sent to the server in the "Sec-WebSocket-Protocol" header during the WebSocket handshake. The mutually supported sub-protocol chosen by the WebSocket server will then be exposed on the [Protocol](messagewebsocketinformation_protocol.md) property.

An attempt to add a sub-protocol to this collection after a successful call to [ConnectAsync](messagewebsocket_connectasync_682685111.md) method will not result in an error but the new value is ignored. However, if the [ConnectAsync](messagewebsocket_connectasync_682685111.md) method call or the connect operation completes with an error, an app can update the collection stored in the SupportedProtocols property and retry the [ConnectAsync](messagewebsocket_connectasync_682685111.md) method call and the new value will be applied.

## -examples

## -see-also
[How to use advanced WebSocket controls ](https://docs.microsoft.com/previous-versions/windows/apps/hh761447(v=win.10)), [How to use advanced WebSocket controls ](https://docs.microsoft.com/previous-versions/windows/apps/hh994400(v=win.10)), [MessageWebSocket](messagewebsocket.md), [MessageWebSocketInformation.Protocol](messagewebsocketinformation_protocol.md)
