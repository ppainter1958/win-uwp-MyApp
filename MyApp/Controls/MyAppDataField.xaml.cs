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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace MyApp.Controls
{
    public sealed partial class MyAppDataField : UserControl
    {
        public MyAppDataField()
        {
            this.InitializeComponent();
        }
        public string FieldLabel
        {
            get { return (string)GetValue(FieldLabelProperty); }
            set { SetValue(FieldLabelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for textblock.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FieldLabelProperty =
            DependencyProperty.Register("FieldLabel", typeof(string), typeof(MyAppDataField), null);

        public string FieldValue
        {
            get { return (string)GetValue(FieldValueProperty); }
            set { SetValue(FieldValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for textblock.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FieldValueProperty =
            DependencyProperty.Register("FieldValue", typeof(string), typeof(MyAppDataField), null);

    }
}
