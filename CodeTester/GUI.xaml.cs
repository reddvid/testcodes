﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CodeTester
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GUI : Page
    {
        public GUI()
        {
            this.InitializeComponent();
        }

        private async void btnShowDialog_Click(object sender, RoutedEventArgs e)
        {
            SampleDialog sampleDialog = new SampleDialog();
            await sampleDialog.ShowAsync();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                txtDescription.Text = txtKG.Text;
            }
           catch { }
        }
    }
}
