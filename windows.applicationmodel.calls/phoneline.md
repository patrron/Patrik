---
-api-id: T:Windows.ApplicationModel.Calls.PhoneLine
-api-type: winrt class
---

<!-- Class syntax.
public class PhoneLine : Windows.ApplicationModel.Calls.IPhoneLine
-->

# Windows.ApplicationModel.Calls.PhoneLine

## -description
Represents a phone line.

## -remarks
A phone line is a line on a device that can either receive incoming calls or place outgoing calls, depending on whether the line is configured to support dialing out. For example, a single SIM device has 1 cellular line while a dual SIM device has 2 cellular lines. The system will automatically create new lines for VoIP applications that allow initiating an outgoing call.

Each PhoneLine instance has properties specific to that line.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | EnableTextReply |
| 1903 | 18362 | TransportDeviceId |

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem
