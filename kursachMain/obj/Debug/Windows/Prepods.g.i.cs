﻿#pragma checksum "..\..\..\Windows\Prepods.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F420D95B47ECD00A3718010C41780E95"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using kursachMain;
using kursachMain.Windows;


namespace kursachMain.Windows {
    
    
    /// <summary>
    /// Prepods
    /// </summary>
    public partial class Prepods : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Windows\Prepods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FIO_txt;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\Prepods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Pulpit_txt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\Prepods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Positin_txt;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\Prepods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Save;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\Prepods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_PrepodsShowSqlTabl;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\Prepods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PrepodDatabaseGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/kursachMain;component/windows/prepods.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\Prepods.xaml"
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
            
            #line 9 "..\..\..\Windows\Prepods.xaml"
            ((kursachMain.Windows.Prepods)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FIO_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\Windows\Prepods.xaml"
            this.FIO_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Pulpit_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\Windows\Prepods.xaml"
            this.Pulpit_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Positin_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_Save = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Windows\Prepods.xaml"
            this.btn_Save.Click += new System.Windows.RoutedEventHandler(this.btn_Save_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_PrepodsShowSqlTabl = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Windows\Prepods.xaml"
            this.btn_PrepodsShowSqlTabl.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PrepodDatabaseGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 32 "..\..\..\Windows\Prepods.xaml"
            this.PrepodDatabaseGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PrepodDatabaseGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

