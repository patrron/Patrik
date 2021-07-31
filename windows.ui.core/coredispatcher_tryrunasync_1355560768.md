---
-api-id: M:Windows.UI.Core.CoreDispatcher.TryRunAsync(Windows.UI.Core.CoreDispatcherPriority,Windows.UI.Core.DispatchedHandler)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryRunAsync(Windows.UI.Core.CoreDispatcherPriority priority, Windows.UI.Core.DispatchedHandler agileCallback)
-->

# Windows.UI.Core.CoreDispatcher.TryRunAsync

## -description
Attempts to schedule the specified callback on the UI thread from a worker thread, and returns the results asynchronously.

## -parameters
### -param priority
Specifies the priority for event dispatch. Set this to [CoreDispatcherPriority.Normal](coredispatcherpriority.md).

### -param agileCallback
The callback on which the dispatcher returns when the event is dispatched.

## -returns
The asynchronous operation.

## -remarks

If called while the CoreDispatcher is shutting down, this method will complete successfully and return false.

## -examples

## -see-also
[RunAsync](coredispatcher_runasync_447339746.md)
