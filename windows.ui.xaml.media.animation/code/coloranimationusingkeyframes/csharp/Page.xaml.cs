﻿using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;

namespace coloranimationusingkeyframes
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        // <SnippetColoranimationusingkeyframes_cs>
        // Start the animation when the object loads
        private void Start_Animation(object sender, RoutedEventArgs e)
        {
            colorStoryboard.Begin();
        }
        // </SnippetColoranimationusingkeyframes_cs>
    }
}
