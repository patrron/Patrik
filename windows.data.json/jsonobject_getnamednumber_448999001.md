---
-api-id: M:Windows.Data.Json.JsonObject.GetNamedNumber(System.String)
-api-type: winrt method
---

<!-- Method syntax
public double GetNamedNumber(System.String name)
-->

# Windows.Data.Json.JsonObject.GetNamedNumber

## -description
Gets the number value (a [Double](https://docs.microsoft.com/dotnet/api/system.double?redirectedfrom=MSDN)) with the specified name.

## -parameters
### -param name
The name.

## -returns
The [Double](https://docs.microsoft.com/dotnet/api/system.double?redirectedfrom=MSDN) with the specified *name*.

## -remarks
This method should always used with a try/catch block because it throws an exception if the name found is not a [Double](https://docs.microsoft.com/dotnet/api/system.double?redirectedfrom=MSDN) type or the name is not found.

## -examples

## -see-also
[GetNamedNumber(String, Double)](jsonobject_getnamednumber_124311229.md)