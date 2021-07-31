---
-api-id: M:Windows.Data.Json.JsonObject.Parse(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Json.JsonObject Parse(System.String input)
-->

# Windows.Data.Json.JsonObject.Parse

## -description
Parses the specified JSON string that represents a [JsonObject](jsonobject.md) into a JSON value.

> [!NOTE]
> This will throw an exception if the provided JSON string is not valid. Use of [JsonObject.TryParse](jsonobject_tryparse_1919547471.md) is a recommended alternative. A [TryParse](jsonobject_tryparse_1919547471.md) call will return a boolean value to indicate success or failure and, if successful, the resultant [JsonObject](jsonobject.md).

## -parameters
### -param input
The specified JSON string.

## -returns


## -remarks
This method may only be called when the [ValueType](ijsonvalue_valuetype.md) is **Null**. If the value contained in the specified JSON string is a String, a Number or a Boolean, the [ValueType](ijsonvalue_valuetype.md) will be updated and the actual value can then be accessed through the [GetString](ijsonvalue_getstring_1001279800.md), [GetNumber](ijsonvalue_getnumber_1143516409.md) or [GetBoolean](ijsonvalue_getboolean_1304335680.md) methods. If [Parse](jsonvalue_parse_705027695.md) fails due to an invalid JSON string or resource allocation errors, the [ValueType](ijsonvalue_valuetype.md) will not be changed.

When implemented on the subclass [JsonObject](jsonobject_jsonobject_1221375020.md), this method requires the specified input string to be a valid JSON object value. When implemented on the subclass [JsonArray](jsonarray_jsonarray_1221375020.md), this method requires the specified input string to be a valid JSON array value. The original object state will be overwritten when [JsonObject](jsonobject_jsonobject_1221375020.md).[Parse](jsonvalue_parse_705027695.md) or [JsonArray](jsonarray_jsonarray_1221375020.md).[Parse](jsonvalue_parse_705027695.md) succeeds. If [Parse](jsonvalue_parse_705027695.md) fails, the object state remains intact.

## -examples

## -see-also
[TryParse](jsonobject_tryparse_1919547471.md)