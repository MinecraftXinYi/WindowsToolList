// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WindowsToolList
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Apps : Page
    {
        public Apps()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe");
        }
        static async void OpenCLSID(string edge)
        {

            Uri uri = new Uri(edge);

            await Launcher.LaunchUriAsync(uri);
        }
        static async void Openweb()
        {

            Uri uri = new Uri("https://microharddemo.github.io");

            await Launcher.LaunchUriAsync(uri);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenCLSID("ms-settings:");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Openweb();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\Taskmgr.exe");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\cleanmgr.exe");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

        }
    }
}
