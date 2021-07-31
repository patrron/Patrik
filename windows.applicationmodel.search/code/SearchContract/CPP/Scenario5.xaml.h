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
// Scenario5.xaml.h
// Declaration of the Scenario5 class
//

#pragma once

#include "pch.h"
#include "Scenario5.g.h"
#include "MainPage.xaml.h"
#include "HttpRequest.h"

#pragma warning(push)
#pragma warning(disable:4451) // Warns about possible invalid marshaling of objects across threads. In this case, the warning doesn't apply because the SearchPane object is only accessed from the UI thread.
namespace SDKSample
{
    namespace SearchContract
    {
        /// <summary>
        /// An empty page that can be used on its own or navigated to within a Frame.
        /// </summary>
        [Windows::Foundation::Metadata::WebHostHidden]
        public ref class Scenario5 sealed
        {
        public:
            Scenario5();

        protected:
            virtual void OnNavigatedTo(Windows::UI::Xaml::Navigation::NavigationEventArgs^ e) override;
            virtual void OnNavigatedFrom(Windows::UI::Xaml::Navigation::NavigationEventArgs^ e) override;
            void OnSearchPaneSuggestionsRequested(Windows::ApplicationModel::Search::SearchPane^ sender, Windows::ApplicationModel::Search::SearchPaneSuggestionsRequestedEventArgs^ e);

        private:
            Windows::ApplicationModel::Search::SearchPane^ searchPane;
            Windows::Foundation::EventRegistrationToken token;
            concurrency::cancellation_token_source cts;
            Web::HttpRequest httpRequest;
        };
    }
}
#pragma warning(pop) // Reenable warning 4451
