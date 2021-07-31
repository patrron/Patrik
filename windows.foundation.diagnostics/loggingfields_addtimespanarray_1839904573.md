---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddTimeSpanArray(System.String,Windows.Foundation.TimeSpan[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddTimeSpanArray(System.String name, Windows.Foundation.TimeSpan[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddTimeSpanArray

## -description
Adds a time span array field with the specified field name, format, and tags.

## -parameters
### -param name
Name of the event field.

### -param value
The value for the event field.

### -param format
The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.

### -param tags
The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).

## -remarks

## -examples

## -see-also
[AddTimeSpanArray(String, TimeSpan[])](loggingfields_addtimespanarray_120746009.md), [AddTimeSpanArray(String, TimeSpan[], LoggingFieldFormat)](loggingfields_addtimespanarray_1214942467.md)