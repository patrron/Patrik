﻿//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";
    var page = WinJS.UI.Pages.define("/html/scenario3.html", {
        ready: function (element, options) {
            document.getElementById("folder").addEventListener("click", pickFolder, false);
        }
    });

    function pickFolder() {
        // Clean scenario output
        WinJS.log && WinJS.log("", "sample", "status");

        //<Snippetall_folderpicker_checksnapped_show>
        //<Snippetjs_folderpicker_checksnapped_show>
        // Verify that we are currently not snapped, or that we can unsnap to open the picker
        var currentState = Windows.UI.ViewManagement.ApplicationView.value;
        if (currentState === Windows.UI.ViewManagement.ApplicationViewState.snapped &&
            !Windows.UI.ViewManagement.ApplicationView.tryUnsnap()) {
            // Fail silently if we can't unsnap
            return;
        }

        //<Snippetall_folderpicker_setprops_show>
        //<Snippetjs_folderpicker_setprops_show>
        //<Snippetall_folderpicker_setprops>
        //<Snippetjs_folderpicker_setprops>
        // Create the picker object and set options
        var folderPicker = new Windows.Storage.Pickers.FolderPicker;
        folderPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.desktop;
        // Users expect to have a filtered view of their folders depending on the scenario.
        // For example, when choosing a documents folder, restrict the filetypes to documents for your application.
        folderPicker.fileTypeFilter.replaceAll([".docx", ".xlsx", ".pptx"]);
        //</Snippetjs_folderpicker_setprops>
        //</Snippetall_folderpicker_setprops>

        //<Snippetall_folderpicker_show>
        //<Snippetjs_folderpicker_show>
        folderPicker.pickSingleFolderAsync().then(function (folder) {
            if (folder) {
                // Application now has read/write access to all contents in the picked folder (including sub-folder contents)
                // Cache folder so the contents can be accessed at a later time
                Windows.Storage.AccessCache.StorageApplicationPermissions.futureAccessList.addOrReplace("PickedFolderToken", folder);
                WinJS.log && WinJS.log("Picked folder: " + folder.name, "sample", "status");
            } else {
                // The picker was dismissed with no selected file
                WinJS.log && WinJS.log("Operation cancelled.", "sample", "status");
            }
        });
        //</Snippetjs_folderpicker_show>
        //</Snippetall_folderpicker_show>
        //</Snippetjs_folderpicker_setprops_show>
        //</Snippetall_folderpicker_setprops_show>
        //</Snippetjs_folderpicker_checksnapped_show>
        //</Snippetall_folderpicker_checksnapped_show>
    }
})();
