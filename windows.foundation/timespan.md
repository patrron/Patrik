---
-api-id: T:Windows.Foundation.TimeSpan
-api-type: winrt struct
---

<!-- Structure syntax.
public struct TimeSpan 
-->

# TimeSpan

## -description
Represents a time interval as a signed 64-bit integer value.

> **.NET**
> When programming with .NET, this structure is hidden, and developers should use the [System.TimeSpan](https://docs.microsoft.com/dotnet/api/system.timespan?redirectedfrom=MSDN) type.

> **C++/WinRT**
> This type is a specialization of [std::chrono::duration](/cpp/standard-library/duration-class).

## -struct-fields

### -field Duration
A time period expressed in 100-nanosecond units.

> [!NOTE]
> In C++/WinRT, this field does not exist, because in that language projection **TimeSpan** is a specialization of [std::chrono::duration](/cpp/standard-library/duration-class). If you need the raw integer value, use [duration::count](/cpp/standard-library/duration-class#count) to obtain the raw count.

## -remarks
When programming with .NET, this structure is hidden and developers should use the [System.TimeSpan](https://docs.microsoft.com/dotnet/api/system.timespan?redirectedfrom=MSDN) structure.

In JavaScript, this structure is accessed as a value, not as an object. For example, use `var a = 10000`, not `var a = { duration: 10000 }`.

> [!NOTE]
> In JavaScript, TimeSpan values interpreted as **Number** are treated as the number of millisecond intervals, not the number of 100-nanosecond intervals. Therefore, Windows.Foundation.TimeSpan values can lose precision when being ported between languages.

## -examples

## -see-also
[DateTime](datetime.md), [System.TimeSpan](https://docs.microsoft.com/dotnet/api/system.timespan?redirectedfrom=MSDN)
