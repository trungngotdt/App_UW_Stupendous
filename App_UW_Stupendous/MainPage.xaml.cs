using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App_UW_Stupendous
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            rootFrame.Navigate(typeof(Donuts_Page));
        }

        private void Btn_Donuts_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(Donuts_Page));
        }

        private void Btn_Coffee_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(Coffee_Page));
        }

        private void Btn_Schedule_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(Schedule_Page));
        }

        private void Btn_Complete_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(Complete_Page));
        }

        
    }
}
