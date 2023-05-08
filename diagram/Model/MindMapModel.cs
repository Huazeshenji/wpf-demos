#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.Diagram.Layout;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.diagramdemo.wpf.Model
{
    public class MindmapEmployee
    {
        public string EmpId { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public RootChildDirection Direction { get; set; }
    }

    public class MindmapEmployees : ObservableCollection<MindmapEmployee>
    {

    }
}
