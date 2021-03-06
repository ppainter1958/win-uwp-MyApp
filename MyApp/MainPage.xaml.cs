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
using MyApp.Views;

namespace MyApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel MyMainPageViewModel { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            MyMainPageViewModel = new MainPageViewModel();
        }

        private void ListViewHostNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void Page_Loading(FrameworkElement sender, object args)
        {
            string userInfo = await MyMainPageViewModel.GetUserInfoAsync();
            MyMainPageViewModel.UserInfo = userInfo;
        }

        private void HPInfoAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HPInfoPage));
        }

        private void HPIDAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HPIDPage));
        }
    }
}
