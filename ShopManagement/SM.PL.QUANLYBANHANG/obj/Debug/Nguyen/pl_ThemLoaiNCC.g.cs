﻿#pragma checksum "..\..\..\NGUYEN\pl_ThemLoaiNCC.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E472CE4FE06882EBB479EC4447A24911"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.DXBinding;
using SM.PL.QUANLYBANHANG.NGUYEN;
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


namespace SM.PL.QUANLYBANHANG.NGUYEN {
    
    
    /// <summary>
    /// pl_ThemLoaiNCC
    /// </summary>
    public partial class pl_ThemLoaiNCC : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\NGUYEN\pl_ThemLoaiNCC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Title;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\NGUYEN\pl_ThemLoaiNCC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tenLoai;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\NGUYEN\pl_ThemLoaiNCC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Luu;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\NGUYEN\pl_ThemLoaiNCC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Huy;
        
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
            System.Uri resourceLocater = new System.Uri("/SM.PL.QUANLYBANHANG;component/nguyen/pl_themloaincc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NGUYEN\pl_ThemLoaiNCC.xaml"
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
            this.Title = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.tenLoai = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Luu = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\NGUYEN\pl_ThemLoaiNCC.xaml"
            this.Luu.Click += new System.Windows.RoutedEventHandler(this.Luu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Huy = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\NGUYEN\pl_ThemLoaiNCC.xaml"
            this.Huy.Click += new System.Windows.RoutedEventHandler(this.Huy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

