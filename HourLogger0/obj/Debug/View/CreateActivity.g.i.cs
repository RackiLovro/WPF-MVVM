﻿#pragma checksum "..\..\..\View\CreateActivity.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BA7BF2C3E8C032B6ACB9EBE09DF63A0E6A0F1E3E0ED8EB66BC7F228641B94662"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HourLogger;
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


namespace HourLogger {
    
    
    /// <summary>
    /// CreateActivity
    /// </summary>
    public partial class CreateActivity : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\View\CreateActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Data.XmlDataProvider projects;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\CreateActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox activityProject;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\CreateActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox activityDescription;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\CreateActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker activityDate;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\View\CreateActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox activityDuration;
        
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
            System.Uri resourceLocater = new System.Uri("/HourLogger;component/view/createactivity.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\CreateActivity.xaml"
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
            this.projects = ((System.Windows.Data.XmlDataProvider)(target));
            return;
            case 2:
            this.activityProject = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.activityDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.activityDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.activityDuration = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            
            #line 51 "..\..\..\View\CreateActivity.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 52 "..\..\..\View\CreateActivity.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
