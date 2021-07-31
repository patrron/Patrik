﻿//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";
    var sensor;

    var page = WinJS.UI.Pages.define("/html/scenario1.html", {
        ready: function (element, options) {
            document.getElementById("scenario1Open").addEventListener("click", enableReadingChangedScenario, false);
            document.getElementById("scenario1Revoke").addEventListener("click", disableReadingChangedScenario, false);
            document.getElementById("scenario1Open").disabled = false;
            document.getElementById("scenario1Revoke").disabled = true;

            //<SnippetGetDefaultJS>
            sensor = Windows.Devices.Sensors.SimpleOrientationSensor.getDefault();
            //</SnippetGetDefaultJS>

            if (sensor === null) {
                WinJS.log && WinJS.log("No simple orientation sensor found", "sample", "error");
            }
        },
        unload: function () {
            if (document.getElementById("scenario1Open").disabled) {
                document.removeEventListener("msvisibilitychange", msVisibilityChangeHandler, false);
                sensor.removeEventListener("orientationchanged", onDataChanged);
            }
        }
    });

    function msVisibilityChangeHandler() {
        // This is the event handler for VisibilityChanged events. You would register for these notifications
        // if handling sensor data when the app is not visible could cause unintended actions in the app.
        if (document.getElementById("scenario1Open").disabled) {
            if (document.msVisibilityState === "visible") {
                // Re-enable sensor input. No need to restore the desired reportInterval (it is restored for us upon app resume)
                sensor.addEventListener("orientationchanged", onDataChanged);
            } else {
                // Disable sensor input. No need to restore the default reportInterval (resources will be released upon app suspension)
                sensor.removeEventListener("orientationchanged", onDataChanged);
            }
        }
    }

    //<SnippetonDataChangedJS>
    function onDataChanged(e) {
        switch (e.orientation) {
            case Windows.Devices.Sensors.SimpleOrientation.notRotated:
                document.getElementById("eventOutputOrientation").innerHTML = "Not Rotated";
                break;
            case Windows.Devices.Sensors.SimpleOrientation.rotated90DegreesCounterclockwise:
                document.getElementById("eventOutputOrientation").innerHTML = "Rotated 90";
                break;
            case Windows.Devices.Sensors.SimpleOrientation.rotated180DegreesCounterclockwise:
                document.getElementById("eventOutputOrientation").innerHTML = "Rotated 180";
                break;
            case Windows.Devices.Sensors.SimpleOrientation.rotated270DegreesCounterclockwise:
                document.getElementById("eventOutputOrientation").innerHTML = "Rotated 270";
                break;
            case Windows.Devices.Sensors.SimpleOrientation.faceup:
                document.getElementById("eventOutputOrientation").innerHTML = "Face Up";
                break;
            case Windows.Devices.Sensors.SimpleOrientation.facedown:
                document.getElementById("eventOutputOrientation").innerHTML = "Face Down";
                break;
            default:
                document.getElementById("eventOutputOrientation").innerHTML = "Undefined orientation " + e.orientation;
                break;
        }
    }
    //</SnippetonDataChangedJS>

    //<SnippetEnableReadingChangedJS>
    function enableReadingChangedScenario() {
        if (sensor) {
            document.addEventListener("msvisibilitychange", msVisibilityChangeHandler, false);
            sensor.addEventListener("orientationchanged", onDataChanged);
            document.getElementById("scenario1Open").disabled = true;
            document.getElementById("scenario1Revoke").disabled = false;
        } else {
            WinJS.log && WinJS.log("No simple orientation sensor found", "sample", "error");
        }
    }
    //</SnippetEnableReadingChangedJS>


    function disableReadingChangedScenario() {
        document.removeEventListener("msvisibilitychange", msVisibilityChangeHandler, false);
        sensor.removeEventListener("orientationchanged", onDataChanged);
        document.getElementById("scenario1Open").disabled = false;
        document.getElementById("scenario1Revoke").disabled = true;
    }
})();
