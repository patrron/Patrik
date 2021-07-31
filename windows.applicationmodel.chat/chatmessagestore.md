---
-api-id: T:Windows.ApplicationModel.Chat.ChatMessageStore
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ChatMessageStore : Windows.ApplicationModel.Chat.IChatMessageStore, Windows.ApplicationModel.Chat.IChatMessageStore2, Windows.ApplicationModel.Chat.IChatMessageStore3
-->

# Windows.ApplicationModel.Chat.ChatMessageStore

## -description
Provides the methods and properties to read, manage and send messages. An application gets access to the message store using the static [ChatMessageManager class](chatmessagemanager.md).

## -remarks
Obtain an instance of this class by calling [RequestStoreAsync](chatmessagemanager_requeststoreasync_428591920.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | GetMessageBySyncIdAsync |

## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
