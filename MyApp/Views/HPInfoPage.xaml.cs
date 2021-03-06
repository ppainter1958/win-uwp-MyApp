﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MyApp.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HPInfoPage : Page
    {
        public HPInfoPageViewModel MyHPInfoPageViewModel { get; set; }

        public HPInfoPage()
        {
            this.InitializeComponent();
            MyHPInfoPageViewModel = new HPInfoPageViewModel();
        }

        private async void Page_Loading(FrameworkElement sender, object args)
        {
            string fullName = await MyHPInfoPageViewModel.GetFullName();
            MyHPInfoPageViewModel.FullName = fullName;
        }

        private void HomeAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
