﻿#pragma checksum "C:\Users\Tran\Downloads\App_UW_Stupendous\App_UW_Stupendous\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "520A410F578813AB564DD90E95DB5259"
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
    partial class MainPage : 
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
                    this.rootFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 2:
                {
                    this.Btn_Complete = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 54 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Btn_Complete).Tapped += this.Btn_Complete_Tapped;
                    #line default
                }
                break;
            case 3:
                {
                    this.Btn_Schedule = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 49 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Btn_Schedule).Tapped += this.Btn_Schedule_Tapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.Btn_Coffee = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 44 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Btn_Coffee).Tapped += this.Btn_Coffee_Tapped;
                    #line default
                }
                break;
            case 5:
                {
                    this.Btn_Donuts = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Btn_Donuts).Tapped += this.Btn_Donuts_Tapped;
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

