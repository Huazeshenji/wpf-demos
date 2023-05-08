#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using syncfusion.demoscommon.wpf;

namespace syncfusion.syntaxeditordemos.wpf
{
    /// <summary>
    /// Interaction logic for CustomLanguage.xaml
    /// </summary>
    public partial class CustomLanguage : DemoControl
    {
        /// <summary>
        /// Window Constructor and events initialization
        /// </summary>
        public CustomLanguage()
        {
            InitializeComponent();
           
        }

        public CustomLanguage(string themename) : base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            this.Resources.Clear();

            if (this.editControl != null)
            {
                this.editControl = null;
            }

            if (this.Mainmenu != null)
                this.Mainmenu = null;

            if (this.Toolbar != null)
                this.Toolbar = null;

            if (this.DataContext != null)
                this.DataContext = null;

            base.Dispose(disposing);
        }
    }
}
