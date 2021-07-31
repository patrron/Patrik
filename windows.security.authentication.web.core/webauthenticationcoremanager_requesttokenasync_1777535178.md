---
-api-id: M:Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.RequestTokenAsync(Windows.Security.Authentication.Web.Core.WebTokenRequest)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Web.Core.WebTokenRequestResult> RequestTokenAsync(Windows.Security.Authentication.Web.Core.WebTokenRequest request)
-->

# Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.RequestTokenAsync

## -description
Asynchronously requests a token from a web account provider. If necessary, the user is prompted to enter their credentials.

## -parameters
### -param request
The web token request.

## -returns
An asynchronous request operation. On successful completion, contains a [WebTokenRequestResult](webtokenrequestresult.md) object representing the result of the web token request.

## -remarks
This method cannot be called from background threads.

## -examples

## -see-also
[Web account management code sample](https://go.microsoft.com/fwlink/p/?LinkId=620621), [RequestTokenAsync(WebTokenRequest, WebAccount)](webauthenticationcoremanager_requesttokenasync_695504446.md)
