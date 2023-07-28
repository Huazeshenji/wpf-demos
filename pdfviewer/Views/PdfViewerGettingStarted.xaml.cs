#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class PdfViewerGettingStarted : DemoControl
    {
        #region Constructor
        public PdfViewerGettingStarted()
        {
            InitializeComponent();
        }
        #endregion
        public PdfViewerGettingStarted(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            pdfviewer1.Unload(true);
            pdfviewer1 = null;
            if(this.DataContext is PdfViewerGettingStartedViewModel)
            {
                PdfViewerGettingStartedViewModel gettingStartedDataContext = this.DataContext as PdfViewerGettingStartedViewModel;
                gettingStartedDataContext.DocumentStream.Dispose();
                gettingStartedDataContext.DocumentCollection.Clear();
                gettingStartedDataContext.SelectedDocument = null;
                this.DataContext = null;
            }
            base.Dispose(disposing);
        }
    }
}
