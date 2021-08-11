#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using syncfusion.demoscommon.wpf;

namespace syncfusion.schedulerdemos.wpf
{
    /// <summary>
    /// Interaction logic for TimelineViews.xaml
    /// </summary>
    public partial class TimelineViewsDemo : DemoControl
    {
        public TimelineViewsDemo()
        {
            InitializeComponent();
        }
        public TimelineViewsDemo(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            if (this.Schedule != null)
            {
                this.Schedule.Dispose();
                this.Schedule = null;
            }
            base.Dispose(disposing);
        }
    }
}
