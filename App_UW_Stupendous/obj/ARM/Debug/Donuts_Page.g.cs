﻿#pragma checksum "C:\Users\Tran\Documents\New folder\App_UW_Stupendous\App_UW_Stupendous\Donuts_Page.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3302DF922048D50CDE051B6F52003C9A"
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
    partial class Donuts_Page : 
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
                    this.Page1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2:
                {
                    this.Slider_Origin = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 3:
                {
                    this.Slider_Speedway = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 4:
                {
                    this.Btn_Ok = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 57 "..\..\..\Donuts_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Btn_Ok).Tapped += this.Btn_Ok_Tapped;
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
