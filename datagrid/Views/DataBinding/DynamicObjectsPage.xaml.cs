#region Copyright Syncfusion Inc. 2001-2022
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace syncfusion.datagriddemos.wpf
{
    /// <summary>
    /// Interaction logic for DynamicObjectsPage.xaml
    /// </summary>
    public partial class DynamicObjectsPage : Page
    {
        public DynamicObjectsPage()
        {
            InitializeComponent();
            this.Unloaded += DynamicObjectsPage_Unloaded;
        }

        private void DynamicObjectsPage_Unloaded(object sender, RoutedEventArgs e)
        {
            if(this.syncgrid != null)
            {
                this.syncgrid.Dispose();
                this.syncgrid = null;
            }

            this.Unloaded -= DynamicObjectsPage_Unloaded;
        }
    }
}
