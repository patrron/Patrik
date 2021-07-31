---
-api-id: M:Windows.Foundation.Diagnostics.LoggingActivity.#ctor(System.String,Windows.Foundation.Diagnostics.ILoggingChannel)
-api-type: winrt method
---

<!-- Method syntax
public LoggingActivity(System.String activityName, Windows.Foundation.Diagnostics.ILoggingChannel loggingChannel)
-->

# Windows.Foundation.Diagnostics.LoggingActivity.LoggingActivity

## -description
Initializes a new instance of the [LoggingActivity](loggingactivity.md) class for the specified [LoggingChannel](loggingchannel.md) in Windows 8.1 compatibility mode.

## -parameters
### -param activityName
The name of the logging activity.

### -param loggingChannel
The logging channel.

## -remarks
> **Windows 10**
> Two modes of operation are now supported: Windows 8.1 compatibility mode and the new behavior supported by Windows 10 and later.+ For Windows 8.1 compatibility mode, create the object using a constructor.
+ For Windows 10 and later specific behavior, create a LoggingActivity object by using [LoggingChannel.StartActivity](loggingchannel_startactivity_1799218284.md) or [LoggingActivity.StartActivity](loggingactivity_startactivity_1799218284.md).
The differences between these two modes are:

<table>
   <tr><th>Windows 8.1 compatibility mode</th><th>Windows 10 and later specific behavior</th></tr>
   <tr><td>The start event generated by the constructor is formatted for compatibility with the manifest used by [LoggingChannel](loggingchannel.md). The start event name is hard-coded as `“LogActivityStart” + Level`. The event will be a manifest-based event or a self-describing event depending on the operating mode of the underlying channel.</td><td>The start event generated by the [StartActivity](loggingactivity_startactivity_1799218284.md) method follows the conventions of [LoggingChannel.LogEvent](loggingchannel_logevent_1783961521.md) and will always use a self-describing, i.e. not manifest-based, event encoding. The event name is based on the **startEventName** parameter.</td></tr>
   <tr><td>The stop event generated by [Close()](loggingactivity_close_811482585.md) or **Dispose()** is formatted for compatibility with the manifest used by [LoggingChannel](loggingchannel.md). The stop event name is hard-coded as `“LogActivityStop” + Level`. The event will be a manifest-based event or a self-describing event, depending on the operating mode of the underlying channel.</td><td>The Stop event generated by [Close()](loggingactivity_close_811482585.md) or **Dispose()** will follow the conventions of [LoggingChannel.LogEvent](loggingchannel_logevent_1783961521.md) and will use the self-describing event encoding. The activity name will be used as the stop event name.</td></tr>
   <tr><td>The destructor/finalizer will invoke **Close()**.</td><td>The destructor/finalizer will not invoke [Close()](loggingactivity_close_811482585.md).</td></tr>
</table>

## -examples

## -see-also
[LoggingActivity(String, ILoggingChannel, LoggingLevel)](loggingactivity_loggingactivity_1858772704.md), [LoggingChannel](loggingchannel.md), [StartActivity](loggingactivity_startactivity_1851321502.md)