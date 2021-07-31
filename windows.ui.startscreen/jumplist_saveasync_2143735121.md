---
-api-id: M:Windows.UI.StartScreen.JumpList.SaveAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SaveAsync()
-->

# Windows.UI.StartScreen.JumpList.SaveAsync

## -description
Asynchronously saves changes to the jump list and its items.

## -returns
Returns an [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation. If the system does not support jump lists, the SaveAsync method has no effect and future calls to [LoadCurrentAsync](jumplist_loadcurrentasync_313230072.md) will produce an empty jump list. An app can check for this case using the [IsSupported](jumplist_issupported_930300905.md) method.

## -remarks

## -examples

## -see-also
