﻿#pragma checksum "C:\Users\Tran\Downloads\App_UW_Stupendous\App_UW_Stupendous\Schedule_Page.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DAC042E6166D57BE8EADD57F98EDA94B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App_UW_Stupendous
{
    partial class Schedule_Page : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Btn_OK = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\Schedule_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Btn_OK).Tapped += this.Btn_OK_Tapped;
                    #line default
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.TimePicker element2 = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                    #line 17 "..\..\..\Schedule_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.TimePicker)element2).TimeChanged += this.TimePicker_TimeChanged;
                    #line default
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.CalendarDatePicker element3 = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    #line 19 "..\..\..\Schedule_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)element3).DateChanged += this.CalendarDatePicker_DateChanged;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

