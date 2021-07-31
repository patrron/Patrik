---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessAsync(System.String,System.String,Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.ProtectionPolicyEvaluationResult> RequestAccessAsync(System.String sourceIdentity, System.String targetIdentity, Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo auditInfo, System.String messageFromApp)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Request access to enterprise protected content for an identity.

## -parameters
### -param sourceIdentity
The enterprise identity to which the content is protected. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

### -param targetIdentity
The enterprise identity to which the content is being disclosed. This is an email address or domain.

### -param auditInfo
An audit info object; an instance of [ProtectionPolicyAuditInfo](protectionpolicyauditinfo.md).

### -param messageFromApp
A message that will be displayed in the consent dialog so that the user can make a consent decision.

## -returns
A value of the [ProtectionPolicyEvaluationResult](protectionpolicyevaluationresult.md) enumeration that is the result of the request.

## -remarks
Call this method from the main UI thread of your foreground app.

## -examples

## -see-also
[RequestAccessAsync(String, String, ProtectionPolicyAuditInfo)](protectionpolicymanager_requestaccessasync_223712891.md), [RequestAccessAsync(String, String)](protectionpolicymanager_requestaccessasync_63787697.md)