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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App_UW_Stupendous
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Donuts_Page : Page
    {
        public Donuts_Page()
        {
            this.InitializeComponent();
        }

        private void Btn_Ok_Tapped(object sender, TappedRoutedEventArgs e)
        {
            App.ValueforDonuts ="Origin :"+ Slider_Origin.Value.ToString()+"\n"+Slider_Speedway.Value.ToString();
        }
    }
}
