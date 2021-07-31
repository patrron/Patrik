---
-api-id: T:Windows.Foundation.IReference`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IReference<T> : Windows.Foundation.IPropertyValue
-->

# Windows.Foundation.IReference<T>

## -description
Enables arbitrary enumerations, structures, and delegate types to be used as property values.

> **.NET**
> This interface appears as [Nullable&lt;T&gt;](https://docs.microsoft.com/dotnet/api/system.nullable-1?redirectedfrom=MSDN).

> **C++/CX**
> This interface appears as [Platform::IBox&lt;T&gt;](https://docs.microsoft.com/cpp/cppcx/platform-ibox-interface)

## -remarks
When programming with .NET, this interface is hidden, and you should use the [Nullable&lt;T&gt;](https://docs.microsoft.com/dotnet/api/system.nullable-1?redirectedfrom=MSDN) class. All Windows Runtime members where the basic IDL signature shows IReference (with a constraint) are instead exposed using the nullable syntax of the nullable value type (for example, **?bool**).

When programming with C++/CX, this interface is hidden, and you should use the [Platform::IBox&lt;T&gt;](https://docs.microsoft.com/cpp/cppcx/platform-ibox-interface) interface. All Windows Runtime members where the basic IDL signature shows IReference (with a constraint) are instead exposed using [Platform::IBox&lt;T&gt;](https://docs.microsoft.com/cpp/cppcx/platform-ibox-interface) with the template as a particular value type. This is how C++/CX implements nullable value types. For more info, see [Value classes and structs (C++/CX)](/cpp/cppcx/value-classes-and-structs-c-cx).

Because both .NET and C++/CX have projection equivalents, don't implement this interface unless you are using WRL and/or writing code for a Windows Runtime component, and need a nullable value type.

### Interface inheritance

IReference&lt;T&gt; inherits [IPropertyValue](ipropertyvalue.md). Types that implement IReference&lt;T&gt; also implement the interface members of [IPropertyValue](ipropertyvalue.md).

## -examples

```csharp
bool flag = myScrollViewer.ChangeView(2, null, null);
```

```cppwinrt
bool flag{ myScrollViewer.ChangeView(Windows::Foundation::IReference<double>{2.f}, nullptr, nullptr) };
```

## -see-also
[IPropertyValue](ipropertyvalue.md), [Nullable&lt;T&gt;](https://docs.microsoft.com/dotnet/api/system.nullable-1?redirectedfrom=MSDN), [Platform::IBox&lt;T&gt;](https://docs.microsoft.com/cpp/cppcx/platform-ibox-interface), [Value classes and structs (C++/CX)](https://docs.microsoft.com/cpp/cppcx/value-classes-and-structs-c-cx)
