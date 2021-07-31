---
-api-id: T:Windows.Security.Cryptography.Certificates.CertificateChain
-api-type: winrt class
---

<!-- Class syntax.
public class CertificateChain : Windows.Security.Cryptography.Certificates.ICertificateChain
-->

# Windows.Security.Cryptography.Certificates.CertificateChain

## -description
Represents a certificate chain used for signature verification.

## -remarks
A certificate chain is a hierarchal collection of certificates that leads from the end user or computer back to a root of trust, typically the root certification authority (CA).

To obtain a CertificateChain object, call the [Certificate.BuildChainAsync](/uwp/api/windows.security.cryptography.certificates.certificate.buildchainasync) method.

## -examples

## -see-also
