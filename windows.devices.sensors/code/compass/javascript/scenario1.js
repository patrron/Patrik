﻿//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";
    var reportInterval = 0;
    var compass;

    var page = WinJS.UI.Pages.define("/html/scenario1.html", {
        ready: function (element, options) {
            document.getElementById("scenario1Open").addEventListener("click", enableReadingChangedScenario, false);
            document.getElementById("scenario1Revoke").addEventListener("click", disableReadingChangedScenario, false);
            document.getElementById("scenario1Open").disabled = false;
            document.getElementById("scenario1Revoke").disabled = true;

            //<SnippetGetDefaultJS>
            compass = Windows.Devices.Sensors.Compass.getDefault();
            //</SnippetGetDefaultJS>

            if (compass) {
                // Select a report interval that is both suitable for the purposes of the app and supported by the sensor.
                // This value will be used later to activate the sensor.
                var minimumReportInterval = compass.minimumReportInterval;
                reportInterval = minimumReportInterval > 16 ? minimumReportInterval : 16;
            } else {
                WinJS.log && WinJS.log("No compass found", "sample", "error");
            }
        },
        unload: function () {
            if (document.getElementById("scenario1Open").disabled) {
                document.removeEventListener("msvisibilitychange", msVisibilityChangeHandler, false);
                compass.removeEventListener("readingchanged", onDataChanged);

                // Return the report interval to its default to release resources while the sensor is not in use
                compass.reportInterval = 0;
            }
        }
    });

    function msVisibilityChangeHandler() {
        // This is the event handler for VisibilityChanged events. You would register for these notifications
        // if handling sensor data when the app is not visible could cause unintended actions in the app.
        if (document.getElementById("scenario1Open").disabled) {
            if (document.msVisibilityState === "visible") {
                // Re-enable sensor input. No need to restore the desired reportInterval (it is restored for us upon app resume)
                compass.addEventListener("readingchanged", onDataChanged);
            } else {
                // Disable sensor input. No need to restore the default reportInterval (resources will be released upon app suspension)
                compass.removeEventListener("readingchanged", onDataChanged);
            }
        }
    }

    //<SnippetonDataChangedJS>
    function onDataChanged(e) {
        var reading = e.reading;

        document.getElementById("eventOutputMagneticNorth").innerHTML = reading.headingMagneticNorth.toFixed(2);
        if (reading.headingTrueNorth) {
            document.getElementById("eventOutputTrueNorth").innerHTML = reading.headingTrueNorth.toFixed(2);
        }
    }
    //</SnippetonDataChangedJS>

    //<SnippetEnableReadingChangedJS>
    function enableReadingChangedScenario() {
        if (compass) {
            // Set the reportInterval to enable the sensor events
            compass.reportInterval = reportInterval;

            document.addEventListener("msvisibilitychange", msVisibilityChangeHandler, false);
            compass.addEventListener("readingchanged", onDataChanged);
            document.getElementById("scenario1Open").disabled = true;
            document.getElementById("scenario1Revoke").disabled = false;
        } else {
            WinJS.log && WinJS.log("No compass found", "sample", "error");
        }
    }
    //</SnippetEnableReadingChangedJS>

    function disableReadingChangedScenario() {
        document.removeEventListener("msvisibilitychange", msVisibilityChangeHandler, false);
        compass.removeEventListener("readingchanged", onDataChanged);
        document.getElementById("scenario1Open").disabled = false;
        document.getElementById("scenario1Revoke").disabled = true;

        // Return the report interval to its default to release resources while the sensor is not in use
        compass.reportInterval = 0;
    }
})();
