﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6732B1C60F28AA26F5ECA6B4097E6045B60B137AE06C9BB12D50CB07794C2E94"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Inlamning_3_ra_kod;
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


namespace Inlamning_3_ra_kod {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LetterField;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NumberField;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock VarLetterField;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock VarField;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NumBtn_chs;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NumBtn_comma;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EnterBtn;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DebugTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/Inlamning_3_ra_kod;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.LetterField = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.NumberField = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.VarLetterField = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.VarField = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.NumBtn_chs = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\MainWindow.xaml"
            this.NumBtn_chs.Click += new System.Windows.RoutedEventHandler(this.NumCHS);
            
            #line default
            #line hidden
            return;
            case 6:
            this.NumBtn_comma = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\MainWindow.xaml"
            this.NumBtn_comma.Click += new System.Windows.RoutedEventHandler(this.NumComma);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 19 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NumBtn);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 20 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NumBtn);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 21 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NumBtn);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 22 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NumBtn);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 23 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NumBtn);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 24 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NumBtn);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 25 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NumBtn);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 26 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NumBtn);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 27 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NumBtn);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 28 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NumBtn);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 31 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_binop);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 32 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_binop);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 33 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_binop);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 34 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_binop);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 35 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_unop);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 36 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_unop);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 37 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_binop);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 38 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_binop);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 39 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_unop);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 40 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_unop);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 41 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_unop);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 42 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_unop);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 43 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_unop);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 44 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_unop);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 45 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_unop);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 46 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_unop);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 47 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_unop);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 48 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_unop);
            
            #line default
            #line hidden
            return;
            case 35:
            
            #line 49 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_nilop);
            
            #line default
            #line hidden
            return;
            case 36:
            
            #line 50 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_nilop);
            
            #line default
            #line hidden
            return;
            case 37:
            this.EnterBtn = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\MainWindow.xaml"
            this.EnterBtn.Click += new System.Windows.RoutedEventHandler(this.EnterBtnClick);
            
            #line default
            #line hidden
            return;
            case 38:
            
            #line 54 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Clr_Btn);
            
            #line default
            #line hidden
            return;
            case 39:
            
            #line 55 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Clx_Btn);
            
            #line default
            #line hidden
            return;
            case 40:
            
            #line 56 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_swap);
            
            #line default
            #line hidden
            return;
            case 41:
            
            #line 57 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_dup);
            
            #line default
            #line hidden
            return;
            case 42:
            
            #line 58 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_drop);
            
            #line default
            #line hidden
            return;
            case 43:
            
            #line 59 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_roll);
            
            #line default
            #line hidden
            return;
            case 44:
            
            #line 60 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Clst_Btn);
            
            #line default
            #line hidden
            return;
            case 45:
            
            #line 63 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Call_but);
            
            #line default
            #line hidden
            return;
            case 46:
            
            #line 64 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Call_but);
            
            #line default
            #line hidden
            return;
            case 47:
            
            #line 65 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Call_but);
            
            #line default
            #line hidden
            return;
            case 48:
            
            #line 66 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Call_but);
            
            #line default
            #line hidden
            return;
            case 49:
            
            #line 67 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Call_but);
            
            #line default
            #line hidden
            return;
            case 50:
            
            #line 68 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Call_but);
            
            #line default
            #line hidden
            return;
            case 51:
            
            #line 69 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Call_but);
            
            #line default
            #line hidden
            return;
            case 52:
            
            #line 70 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Call_but);
            
            #line default
            #line hidden
            return;
            case 53:
            
            #line 73 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_rcl);
            
            #line default
            #line hidden
            return;
            case 54:
            
            #line 74 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_sto);
            
            #line default
            #line hidden
            return;
            case 55:
            
            #line 77 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_rcl);
            
            #line default
            #line hidden
            return;
            case 56:
            
            #line 78 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpBtn_sto);
            
            #line default
            #line hidden
            return;
            case 57:
            this.DebugTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

