---
-api-id: M:Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateAndContinue(Windows.Foundation.Uri,Windows.Foundation.Uri,Windows.Foundation.Collections.ValueSet,Windows.Security.Authentication.Web.WebAuthenticationOptions)
-api-type: winrt method
---

<!-- Method syntax
public void AuthenticateAndContinue(Windows.Foundation.Uri requestUri, Windows.Foundation.Uri callbackUri, Windows.Foundation.Collections.ValueSet continuationData, Windows.Security.Authentication.Web.WebAuthenticationOptions options)
-->

# Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateAndContinue

## -description
Starts the authentication operation with four inputs.

## -parameters
### -param requestUri
The starting URI of the web service. This URI must be a secure address of https://.

### -param callbackUri
The callback URI that indicates the completion of the web authentication. The broker matches this URI against every URI that it is about to navigate to. The broker never navigates to this URI, instead the broker returns the control back to the application when the user clicks a link or a web server redirection is made.

### -param continuationData
Continuation data to be passed as part of the authentication operation.

### -param options
The options for the authentication operation.

## -remarks

## -examples

## -see-also
[AuthenticateAndContinue(Uri)](webauthenticationbroker_authenticateandcontinue_1571442307.md), [AuthenticateAndContinue(Uri, Uri)](webauthenticationbroker_authenticateandcontinue_1464219191.md), [Web authentication broker](https://docs.microsoft.com/windows/uwp/security/web-authentication-broker), [How to continue your Windows Phone 8.x app after calling an AndContinue method](https://docs.microsoft.com/previous-versions/windows/apps/dn631755(v=win.10))
