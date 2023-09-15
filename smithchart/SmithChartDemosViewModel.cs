#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace syncfusion.smithchartdemos.wpf
{
    public class SmithChartDemosViewModel : DemoBrowserViewModel
    {
        public override List<ProductDemo> GetDemosDetails()
        {
            var productdemos = new List<ProductDemo>();
            productdemos.Add(new SmithChartProductDemos());
            return productdemos;
        }
    }

    public class SmithChartProductDemos : ProductDemo
    {
        public SmithChartProductDemos()
        {
            this.Product = "Smith Chart";
            this.ProductCategory = "CHARTS";
            this.ListViewImagePathData = new System.Windows.Shapes.Path()
            {
                Data = Geometry.Parse("M6.90179 1.15763C6.38226 0.990413 5.82676 0.899897 5.2495 0.899897C2.38131 0.899897 0.0502868 3.13452 5.43594e-05 5.90965C0.049118 2.63747 2.71645 0 5.99968 0C6.52833 0 7.04101 0.0683787 7.52937 0.196775C7.39778 0.492989 7.18428 0.816271 6.90179 1.15763ZM10.9729 3.8087C10.7619 3.95787 10.4948 4.10269 10.1789 4.24116C9.73285 3.06205 8.85143 2.08731 7.72396 1.50085C7.98585 1.1606 8.20015 0.816079 8.34232 0.474611C9.68129 1.04308 10.7712 2.0841 11.4029 3.38845C11.324 3.51518 11.187 3.65733 10.9729 3.8087ZM10.3562 9.63238C10.149 9.38075 9.87531 9.13957 9.56277 8.91048C10.1535 8.08527 10.4998 7.0825 10.4998 6.00114C10.4998 5.68418 10.47 5.37396 10.4131 5.073C10.8101 4.90583 11.1699 4.71862 11.4673 4.50836C11.5667 4.43808 11.6619 4.36329 11.7506 4.28366C11.9129 4.82788 12 5.40449 12 6.00146C12 7.49399 11.4553 8.85926 10.5538 9.90924C10.4954 9.81246 10.4284 9.72003 10.3562 9.63238ZM5.47371 11.0978C5.63365 11.4335 5.74654 11.7377 5.8105 12C2.61335 11.901 0.0461984 9.30037 0 6.08957C0.0485756 8.86612 2.38026 11.1024 5.2495 11.1024C5.32462 11.1024 5.39937 11.1009 5.47371 11.0978ZM6.67923 11.9649C6.61922 11.6527 6.50839 11.322 6.36417 10.9872C7.3878 10.7722 8.30031 10.2671 9.00602 9.56499C9.3064 9.78059 9.53802 9.98646 9.69511 10.1772C9.82273 10.3321 9.88501 10.4571 9.90962 10.554C9.021 11.3182 7.90613 11.8265 6.67923 11.9649ZM8.26171 9.09115C7.642 9.65614 6.85095 10.0499 5.96663 10.1896C5.87386 10.0241 5.77441 9.8572 5.66935 9.69012C6.32386 9.47287 6.90244 9.09858 7.35655 8.61401C7.67734 8.77053 7.98155 8.93012 8.26171 9.09115ZM9.59547 5.37521C9.62691 5.57975 9.64318 5.78878 9.64318 6.00114C9.64318 6.90418 9.34895 7.74707 8.84513 8.4399C8.54444 8.26104 8.21912 8.08594 7.87849 7.91615C8.21008 7.35045 8.3993 6.69707 8.3993 6.00112C8.3993 5.90495 8.39569 5.80959 8.38858 5.71516C8.80868 5.61274 9.21475 5.49954 9.59547 5.37521ZM7.14655 2.17076C8.17906 2.6489 8.98313 3.50473 9.377 4.54519C9.01914 4.6637 8.63235 4.77288 8.22723 4.8726C7.95 3.98763 7.35516 3.23533 6.57036 2.73864C6.76271 2.56018 6.94644 2.38027 7.11873 2.19997L7.14655 2.17076ZM5.8921 3.33418C6.59859 3.70682 7.13566 4.32654 7.38652 5.06122C7.17809 5.10382 6.96697 5.14412 6.75443 5.1821C6.56832 5.21535 6.38155 5.24674 6.195 5.27628C6.03072 4.7162 5.68073 4.22937 5.21184 3.87909L5.23519 3.86107C5.45791 3.68903 5.6779 3.51301 5.8921 3.33418ZM7.54108 5.9041C7.33019 5.94705 7.11775 5.98751 6.90506 6.02551C6.70231 6.06174 6.49885 6.09581 6.29574 6.12775C6.27888 6.47378 6.1933 6.80282 6.05163 7.10287C6.22249 7.17162 6.39281 7.24184 6.56172 7.31337C6.74213 7.38978 6.92162 7.46796 7.09906 7.54774C7.38177 7.09139 7.5427 6.56109 7.5427 6.00112C7.5427 5.96868 7.54216 5.93634 7.54108 5.9041ZM6.22772 8.10233C6.32732 8.14451 6.42624 8.18708 6.52432 8.23002C6.14741 8.56546 5.68403 8.81583 5.16561 8.94558C5.03274 8.76202 4.89494 8.58048 4.75372 8.40266C5.05437 8.25567 5.32387 8.05947 5.55036 7.82531C5.77701 7.9149 6.00351 8.00737 6.22772 8.10233ZM4.16548 9.04042C4.12261 8.98542 4.07931 8.93067 4.03562 8.87625C3.9806 8.8077 3.92507 8.73978 3.86912 8.67259C3.73191 8.69181 3.59152 8.70177 3.44867 8.70177C3.18742 8.70177 2.93439 8.66846 2.69403 8.60609C3.12512 8.85592 3.62518 9.01153 4.16548 9.04042ZM4.64007 7.48037C4.50004 7.57763 4.34501 7.65846 4.17771 7.7191C3.99185 7.51133 3.80267 7.31172 3.61289 7.12366C3.94291 7.23302 4.2881 7.35244 4.64007 7.48037ZM5.24821 6.79146C5.33515 6.62255 5.39496 6.44092 5.42335 6.2525C4.97889 6.30987 4.54375 6.35676 4.12962 6.39326C4.49198 6.51605 4.86806 6.64941 5.24821 6.79146ZM4.48117 4.42226C4.88001 4.64682 5.18063 4.99621 5.33231 5.40038C4.65666 5.488 4.00276 5.55074 3.41508 5.58892C3.15355 5.60592 2.908 5.61784 2.68151 5.62506C3.24496 5.27422 3.8641 4.86557 4.48117 4.42226ZM4.36763 3.4439C4.48299 3.35793 4.59779 3.2709 4.7116 3.18299C4.78683 3.12487 4.86154 3.06644 4.93562 3.00774C4.746 2.97441 4.55002 2.95694 4.34909 2.95694C3.73847 2.95694 3.17364 3.11823 2.69414 3.3961C2.93446 3.33374 3.18746 3.30045 3.44867 3.30045C3.7702 3.30045 4.0793 3.3509 4.36763 3.4439ZM6.24486 1.86559C6.08483 2.0224 5.91559 2.17948 5.73914 2.33598C5.30562 2.18342 4.83745 2.10017 4.34909 2.10017C3.92667 2.10017 3.51935 2.16246 3.1365 2.27801C3.7613 1.94618 4.48045 1.75666 5.2495 1.75666C5.59253 1.75666 5.92563 1.79437 6.24486 1.86559ZM3.36311 4.15884C2.74249 4.58164 2.14026 4.95967 1.62167 5.26643C1.91246 4.65015 2.55913 4.18949 3.36311 4.15884ZM2.41833 7.18962C2.09525 6.91829 1.80488 6.7183 1.56031 6.5891C1.78595 7.20474 2.35644 7.69571 3.09407 7.81645C2.8664 7.58624 2.63915 7.37507 2.41833 7.18962ZM5.00197 10.239C4.92879 10.1202 4.85218 10.0006 4.77256 9.88101C4.63338 9.89494 4.4921 9.90207 4.34909 9.90207C3.92662 9.90207 3.51925 9.83978 3.13636 9.72419C3.69367 10.0202 4.32605 10.203 5.00197 10.239Z"),
                Width = 12,
                Height = 12,
            };
            this.Demos = new List<DemoInfo>();
            this.HeaderImageSource = new BitmapImage(new Uri(@"/syncfusion.demoscommon.wpf;component/Assets/ProductCategoryImages/Charts.png", UriKind.RelativeOrAbsolute));
            this.ControlDescription = "The Smith chart is one of the most useful data visualization tools for high frequency circuit applications. Users can display and analyze complex impedance data.";
            this.GalleryViewImageSource = new BitmapImage(new Uri(@"/syncfusion.demoscommon.wpf;component/Assets/GalleryViewImages/Smith Chart.png", UriKind.RelativeOrAbsolute));

            DemoInfo GettingStartedDemo = new DemoInfo()
            {
                SampleName = "Getting Started",

                GroupName = "SMITH CHART",

                Description = "This sample demonstrates the basic features in SmithChart.",

                DemoViewType = typeof(GettingStarted),

            };

            List<Documentation> GettingStartedHelpDocuments = new List<Documentation>()
            {
                new Documentation(){ Content = "Smith Chart - Getting Started", Uri = new Uri("https://help.syncfusion.com/wpf/smith-chart/getting-started")}
            };

            GettingStartedDemo.Documentations = GettingStartedHelpDocuments;
            this.Demos.Add(GettingStartedDemo);
            this.Demos.Add(new DemoInfo() { SampleName = "Customization", GroupName = "SMITH CHART", DemoViewType = typeof(Customization), Description = "This sample demonstrates the customization of SmithChart features" });
        }
    }
}
