﻿#pragma checksum "..\..\UsersPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4080469BDFD500F675C172123842FEA3BDCC1944CBFD92929E847FFFC5D890FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WpfApp15;


namespace WpfApp15 {
    
    
    /// <summary>
    /// UsersPage
    /// </summary>
    public partial class UsersPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UsersGrd;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurnameTbx;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MiddleNameTbx;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginTbx;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordTbx;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateBtn;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtn;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RoleCbx;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp15;component/userspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UsersPage.xaml"
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
            this.UsersGrd = ((System.Windows.Controls.DataGrid)(target));
            
            #line 31 "..\..\UsersPage.xaml"
            this.UsersGrd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UsersGrd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SurnameTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\UsersPage.xaml"
            this.SurnameTbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.SurnameTbx_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NameTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\UsersPage.xaml"
            this.NameTbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NameTbx_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MiddleNameTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\UsersPage.xaml"
            this.MiddleNameTbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.MiddleNameTbx_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LoginTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\UsersPage.xaml"
            this.LoginTbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.LoginTbx_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PasswordTbx = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 60 "..\..\UsersPage.xaml"
            this.PasswordTbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PasswordTbx_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\UsersPage.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.UpdateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\UsersPage.xaml"
            this.UpdateBtn.Click += new System.Windows.RoutedEventHandler(this.UpdateBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DeleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\UsersPage.xaml"
            this.DeleteBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.RoleCbx = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

