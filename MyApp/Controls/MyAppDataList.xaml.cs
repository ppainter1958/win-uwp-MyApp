using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace MyApp.Controls
{
    public sealed partial class MyAppDataList : UserControl
    {
        public MyAppDataList()
        {
            this.InitializeComponent();
        }
        public string ListLabel
        {
            get { return (string)GetValue(ListLabelProperty); }
            set { SetValue(ListLabelProperty, value); }
        }

        public static readonly DependencyProperty ListLabelProperty =
            DependencyProperty.Register("ListLabel", typeof(string), typeof(MyAppDataList), null);

        public ObservableCollection<string> ListSource
        {
            get { return (ObservableCollection<string>)GetValue(ListSourceProperty); }
            set { SetValue(ListSourceProperty, value); }
        }

        public static readonly DependencyProperty ListSourceProperty =
            DependencyProperty.Register("ListSource", typeof(ObservableCollection<string>), typeof(MyAppDataList), null);

    }
}
