#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
#if !NET8_0
using System.Runtime.Serialization.Formatters.Binary;
#endif
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace syncfusion.layoutdemos.wpf
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class DocumentContainerDemosView : DemoControl
    {
        private TextBlock textBlock;
        private Button binSaveButton;
        private Button binLoadButton;
        /// <summary>
        /// String for Displaying in the MessageBox.
        /// </summary>
        private const string AttentionHeader = "Attention!";
    
        #region constructor
        /// <summary>
        /// Contructor for DocumentContainerDemosView.
        /// </summary>
        public DocumentContainerDemosView()
        {
            InitializeComponent();
            UpdateGroupbarVisibility();
#if NET50
            BinFormatterRadio.IsChecked = true;
            BinFormatterRadio.Visibility = Visibility.Collapsed;
#endif
        }

        public DocumentContainerDemosView(string themename) : base(themename)
        {
            InitializeComponent();
            UpdateGroupbarVisibility();
#if NET50
            BinFormatterRadio.IsChecked = true;
            BinFormatterRadio.Visibility = Visibility.Collapsed;
#endif
#if !NET8_0
            textBlock = new TextBlock
            {
                Height = 24,
                FontSize = 12,
                Text = "BIN"
            };
            Grid.SetRow(textBlock, 0);
            Grid.SetColumn(textBlock, 0);
            DocSaveAndLoad.Children.Add(textBlock);

            binSaveButton = new Button
            {
                Name = "Binsave",
                Height = 24,
                Margin = new Thickness(3),
                Content = "Save"
            };
            Grid.SetRow(binSaveButton, 0);
            Grid.SetColumn(binSaveButton, 1);
            binSaveButton.Click += OnSaveToBinStateClick;
            DocSaveAndLoad.Children.Add(binSaveButton);

            binLoadButton = new Button
            {
                Name = "Binload",
                Height = 24,
                Margin = new Thickness(3),
                Content = "Load",
                IsEnabled = false
            };
            Grid.SetRow(binLoadButton, 0);
            Grid.SetColumn(binLoadButton, 2);
            binLoadButton.Click += OnLoadFromBinStateClick;
            DocSaveAndLoad.Children.Add(binLoadButton);
#endif
        }
    
        #endregion

        #region Helper Methods  

        private void UpdateGroupbarVisibility()
        {
            if (DocContainer != null)
            {
                if (DocContainer.Mode == DocumentContainerMode.TDI)
                {
                    TablistContextMenu.IsEnabled = true;
                    TabItemContextMenu.IsEnabled = true;
                    Cascade.IsEnabled = false;
                    THorizontal.IsEnabled = false;
                    TVertical.IsEnabled = false;
                }
                else if (DocContainer.Mode == DocumentContainerMode.MDI)
                {
                    TablistContextMenu.IsEnabled = false;
                    TabItemContextMenu.IsEnabled = false;
                    Cascade.IsEnabled = true;
                    THorizontal.IsEnabled = true;
                    TVertical.IsEnabled = true;
                }
            }
        }
        /// <summary>
        /// Method used for changing the TDI/MDI modes in runtime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>    
        private void mode_Click(object sender, RoutedEventArgs e)
        {
            //Changing DocumentContianer Mode
            RadioButton c = (RadioButton)sender;
            string g = c.Content.ToString();
            if (DocContainer != null)
            {
                if (g.StartsWith("MDI"))
                {
                    DocContainer.Mode = DocumentContainerMode.MDI;
                    TDI.IsChecked = false;
                    MDI.IsChecked = true;
                    UpdateGroupbarVisibility();

                }
                else if (g.StartsWith("TDI"))
                {
                    DocContainer.Mode = DocumentContainerMode.TDI;

                    TDI.IsChecked = true;
                    MDI.IsChecked = false;
                    UpdateGroupbarVisibility();

                }
            }
        }
        /// <summary>
        /// Method used for changing the Layout for the MDI elements.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void Layout_Click(object sender, RoutedEventArgs e)
        {
            //Changing Document Containter Layout
            Button c = (Button)sender;
            string g = c.Content.ToString();
            switch (c.Name)
            {
                case "Cascade":
                    DocContainer.SetLayout(MDILayout.Cascade);
                    DocumentContainer.SetCanDrag(firstdoc, true);
                    DocumentContainer.SetCanDrag(seconddoc, true);
                    DocumentContainer.SetCanDrag(ThirdDoc, true);
                    break;
                case "THorizontal":
                    DocContainer.SetLayout(MDILayout.Horizontal);
                    DocumentContainer.SetCanDrag(firstdoc, false);
                    DocumentContainer.SetCanDrag(seconddoc, false);
                    DocumentContainer.SetCanDrag(ThirdDoc, false);
                    break;
                case "TVertical":
                    DocContainer.SetLayout(MDILayout.Vertical);
                    DocumentContainer.SetCanDrag(firstdoc, false);
                    DocumentContainer.SetCanDrag(seconddoc, false);
                    DocumentContainer.SetCanDrag(ThirdDoc, false);
                    break;
            }
        }
        /// <summary>
        /// Method used for saving the states to Registry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  

        private void OnSaveToRegStateClick(object sender, RoutedEventArgs e)
        {
            Load1.IsEnabled = true;
            //Save State
#if !NET8_0
            BinaryFormatter formatter1 = new BinaryFormatter();
            DocContainer.SaveDockState(formatter1);
#else
            using (XmlWriter writer = XmlWriter.Create("SaveAndLoadToReg.xml"))
            {
                DocContainer.SaveDockState();
                writer.Close();
            }
#endif
        }

        /// <summary>
        /// Method used for Load the states from Registry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  

        private void OnLoadFromRegStateClick(object sender, RoutedEventArgs e)
        {
            //Load State
#if !NET8_0
            BinaryFormatter formatter1 = new BinaryFormatter();

            try
            {
                DocContainer.LoadDockState(formatter1);
            }
#else
            try
            {
                using (XmlReader reader = XmlReader.Create("SaveAndLoadToReg.xml"))
                {
                    DocContainer.LoadDockState();
                    reader.Close();
                }
            }
#endif
            catch (SerializationException ex)
            {
                MessageBox.Show(ex.Message, AttentionHeader, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, AttentionHeader, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        /// <summary>
        /// Method used for saving the states to IS.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void OnSaveStateToIsoStorageClick(object sender, RoutedEventArgs e)
        {
            Isload.IsEnabled = true;
            //Save State to Isolated Storage
            DocContainer.SaveDockState();
        }
        /// <summary>
        /// Method used for Load the states from IS.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void OnLoadStateFromIsoStorageClick(object sender, RoutedEventArgs e)
        {
            //Load State from Isolated Storage
            DocContainer.LoadDockState();
        }
        /// <summary>
        /// Method used for reset the states from IS.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void OnResetStateInIsoStorageClick(object sender, RoutedEventArgs e)
        {
            //Delete Internal Isolated Storage
            DocContainer.DeleteInternalIsolatedStorage();
        }
        /// <summary>
        /// Method used for saving the states to XML.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void OnSaveToXMLStateClick(object sender, RoutedEventArgs e)
        {
            //Save to XML sate
            if (BinFormatterRadio.IsChecked == true)
            {
                xmlload.IsEnabled = true;
#if !NET8_0
                BinaryFormatter formatter1 = new BinaryFormatter();
                DocContainer.SaveDockState(formatter1, StorageFormat.Xml,
                    AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\docum_xml.xml");
#else
                using (XmlWriter writer = XmlWriter.Create("\\docum_xml.xml"))
                {
                    DocContainer.SaveDockState(writer);
                    writer.Close();
                }
#endif
            }
        }
        /// <summary>
        /// Method used for Load the states from XML.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void OnLoadFromXMLStateClick(object sender, RoutedEventArgs e)
        {
            //Load from XML State
            if (BinFormatterRadio.IsChecked == true)
            {
#if !NET8_0
                BinaryFormatter formatter1 = new BinaryFormatter();

                try
                {
                    DocContainer.LoadDockState(formatter1, StorageFormat.Xml,
                        AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\docum_xml.xml");
                }
#else
                try
                {
                    XmlTextReader reader = new XmlTextReader("\\docum_xml.xml");
                    DocContainer.LoadDockState(reader);
                    reader.Close();

                }
#endif
                catch (XmlException ex)
                {
                    MessageBox.Show(ex.Message, AttentionHeader, MessageBoxButton.OK,
                                                                 MessageBoxImage.Warning);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, AttentionHeader, MessageBoxButton.OK,
                                                                 MessageBoxImage.Warning);
                }
            }
        }
#if !NET8_0
        /// <summary>
        /// Method used for saving the states to Binary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void OnSaveToBinStateClick(object sender, RoutedEventArgs e)
        {
            //Save to Binary State   
            if (BinFormatterRadio.IsChecked == true)
            {
                IsEnabled = true;
                BinaryFormatter formatter1 = new BinaryFormatter();
                DocContainer.SaveDockState(formatter1, StorageFormat.Binary,
                    AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\docum_bin.bin");
            }
        }
        /// <summary>
        /// Method used for Load the states from Binary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void OnLoadFromBinStateClick(object sender, RoutedEventArgs e)
        {
            //Load from Binary State
            if (BinFormatterRadio.IsChecked == true)
            {
                BinaryFormatter formatter1 = new BinaryFormatter();
                try
                {
                    DocContainer.LoadDockState(formatter1, StorageFormat.Binary,
                        AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\docum_bin.bin");
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message, AttentionHeader, MessageBoxButton.OK,
                                                                 MessageBoxImage.Warning);
                }
                catch (XmlException ex)
                {
                    MessageBox.Show(ex.Message, AttentionHeader, MessageBoxButton.OK,
                                                                 MessageBoxImage.Warning);
                }
            }
        }
#endif
        /// <summary>
        /// Method used for Reset the States.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void OnResetStateClick(object sender, RoutedEventArgs e)
        {
            //Reset State
            DocContainer.ResetState();
        }
        /// <summary>
        /// Method used for Deleting the states.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void deletestate_Click(object sender, RoutedEventArgs e)
        {
            //Delete Dock State
            DocContainer.DeleteDockState(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\docum_xml.xml");
            DocContainer.DeleteDockState(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\docum_bin.bin");
            DocContainer.DeleteDockState();
        }
        /// <summary>
        /// Method used to change the different window switchers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void windowswitchers_Click(object sender, RoutedEventArgs e)
        {
            //Changing SwitchMode
            RadioButton mi = (RadioButton)e.OriginalSource;
            string g = mi.Content.ToString();

            for (int i = 0; i < WindowSwitchers.Children.Count; i++)
            {
                RadioButton mitem = (RadioButton)WindowSwitchers.Children[i];
                if (mitem.Content.ToString().Equals(g))
                    mitem.IsChecked = true;
                else
                    mitem.IsChecked = false;
            }
            if (g.StartsWith("Immediate"))
                DocContainer.SwitchMode = SwitchMode.Immediate;
            else if (g.StartsWith("List"))
                DocContainer.SwitchMode = SwitchMode.List;
            else if (g.StartsWith("QuickTabs"))
                DocContainer.SwitchMode = SwitchMode.QuickTabs;
            else if (g.StartsWith("VS2005"))
                DocContainer.SwitchMode = SwitchMode.VS2005;
            else if (g.StartsWith("VistaFlip"))
            {
                DocContainer.SwitchMode = SwitchMode.VistaFlip;
            }
        }
        /// <summary>
        /// Method used to close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void Close_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
#endregion

        protected override void Dispose(bool disposing)
        {
            if (this.DocContainer != null)
            {
                this.DocContainer.Dispose();
                this.DocContainer = null;
            }

            if (this.firstdoc != null)
            {
                this.firstdoc = null;
            }

            if (this.seconddoc != null)
            {
                this.seconddoc = null;
            }

            if (this.ThirdDoc != null)
            {
                this.ThirdDoc = null;
            }

            base.Dispose(disposing);
        }
    }
}