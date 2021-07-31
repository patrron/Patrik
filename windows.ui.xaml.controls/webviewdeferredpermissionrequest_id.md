---
-api-id: P:Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest.Id
-api-type: winrt property
---

<!-- Property syntax
public uint Id { get; }
-->

# Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest.Id

## -description
Gets the identifier for the permission request.

## -property-value
The identifier for the permission request.

## -remarks
When a [WebViewPermissionRequest](webviewpermissionrequest.md) is deferred, a [WebViewDeferredPermissionRequest](webviewdeferredpermissionrequest.md) is created with the same [Id](webviewpermissionrequest_id.md) and added to the [DeferredPermissionRequests](webview_deferredpermissionrequests.md) collection. When you are ready to act on the request, call the [DeferredPermissionRequestById](webview_deferredpermissionrequestbyid_219166912.md) method and pass the Id of the deferred request.

## -examples

## -see-also
