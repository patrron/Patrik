//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the Microsoft Public License.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using SDKTemplate;
using System;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI;

namespace Input
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario3 : SDKTemplate.Common.LayoutAwarePage
    {
        // A pointer back to the main page.  This is needed if you want to call methods in MainPage such
        // as NotifyUser()
        MainPage rootPage = MainPage.Current;

        //<snippetScenario3Code>
        public Scenario3()
        {
            this.InitializeComponent();
            bTapped.Tapped += new TappedEventHandler(bTapped_Tapped);
            bDoubleTapped.DoubleTapped += new DoubleTappedEventHandler(
                bDoubleTapped_DoubleTapped);
            bRightTapped.RightTapped += new RightTappedEventHandler(
                bRightTapped_RightTapped);
            bHolding.Holding += new HoldingEventHandler(bHolding_Holding);
        }

        private void Scenario3UpdateVisuals(Border border, String gesture)
        {
            switch (gesture.ToLower())
            {
                case "holding":
                    border.Background = new SolidColorBrush(Colors.Yellow);
                    break;
                default:
                    border.Background = new SolidColorBrush(Colors.Green);
                    break;
            }

            ((TextBlock)border.Child).Text = gesture;
        }

        private void bHolding_Holding(object sender, HoldingRoutedEventArgs e)
        {
            string holdingState = 
                (e.HoldingState == Windows.UI.Input.HoldingState.Started) ? 
                "Holding" : "Held";
            Scenario3UpdateVisuals(sender as Border, holdingState);
        }

        private void bDoubleTapped_DoubleTapped(object sender, 
            DoubleTappedRoutedEventArgs e)
        {
            Scenario3UpdateVisuals(sender as Border, "Double Tapped");
        }

        private void bRightTapped_RightTapped(object sender, 
            RightTappedRoutedEventArgs e)
        {
            Scenario3UpdateVisuals(sender as Border, "Right Tapped");
        }

        private void bTapped_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Scenario3UpdateVisuals(sender as Border, "Tapped");
        }

        private void Scenario3Reset(object sender, RoutedEventArgs e)
        {
            Scenario3Reset();
        }

        private void Scenario3Reset()
        {
            bTapped.Background = new SolidColorBrush(Colors.Red);
            bHolding.Background = new SolidColorBrush(Colors.Red);
            bDoubleTapped.Background = new SolidColorBrush(Colors.Red);
            bRightTapped.Background = new SolidColorBrush(Colors.Red);
        }
        //</snippetScenario3Code>
    }
}
