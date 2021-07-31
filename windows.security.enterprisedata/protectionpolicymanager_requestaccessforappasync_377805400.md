---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessForAppAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.ProtectionPolicyEvaluationResult> RequestAccessForAppAsync(System.String sourceIdentity, System.String appPackageFamilyName)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessForAppAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Request access to enterprise-protected content for a specific target app.

## -parameters

### -param sourceIdentity
The enterprise identity to which the content is protected. This is an email address or domain that is managed. Your app can use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

### -param appPackageFamilyName
The description of the App package family name.

## -returns
A value of the [ProtectionPolicyEvaluationResult](protectionpolicyevaluationresult.md) enumeration that is the result of the query.

## -remarks

## -examples

## -see-also
[RequestAccessForAppAsync(String, String, IProtectionPolicyAuditInfo)](protectionpolicymanager_requestaccessforappasync_22970468.md), [RequestAccessForAppAsync(String, String, IProtectionPolicyAuditInfo, String)](protectionpolicymanager_requestaccessforappasync_850310812.md)
