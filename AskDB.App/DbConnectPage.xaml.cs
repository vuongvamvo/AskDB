using CommunityToolkit.WinUI.UI.Controls;
using DatabaseAnalyzer.Extractors;
using Microsoft.UI.Composition;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AskDB.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DbConnectPage : Page
    {
        public DbConnectPage()
        {
            this.InitializeComponent();
        }

        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), 
                null, 
                new SlideNavigationTransitionInfo() 
                { 
                    Effect = SlideNavigationTransitionEffect.FromRight 
                });
        }
    }
}