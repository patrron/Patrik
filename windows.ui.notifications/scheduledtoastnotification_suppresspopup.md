---
-api-id: P:Windows.UI.Notifications.ScheduledToastNotification.SuppressPopup
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool SuppressPopup { get;  set; }
-->

# Windows.UI.Notifications.ScheduledToastNotification.SuppressPopup

## -description
Gets or sets whether a toast's pop-up UI is displayed on the user's screen.

> Do not set this property to **true** in a toast sent to a Windows 8.x device. Doing so will cause a compiler error or a dropped notification.

## -property-value
Set to **true** to suppress the popup message; otherwise, false. The default value is false, meaning the toast's pop-up message will be shown. Setting this property to **true** places the toast notification silently into the action center. This enables your app to communicate with the user without interrupting them.

## -remarks

## -examples

## -see-also
[ToastNotification.SuppressPopup](toastnotification_suppresspopup.md)