﻿//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Collections.Generic;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

namespace SDKTemplate
{
    public partial class MainPage : SDKTemplate.Common.LayoutAwarePage
    {
        public const string FEATURE_NAME = "File picker C# sample";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title = "Pick a single photo",   ClassType = typeof(FilePicker.Scenario1) },
            new Scenario() { Title = "Pick multiple files",   ClassType = typeof(FilePicker.Scenario2) },
            new Scenario() { Title = "Pick a folder",         ClassType = typeof(FilePicker.Scenario3) },
            new Scenario() { Title = "Save a file",           ClassType = typeof(FilePicker.Scenario4) },
            new Scenario() { Title = "Open a cached file",    ClassType = typeof(FilePicker.Scenario5) },
            new Scenario() { Title = "Update a cached file",  ClassType = typeof(FilePicker.Scenario6) },
        };

        //<Snippetall_checksnapped>
        //<Snippetcs_checksnapped>
        internal bool EnsureUnsnapped()
        {
            // FilePicker APIs will not work if the application is in a snapped state.
            // If an app wants to show a FilePicker while snapped, it must attempt to unsnap first
            bool unsnapped = ((ApplicationView.Value != ApplicationViewState.Snapped) || ApplicationView.TryUnsnap());
            if (!unsnapped)
            {
                NotifyUser("Cannot unsnap the sample.", NotifyType.StatusMessage);
            }

            return unsnapped;
        }
        //</Snippetcs_checksnapped>
        //</Snippetall_checksnapped>

        internal void ResetScenarioOutput(TextBlock output)
        {
            // clear Error/Status
            NotifyUser("", NotifyType.ErrorMessage);
            NotifyUser("", NotifyType.StatusMessage);
            // clear scenario output
            output.Text = "";
        }
    }

    public class Scenario
    {
        public string Title { get; set; }

        public Type ClassType { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
