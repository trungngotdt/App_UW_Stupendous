﻿#pragma checksum "C:\Users\Tran\Downloads\App_UW_Stupendous\App_UW_Stupendous\Coffee_Page.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "83191280F310D449761B6AF712C26652"
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
    partial class Coffee_Page : 
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
                    this.Btn_Roast = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 2:
                {
                    this.Btn_Sweetener = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3:
                {
                    this.Btn_Cream = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4:
                {
                    this.Texbl_Result = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.Btn_OK = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 75 "..\..\..\Coffee_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Btn_OK).Tapped += this.Btn_OK_Tapped;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element6 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 56 "..\..\..\Coffee_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element6).Tapped += this.Btn_Cream_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element7 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 57 "..\..\..\Coffee_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element7).Tapped += this.Btn_Cream_Tapped;
                    #line default
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element8 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 58 "..\..\..\Coffee_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element8).Tapped += this.Btn_Cream_Tapped;
                    #line default
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element9 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 43 "..\..\..\Coffee_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element9).Tapped += this.Btn_Sweetener_Tapped;
                    #line default
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element10 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 44 "..\..\..\Coffee_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element10).Tapped += this.Btn_Sweetener_Tapped;
                    #line default
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element11 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 29 "..\..\..\Coffee_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element11).Tapped += this.Btn_Roast_Tapped;
                    #line default
                }
                break;
            case 12:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element12 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 30 "..\..\..\Coffee_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element12).Tapped += this.Btn_Roast_Tapped;
                    #line default
                }
                break;
            case 13:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element13 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 31 "..\..\..\Coffee_Page.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element13).Tapped += this.Btn_Roast_Tapped;
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

