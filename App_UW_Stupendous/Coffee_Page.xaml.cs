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
    public sealed partial class Coffee_Page : Page
    {
        public Coffee_Page()
        {
            this.InitializeComponent();
        }
        private string Roast="None";
        private string Sweetener="None";
        private string Cream="None";
        private void Btn_Roast_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Roast = (sender as MenuFlyoutItem).Text;
            Display();
        }

        private void Btn_Sweetener_Tapped(object sender, TappedRoutedEventArgs e)
        { 
            Sweetener=(sender as MenuFlyoutItem).Text;
            Display();
        }

        private void Btn_Cream_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Cream= (sender as MenuFlyoutItem).Text;
            Display();
        }
        private void Display()
        {
            if ((!Roast.Equals("None")))
            {
                if ((!Cream.Equals("None")))
                {
                    if ((!Sweetener.Equals("None")) )
                    {
                        Texbl_Result.Text = Roast + "+" +Sweetener  + "+" +Cream ;
                    }
                    else
                    {
                        Texbl_Result.Text = Roast + "+" + Cream;
                    }
                }
                else if ((!Sweetener.Equals("None")))
                {
                    Texbl_Result.Text = Roast + "+" + Sweetener;
                }
                else
                {
                    Texbl_Result.Text = Roast;
                }
            }
            else 
            {
                if ((!Cream.Equals("None")) )
                {
                    if ((!Sweetener.Equals("None")) )
                    {
                        Texbl_Result.Text = Cream + "+" + Sweetener;
                    }
                    else
                    {
                        Texbl_Result.Text =  Cream;
                    }
                }
                else if ((!Sweetener.Equals("None")) )
                {
                    Texbl_Result.Text = Sweetener;
                }
                else
                {
                    
                }
            }
        }

        private void Btn_OK_Tapped(object sender, TappedRoutedEventArgs e)
        {
            App.ValueforCoffee = Texbl_Result.Text;
        }
    }
}
