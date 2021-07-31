---
-api-id: M:Windows.Foundation.IClosable.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Foundation.IClosable.Close

## -description
Releases system resources that are exposed by a Windows Runtime object.



> **.NET**
> This interface appears as [System.IDisposable](https://docs.microsoft.com/dotnet/api/system.idisposable?redirectedfrom=MSDN).



> **C++/CX**
> This interface appears as [Platform::IDisposable](https://docs.microsoft.com/cpp/cppcx/platform-idisposable-interface).

## -remarks
Implementation / caller notes that follow are mainly relevant for WRL.

### Notes to implementers

Implement this method to release the exclusive system resources that are in use, such as file handles, streams, and network sockets. The method should also release other resources that are in use, including object references and memory, to prepare them for reuse.

This method must call the Close method of any object it holds that implements [IClosable](iclosable.md).

The Close method should release system resources as quickly as possible, without blocking for asynchronous operations to complete. To ensure that all resources are completely released, the caller must wait for all outstanding asynchronous operations to complete before calling Close.

After Close returns, the object is still in memory but without the system resources it needs; therefore, most of its members are not usable. A member that depends on a released system resource can return **RO_E_CLOSED** to indicate that the object is closed and it cannot complete the requested operation.

### Notes to callers

If you call Close multiple times, there is no effect; the method returns **S_OK**.

Close methods aren't callable through Visual C++ component extensions (C++/CX) on Windows Runtime class instances where the class implemented [IClosable](iclosable.md). Instead, Visual C++ component extensions (C++/CX) code for runtime classes should call the destructor or set the last reference to **null**.

## -examples

## -see-also
