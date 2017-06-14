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
    public sealed partial class Schedule_Page : Page
    {
        public Schedule_Page()
        {
            this.InitializeComponent();
        }
        private string time = null;
        private string date = null;

        private void TimePicker_TimeChanged(object sender, TimePickerValueChangedEventArgs e)
        {
            time = (sender as TimePicker).Time.ToString();
        }

        private void CalendarDatePicker_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            DateTimeOffset value = ((sender as CalendarDatePicker).Date).Value;
            date = value.Day.ToString()+"/"+value.Month.ToString()+"/"+value.Year.ToString();
        }

        private void Btn_OK_Tapped(object sender, TappedRoutedEventArgs e)
        {
            App.ValueforSchedule = "Time :" + time + "\n" + "Date :" + date;
        }
    }
}
