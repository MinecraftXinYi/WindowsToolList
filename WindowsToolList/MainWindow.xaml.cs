// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Scighost.WinUILib.Helpers;
using System.Diagnostics;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WindowsToolList
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private SystemBackdrop backdropHelper;
        public MainWindow()
        {
            this.InitializeComponent();
            Title = "WindowsToolList";
            ExtendsContentIntoTitleBar = true;
            SetTitleBar(AppTitleBar);
            backdropHelper = new SystemBackdrop(this);
            backdropHelper.TrySetMica();
            NavigationViewControl.SelectedItem = home;
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var selectedItem = (NavigationViewItem)args.SelectedItem;
            if ((string)selectedItem.Tag == "SamplePage1") contentFrame.Navigate(typeof(Apps));
            else if ((string)selectedItem.Tag == "SamplePage2") contentFrame.Navigate(typeof(Tool));

            else if ((string)selectedItem.Tag == "SamplePage4") contentFrame.Navigate(typeof(About));
        }

        private void Search_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            try
            {
                Process.Start(Search.Text);
            }
            catch (Exception ex)
            {
                Search.Text = "";
                ifa.IsOpen = true;
            }
            finally
            {
                Search.Text = "";
            }
        }
    }
}
