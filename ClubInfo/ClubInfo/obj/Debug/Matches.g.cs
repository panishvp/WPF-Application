﻿#pragma checksum "..\..\Matches.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E002BCEAAF595EA0BAD1A2DCCF577684A3D0D522"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ClubInfo;
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


namespace ClubInfo {
    
    
    /// <summary>
    /// Matches
    /// </summary>
    public partial class Matches : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\Matches.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cmbx_Year;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Matches.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cmbx_location;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Matches.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Grd_matches;
        
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
            System.Uri resourceLocater = new System.Uri("/ClubInfo;component/matches.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Matches.xaml"
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
            
            #line 8 "..\..\Matches.xaml"
            ((ClubInfo.Matches)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 10 "..\..\Matches.xaml"
            ((ClubInfo.Matches)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Cmbx_Year = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\Matches.xaml"
            this.Cmbx_Year.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Cmbx_Year_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Cmbx_location = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\Matches.xaml"
            this.Cmbx_location.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Cmbx_location_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Grd_matches = ((System.Windows.Controls.DataGrid)(target));
            
            #line 40 "..\..\Matches.xaml"
            this.Grd_matches.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Grd_Match_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

