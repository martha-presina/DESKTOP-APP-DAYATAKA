﻿#pragma checksum "..\..\..\View\LoginWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91B66D71768EB898183A0C81814E57AF8D58E5AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AppAsrama.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AppAsrama.View {
    
    
    /// <summary>
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\View\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblID;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtID;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPWD;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVisiblePWD;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPWD;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ShowHide;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\View\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\View\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCopyright;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\View\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\View\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMin;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AppAsrama;component/view/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\LoginWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblID = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.txtID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.lblPWD = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtVisiblePWD = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtPWD = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 32 "..\..\..\View\LoginWindow.xaml"
            this.txtPWD.PasswordChanged += new System.Windows.RoutedEventHandler(this.txtPWDBox_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ShowHide = ((System.Windows.Controls.Image)(target));
            
            #line 34 "..\..\..\View\LoginWindow.xaml"
            this.ShowHide.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ShowHide_MouseLeave);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\View\LoginWindow.xaml"
            this.ShowHide.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ShowHide_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\View\LoginWindow.xaml"
            this.ShowHide.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ShowHide_PreviewMouseUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\View\LoginWindow.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.btnLogin_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblCopyright = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\View\LoginWindow.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnMin = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\View\LoginWindow.xaml"
            this.btnMin.Click += new System.Windows.RoutedEventHandler(this.btnMin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

