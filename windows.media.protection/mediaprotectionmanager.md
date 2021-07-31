---
-api-id: T:Windows.Media.Protection.MediaProtectionManager
-api-type: winrt class
---

<!-- Class syntax.
public class MediaProtectionManager : Windows.Media.Protection.IMediaProtectionManager
-->

# Windows.Media.Protection.MediaProtectionManager

## -description
Contains a content protection manager object for an application that handles protected media content.

## -remarks
The MediaProtectionManager can be passed to the media playback infrastructure in either of two ways: 
+ As an attribute for a `<video>` or `<audio>` tag using the [msSetMediaProtectionManager](https://docs.microsoft.com/previous-versions/hh772532(v=vs.85)) method.
+ Directly to a media playback API. The MediaProtectionManager object is notified of content enabler objects. These objects must be processed by the application, to establish access to protected content. Each MediaProtectionManager object is associated with a single instance of playback.

## -examples
The following example shows how to create a MediaProtectionManager, set the [Properties](mediaprotectionmanager_properties.md) property, and add event listeners for [ComponentLoadFailed](mediaprotectionmanager_componentloadfailed.md) and [ServiceRequested](mediaprotectionmanager_servicerequested.md). See the [How to use pluggable DRM](https://docs.microsoft.com/previous-versions/windows/apps/hh452779(v=win.10)) topic for the full example. 

```javascript

mediaProtectionManager = 
    new Windows.Media.Protection.MediaProtectionManager();

function ServiceRequested(e) {
   logMsg("Got Enabler - system/type: {" + e.request.protectionSystem + "}/{" + e.request.type + "}");
   e.completion.complete(true);
}


function ComponentLoadFailed(e) {
   logMsg(e.information.items.size.toString() + " failed components");
   logMsg("<h2>Components:</h2>");

   //  List the failing components
   for (var i = 0; i < e.information.items.size; i++) {
      logMsg("<h3>" + e.information.items[i].name + "</h3>" +
             "<p>Reasons=0x" + e.information.items[i].reasons.toString(16) +
             "<p>Renewal Id=" + e.information.items[i].renewalId);
   }

   e.completion.complete(false);
}

function RebootNeeded(e) {
   logMsg("Reboot Required");
}

mediaProtectionManager.addEventListener("servicerequested", ServiceRequested, false);
mediaProtectionManager.addEventListener("componentloadfailed", ComponentLoadFailed, false);
mediaProtectionManager.addEventListener("rebootneeded", RebootNeeded, false);
 

```



## -see-also
