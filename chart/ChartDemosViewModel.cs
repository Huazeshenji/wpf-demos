#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.chartdemos.wpf
{
    public class ChartDemosViewModel : DemoBrowserViewModel
    {       
        public override List<ProductDemo> GetDemosDetails()
        {
            var productdemos = new List<ProductDemo>();
            productdemos.Add(new ChartProductDemos());
            productdemos.Add(new Three_DChartProductDemos());
            productdemos.Add(new SFDateTimeRangeNavigatorDemo());
            return productdemos;
        }
    }

    public class ChartProductDemos : ProductDemo
    {
        public ChartProductDemos()
        {
            this.Product = "Charts";
            this.ProductCategory = "CHARTS";
            this.Demos = new List<DemoInfo>();

            this.Demos.Add(new DemoInfo() { SampleName = "Column", GroupName = "BASIC CHARTS", Description = "Column chart is one among the most common chart types that are being used. It uses vertical bar(s) to display different values of one or more items. Points from adjacent series are drawn as bars next to each other.", DemoViewType = typeof(ColumnChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Bar", GroupName = "BASIC CHARTS", Description = "Bar chart is the simplest and one of the most versatile statistical diagrams. It displays horizontal bar(s) for each points in the series and points from adjacent series are drawn as bars next to each other, similar to Column chart.", DemoViewType = typeof(BarChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Area", GroupName = "BASIC CHARTS", Description = "Area chart connects the Y-points using straight lines and forms an area covered by the above lines and X-axis. This area is then shaded with a specified color or gradient.", DemoViewType = typeof(AreaChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Bubble", GroupName = "BASIC CHARTS", Description = "Bubble chart is an extension of the Scatter chart (or XY-chart) where each data point is represented by a circle. But here the circle size determined based on Size property. Consequently, bubble charts allow three-variable comparisons for easy visualization of complex interdependencies that are not apparent in two-variable charts.", DemoViewType = typeof(BubbleChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Scatter", GroupName = "BASIC CHARTS", Description = "Scatter chart displays the relationships between the two set of data. It represents each data point as circle with fixed dimension.", DemoViewType = typeof(ScatterChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Line", GroupName = "BASIC CHARTS", Description = "Line chart is very simple statistical diagram and widely used chart type. They are ideal for representing time-series data and displaying trends in data at equal intervals.", DemoViewType = typeof(LineChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Spline", GroupName = "BASIC CHARTS", Description = "Spline chart is similar to line chart except that it connects the two data points using curves instead of straight lines.", DemoViewType = typeof(SplineChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Range Area", GroupName = "BASIC CHARTS", Description = "This chart is a variation of area chart type that lets you plot bands of data in a chart, like Bollinger bands, weather patterns, etc. Here each point is having two Y-values, the lower and higher end of the band.", DemoViewType = typeof(RangeAreaChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Range Column", GroupName = "BASIC CHARTS", Description = "Range Column is similar to the column chart type except that each bar(s) are rendered over a range. Therefore the user must specify the y-axis starting and ending values for each point like range area.", DemoViewType = typeof(RangeColumnChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Spline Area", GroupName = "BASIC CHARTS", Description = "Spline Area is similar to an area chart type with the only difference, being the way in which the points of a series are connected. It connects each series of points by a smooth spline curve.", DemoViewType = typeof(SplineAreaChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Spline Range Area", GroupName = "BASIC CHARTS", Description = "This chart is a variation of area chart type that lets you plot bands of data in a chart, like Bollinger bands, weather patterns, etc. Here each point is having two Y-values, the lower and higher end of the band.", DemoViewType = typeof(SplineRangeAreaChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Step Area", GroupName = "BASIC CHARTS", Description = "Step Area also comes under area type charts but it is similar to regular area chart except that instead of a straight line tracing the shortest path between points, the values are connected by continuous vertical and horizontal line(s) forming a step like progression.", DemoViewType = typeof(StepAreaChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Step Line", GroupName = "BASIC CHARTS", Description = "Step line chart uses horizontal and vertical line(s) to connect data points resulting in a step like progression.", DemoViewType = typeof(StepLineChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Pie", GroupName = "CIRCULAR CHARTS", Description = "Pie chart is ideal for the display of proportionate values expressed in either percentage or fractional formats.", DemoViewType = typeof(PieChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Doughnut", GroupName = "CIRCULAR CHARTS", Description = "Doughnut chart is like pie chart with a hole and the value is specified as the doughnut coefficient. The Doughnut Chart is best suited for presenting data in proportions.", DemoViewType = typeof(DoughnutChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Stacked Doughnut", GroupName = "CIRCULAR CHARTS", Description = " Stacked Doughnut chart is like pie chart with a hole and the value is specified as the doughnut coefficient. The Doughnut Chart is best suited for presenting data in proportions.", DemoViewType = typeof(StackedDoughnutDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "HiLo", GroupName = "FINANCIAL CHARTS", Description = "HiLo is a special kind of chart that is normally used in stock analysis. They are typically used to display error bars or the trading range of a stock for each period.", DemoViewType = typeof(HiLoChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "OHLC", GroupName = "FINANCIAL CHARTS", Description = "OHLC is a special kind of chart that is normally used in stock analysis. This chart type represents the High, Low, Open and Close values of the stock.", DemoViewType = typeof(HiLoOpenCloseChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Candle", GroupName = "FINANCIAL CHARTS", Description = "Candle displays stock information using the High, Low, Open and Close values. The high and low values are represented by the wick of a candle. The candle represents open and close values.", DemoViewType = typeof(CandleChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Polar", GroupName = "POLAR AND RADAR CHARTS", Description = "Polar chart is a circular graph on which data is displayed in terms of values and angles. X-values define the angles at which the data points will be plotted. Y-value defines the distance of the data points from the center of the graph, with the center of the graph usually starting at 0.", DemoViewType = typeof(PolarChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Radar", GroupName = "POLAR AND RADAR CHARTS", Description = "Radar chart is a circular graph on which data is displayed in terms of values and angles. X-values define the angles at which the data points will be plotted. Y-value defines the distance of the data points from the center of the graph, with the center of the graph usually starting at 0.", DemoViewType = typeof(RadarChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Column", GroupName = "STACKED CHARTS", Description = "Stacking Column is similar to regular Column charts except that the Y-values stack on top of each other in the order of the series specified. This helps visualize the relationship of parts to the whole.", DemoViewType = typeof(StackingColumnChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Bar", GroupName = "STACKED CHARTS", Description = "Stacking Bar is similar to regular bar charts except that the data points are stacked on top of each other in the specified series order. This helps visualize the relationship of parts to the whole.", DemoViewType = typeof(StackingBarChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Area", GroupName = "STACKED CHARTS", Description = "Stacked Area is similar to regular area charts except that the data points are stacked on top of each other in the order of the series specified. This helps to visualize the relationship of parts to the whole.", DemoViewType = typeof(StackingAreaChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Line", GroupName = "STACKED CHARTS", Description = "Stacked Line is similar to regular line charts except that the data points are stacked on top of each other in the order of the series specified. This helps to visualize the relationship of parts to the whole.", DemoViewType = typeof(StackingLineChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Grouping", GroupName = "STACKED CHARTS", Description = "Stacking series can be grouped based on any category to visualize the comparative relationship of parts to the whole.", DemoViewType = typeof(StackedGroupChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Column", GroupName = "100% STACKED CHARTS", Description = "100% Stacking column charts are similar to regular column charts except that the Y-values stack on top of each other in the specified series order. This helps visualize the relationship of parts to the whole in terms of percentage.", DemoViewType = typeof(StackingColumn100ChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Bar", GroupName = "100% STACKED CHARTS", Description = "100% Stacking bar charts are similar to regular bar charts except that the Y-values stack on top of each other in the specified series order. This helps visualize the relationship of parts to the whole in terms of percentage.", DemoViewType = typeof(StackingBar100ChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Area", GroupName = "100% STACKED CHARTS", Description = "100% Stacking area charts are similar to regular area charts except that the Y-values stack on top of each other in the specified series order. This helps visualize the relationship of parts to the whole in terms of percentage.", DemoViewType = typeof(StackingArea100ChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Line", GroupName = "100% STACKED CHARTS", Description = "100% Stacking line charts are similar to regular line charts except that the Y-values stack on top of each other in the specified series order. This helps visualize the relationship of parts to the whole in terms of percentage.", DemoViewType = typeof(StackingLine100Chart) });
            this.Demos.Add(new DemoInfo() { SampleName = "Funnel", GroupName = "OTHER CHARTS", Description = "Funnel chart is a single series chart representing the data as portions of 100%, and this chart does not use any axes.", DemoViewType = typeof(FunnelChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Pyramid", GroupName = "OTHER CHARTS", Description = "Pyramid chart is similar to the funnel chart. It is often used for geographical purposes. The Pyramid Chart type displays the data which when totaled will be 100%. This type of chart is a single series chart representing the data as portions of 100%, and this chart does not use any axes.", DemoViewType = typeof(PyramidChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Histogram", GroupName = "OTHER CHARTS", Description = "Histogram chart is a collection of vertical columns drawn continuously at finite intervals. Each column in the series represents the frequency of an output factor value measured during a specific finite interval.", DemoViewType = typeof(HistogramChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Box and Whisker", GroupName = "OTHER CHARTS", Description = "Box And Whisker Chart is one among the most common chart types that are being used. It uses vertical bar(s) to display mainly five ranges of dispersed values. Points from adjacent series are drawn as box rectange next to each other.", DemoViewType = typeof(BoxAndWhiskerChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Waterfall", GroupName = "OTHER CHARTS", Description = "Waterfall chart is helpful in understanding the cumulative effect of sequentially introduced positive and negative values.", DemoViewType = typeof(WaterfallChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Column", GroupName = "FAST CHARTS", Description = "Column chart type is a raster implementation of the regular column chart that has much better performance. It can be used to render large number of data points very quickly.", DemoViewType = typeof(FastColumnChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Bar", GroupName = "FAST CHARTS", Description = "Bar chart type is a raster implementation of the regular bar chart that has much better performance. It can be used to render large number of data points very quickly.", DemoViewType = typeof(FastBarChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Line", GroupName = "FAST CHARTS", Description = "Line chart type is a raster implementation of the regular Line chart that has much better performance. It can be used to render large number of data points very quickly. It is widely used chart type for high performance requirement.", DemoViewType = typeof(FastLineChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Step Line", GroupName = "FAST CHARTS", Description = "Step Line is a raster implementation of the regular step line chart with better performance. It can be used to render large number of data points very quickly.", DemoViewType = typeof(FastStepLineChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Scatter", GroupName = "FAST CHARTS", Description = "Scatter chart type is a raster implementation of the regular scatter chart that has much better performance. It can be used to render large number of data points very quickly.", DemoViewType = typeof(FastScatterChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Range Area", GroupName = "FAST CHARTS", Description = "Range area chart type is a raster implementation of the regular range area chart that has much better performance. It can be used to render large number of data points very quickly.", DemoViewType = typeof(FastRangeAreaChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Stacked Column", GroupName = "FAST CHARTS", Description = "Stacked Column is a raster implementation of the regular stacking column chart that has much better performance. It can be used to render large number of data points very quickly.", DemoViewType = typeof(FastStackingColumnChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "HiLo", GroupName = "FAST CHARTS", Description = "HiLo chart type is a raster implementation of the regular HiLo chart that has much better performance. It can be used to render large number of data points very quickly.", DemoViewType = typeof(FastHiloChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "OHLC", GroupName = "FAST CHARTS", Description = "OHLC is a raster implementation of the regular financial chart with high, low, open and close values with better performance. It can be used to render large number of data points very quickly.", DemoViewType = typeof(FastHiloOpenCloseChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Candle", GroupName = "FAST CHARTS", Description = "Candle chart is a raster implementation of the regular candle chart that has much better performance. It can be used to render large number of data points very quickly.", DemoViewType = typeof(FastCandleChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Series Template", GroupName = "SERIES CUSTOMIZATION", Description = "The default template of the series can be customized to any other shape using CustomTemplate property.", DemoViewType = typeof(CustomSeriesDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Empty Values", GroupName = "SERIES CUSTOMIZATION", Description = "Empty values are unavoidable with real time values and we can handle these values (double.NaN) in SfChart. This sample demonstrates handlings of empty points in the chart.", DemoViewType = typeof(EmptyPointSupportDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Axis Type", GroupName = "AXIS", Description = "Axis type helps plotting data in different scale.", DemoViewType = typeof(AxisDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Axis Customization", GroupName = "AXIS", Description = "This sample demonstrates SfChart axis and its customization options.", DemoViewType = typeof(AxisConfigurationDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Labels Intersection", GroupName = "AXIS", Description = "This sample demonstrates axis label positionings when the labels are intersected.", DemoViewType = typeof(LabelsIntersectionDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Flexible Axis", GroupName = "AXIS", Description = "This sample demonstrates how to make flexible axis layout and share with multiple series.", DemoViewType = typeof(FlexibleAxisDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Auto Scrolling", GroupName = "AXIS", ShowBusyIndicator = false, Description = "This sample demonstrates the automatic scrolling of axis during real time update.", DemoViewType = typeof(ChartAutoScrollingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "ScaleBreak", GroupName = "AXIS",Description = "This sample demonstrates scale breaks in SfChart.", DemoViewType = typeof(ScaleBreakDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Multi Level Labels", GroupName = "AXIS", Description = "This sample demonstrates multi level labels support for chart axis.", DemoViewType = typeof(MultiLevelLabelsDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "MVVM Pattern", GroupName = "DATA BINDING", Description = "This sample demonstrates the data binding of chart in MVVM pattern.", DemoViewType = typeof(MVVMBindingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "DataTable Binding", GroupName = "DATA BINDING", Description = "This sample demonstrates the data binding of chart with the DataTable.", DemoViewType = typeof(DataTableBindingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Chart Grid Binding", GroupName = "DATA BINDING", Description = "This sample demonstrates the binding of data between SfChart and SfDataGrid.", DemoViewType = typeof(ChartDataEditingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Data Editing", GroupName = "DATA EDITING", Description = "Visual Data Editing allows you to edit an entire series or a single data point dynamically by interacting directly with the chart series, by dragging.", DemoViewType = typeof(VisualDataEditingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Scatter Data Editing", GroupName = "DATA EDITING", Description = "Scatter Series Data Editing allows you to edit a single data point dynamically by interacting directly with the chart series, by dragging in x and y co-ordinates.", DemoViewType = typeof(ScatterDataEditingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Tooltip", GroupName = "ANNOTATIONS", Description = "This sample demonstrates the tooltip usage in annotations.", DemoViewType = typeof(AnnotationToolTip) });
            this.Demos.Add(new DemoInfo() { SampleName = "Interactivity", GroupName = "ANNOTATIONS", Description = "This sample demonstrates how the user can interact with the annotations by resizing and dragging the annotation to different points at run time.", DemoViewType = typeof(AnnotationInteractionDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Vertical Chart", GroupName = "VERTICAL CHART", ShowBusyIndicator = false, Description = "Vertical chart is like normal chart except that the axis and series area are rotated to 90 degree.", DemoViewType = typeof(VerticalChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Strip Lines", GroupName = "STRIP LINES", Description = "Striplines are used to highlight data and are drawn at the background of a chart. They can be horizontal or vertical, and also be made to optionally repeat at specific intervals (for example, to indicate weekends every seven days).", DemoViewType = typeof(StripLineDemo) });
            //this.Demos.Add(new DemoInfo() { SampleName = "Palettes", GroupName = "PALETTES", Description = "This sample demonstrates how to apply color palettes for the chart series.", DemoViewType = typeof(Palettes) });
            this.Demos.Add(new DemoInfo() { SampleName = "Multi Legends", GroupName = "LEGENDS", Description = "This sample demonstrates how to add multiple legends in the chart and its functionalities.", DemoViewType = typeof(MultipleLegendsDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Multiple Series", GroupName = "PERFORMANCE", Description = "This sample illustrates the performance of SfChart when multiple series are used. SfChart has been designed to handle loading large number of series without loss in performance.", DemoViewType = typeof(MultipleSeriesDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Real Time Chart", GroupName = "REAL TIME CHART", ShowBusyIndicator = false, Description = "This sample illustrates the performance of SfChart in real time update scenario.", DemoViewType = typeof(RealTimeChartDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Serialization", GroupName = "SERIALIZATION", Description = "This sample demonstrates how to serialize and deserialize the SfChart.", DemoViewType = typeof(Serialization) });
            this.Demos.Add(new DemoInfo() { SampleName = "Tooltip", GroupName = "CHART INTERACTIVITY", Description = "ToolTip feature allows you to display any information over a chart series like a metadata. It appears when the mouse hovers any chart segment.", DemoViewType = typeof(CustomTooltip) });
            this.Demos.Add(new DemoInfo() { SampleName = "Trackball", GroupName = "CHART INTERACTIVITY", Description = "Trackball enables you to track a data point closer to the touch position or touch contact point. It consists of only one vertical line moving along the Primary axis and the series. X-values are determined from the position of the vertical line in the axis and Y-values are determined from the tooltip.", DemoViewType = typeof(TrackBall) });
            this.Demos.Add(new DemoInfo() { SampleName = "Crosshair", GroupName = "CHART INTERACTIVITY", Description = "Crosshair is used to view the values at the current mouse point. It consists of two lines; a horizontal line and a vertical line, perpendicular to each other, fixed at a point.", DemoViewType = typeof(CrossHairBehavior) });
            this.Demos.Add(new DemoInfo() { SampleName = "Selection", GroupName = "CHART INTERACTIVITY", Description = "Selection allows you to select either a data point or series. This behavior highlights the particular segment of the series or a series based on the segment or series selection.", DemoViewType = typeof(SelectionBehavior) });
            this.Demos.Add(new DemoInfo() { SampleName = "Zoom and Pan", GroupName = "CHART INTERACTIVITY", Description = "Zooming and panning features allow you to take a closer look at the data point plotted in the series. We can also zoom by using the zooming toolkit.", DemoViewType = typeof(ZoomPanBehavior) });
            this.Demos.Add(new DemoInfo() { SampleName = "Error Bars", GroupName = "LINE STUDIES", Description = "Error bar is a graphical representation used to indicate the errors or uncertainty in the reported values. It is used to find possible variations in measurements.", DemoViewType = typeof(ErrorBarSeriesDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Trendline", GroupName = "LINE STUDIES", Description = "Trend lines are used to analyze and display the trends in the data graphically. It is built on the assumptions based on current and past price trends. This analysis is also called as regression analysis.", DemoViewType = typeof(TrendlineDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Technical Indicator", GroupName = "LINE STUDIES", Description = "Technical indicators are the base for technical analysis, which is used to determine the future of financial, stock or economic trends.", DemoViewType = typeof(Indicator) });
            this.Demos.Add(new DemoInfo() { SampleName = "Export and Print", GroupName = "EXPORTING", Description = "This sample demonstrates the exporting and printing support in SfChart. Chart can be exported to bitmap image.", DemoViewType = typeof(ExportChartDemo) });
            
        }
    }

    public class Three_DChartProductDemos : ProductDemo
    {
        public Three_DChartProductDemos()
        {
            this.Product = "3D-Charts";
            this.ProductCategory = "CHARTS";
            this.Demos = new List<DemoInfo>();

            this.Demos.Add(new DemoInfo() { SampleName = "Column", GroupName = "BASIC CHARTS 3D", Description = "Column is among the most common chart types that is being used. It uses vertical bars (called columns) to display different values of one or more items. It is similar to a bar chart and the points from adjacent series are drawn as bars next to each other.", DemoViewType = typeof(ColumnChart3D) });
            this.Demos.Add(new DemoInfo() { SampleName = "Bar", GroupName = "BASIC CHARTS 3D", Description = "Bar displays horizontal bars (rectangles) for each point in the series and the points from adjacent series are drawn as bars next to each other.", DemoViewType = typeof(BarChart3D) });
            this.Demos.Add(new DemoInfo() { SampleName = "Area", GroupName = "BASIC CHARTS 3D", Description = "Area is the simplest and most versatile of statistical diagrams. It displays area for each point in the series and points from adjacent series are covered by area series.", DemoViewType = typeof(AreaSeriesChart3DDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Line", GroupName = "BASIC CHARTS 3D", Description = "Line is also the simplest and widely used statistical diagrams. It displays line for each point in the series and the points from adjacent series are drawn as lines.", DemoViewType = typeof(LineSeriesChart3D) });
            this.Demos.Add(new DemoInfo() { SampleName = "Scatter", GroupName = "BASIC CHARTS 3D", Description = "Scatter displays cube for each data points in the series.", DemoViewType = typeof(ScatterSeriesChart3D) });
            this.Demos.Add(new DemoInfo() { SampleName = "Column", GroupName = "STACKED CHARTS 3D", Description = "Column is similar to Bar charts except that the adjacent series are stacked on top of another chart.", DemoViewType = typeof(StackingColumnChart3D) });
            this.Demos.Add(new DemoInfo() { SampleName = "Bar", GroupName = "STACKED CHARTS 3D", Description = "Bar displays horizontal bars for each point in the series and points from adjacent series are drawn as bars next to each other similar to bar charts. Here the adjacent series are stacked on top of each other.", DemoViewType = typeof(StackingBarChart3D) });
            this.Demos.Add(new DemoInfo() { SampleName = "Column", GroupName = "STACKED CHARTS 3D 100%", Description = "Column is similar to Stacked Column but this is used to visualize the relationship of parts to the whole in terms of percentage.", DemoViewType = typeof(StackingColumn100Chart3D) });
            this.Demos.Add(new DemoInfo() { SampleName = "Bar", GroupName = "STACKED CHARTS 3D 100%", Description = "Bar is similar to Stacked Bar but this is used to visualize the relationship of parts to the whole in terms of percentage.", DemoViewType = typeof(StackingBar100Chart3D) });
            this.Demos.Add(new DemoInfo() { SampleName = "Depth Axis", GroupName = "DEPTH AXIS", Description = "This sample illustrates the various 3D Chart types with X, Y and Z Axis.", DemoViewType = typeof(DepthAxis) });
            this.Demos.Add(new DemoInfo() { SampleName = "Pie", GroupName = "CIRCULAR CHARTS 3D", Description = "Pie is an ideal for the display of proportionate values expressed in either percentage or fractional formats.", DemoViewType = typeof(PieChart3D) });
            this.Demos.Add(new DemoInfo() { SampleName = "Doughnut", GroupName = "CIRCULAR CHARTS 3D", Description = "Doughnut is like pie chart with a hole and the value is specified as the doughnut coefficient. The Doughnut Chart is best suited for presenting data in proportions.", DemoViewType = typeof(DoughnutChart3D) });
            this.Demos.Add(new DemoInfo() { SampleName = "Semi Pie and Doughnut", GroupName = "CIRCULAR CHARTS 3D", Description = "Pie and Doughnut charts can be customized to semicircular shape or any other angles using Start Angle and End Angle.", DemoViewType = typeof(SemiPieAndDoughnutSeries3D) });
        }
    }

    public class SFDateTimeRangeNavigatorDemo : ProductDemo
    {
        public SFDateTimeRangeNavigatorDemo()
        {
            this.Product = "Range Navigator";
            this.ProductCategory = "CHARTS";
            this.Demos = new List<DemoInfo>();
            this.Demos.Add(new DemoInfo() { SampleName = "Getting Started", GroupName = "DATETIME RANGE NAVIGATOR", Description = "This Sample demonstrate Range Navigator with chart Zooming.", DemoViewType = typeof(GettingStartedDemo) });
        }
    }

}
