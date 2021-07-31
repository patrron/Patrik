//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

//
// App.xaml.h
// Declaration of the App.xaml class.
//

#pragma once

#include "pch.h"
#include "App.g.h"
#include "MainPage.g.h"

namespace SDKSample
{
    ref class App
    {
    internal:
        App();
        virtual void OnSuspending(Platform::Object^ sender, Windows::ApplicationModel::SuspendingEventArgs^ pArgs);
        Windows::ApplicationModel::Activation::LaunchActivatedEventArgs^ LaunchArgs;

    protected:
        virtual void OnLaunched(Windows::ApplicationModel::Activation::LaunchActivatedEventArgs^ pArgs) override;
        virtual void OnSearchActivated(Windows::ApplicationModel::Activation::SearchActivatedEventArgs^ pArgs) override;
        virtual void OnWindowCreated(Windows::UI::Xaml::WindowCreatedEventArgs^ pArgs) override;

        void OnQuerySubmitted(Windows::ApplicationModel::Search::SearchPane^ sender, Windows::ApplicationModel::Search::SearchPaneQuerySubmittedEventArgs^ args);

    private:
        void App::EnsureMainPageActivated(Windows::ApplicationModel::Activation::IActivatedEventArgs^ pArgs);
        Windows::UI::Xaml::Controls::Frame^ rootFrame;
    };
}
