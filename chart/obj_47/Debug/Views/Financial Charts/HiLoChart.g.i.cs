﻿#pragma checksum "..\..\..\..\Views\Financial Charts\HiLoChart.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F8D016CC04800402A86490D58944601E5E0CAE8135CFE57FC816B857FA5C151D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Syncfusion.SfSkinManager;
using Syncfusion.UI.Xaml.Charts;
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
using syncfusion.chartdemos.wpf;
using syncfusion.demoscommon.wpf;


namespace syncfusion.chartdemos.wpf {
    
    
    /// <summary>
    /// HiLoChartDemo
    /// </summary>
    public partial class HiLoChartDemo : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\Views\Financial Charts\HiLoChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Charts.SfChart financialChart;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\Financial Charts\HiLoChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Charts.DateTimeAxis axis1;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\Financial Charts\HiLoChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Charts.NumericalAxis axis2;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\Financial Charts\HiLoChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Charts.HiLoSeries series;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.chartdemos.wpf;component/views/financial%20charts/hilochart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Financial Charts\HiLoChart.xaml"
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
            this.financialChart = ((Syncfusion.UI.Xaml.Charts.SfChart)(target));
            return;
            case 2:
            this.axis1 = ((Syncfusion.UI.Xaml.Charts.DateTimeAxis)(target));
            return;
            case 3:
            this.axis2 = ((Syncfusion.UI.Xaml.Charts.NumericalAxis)(target));
            return;
            case 4:
            this.series = ((Syncfusion.UI.Xaml.Charts.HiLoSeries)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

