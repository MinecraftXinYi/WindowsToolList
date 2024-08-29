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

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WindowsToolList
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Tool : Page
    {
        public Tool()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Program Files\\Hyper-V\\VMCreate.exe");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Windows Media Player\\wmplayer.exe");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe");
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Administrative Tools\\Hyper-V Manager.lnk");
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\iscsicpl.exe");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\syswow64\\odbcad32.exe");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\odbcad32.exe");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Program Files\\WindowsApps\\Microsoft.PowerAutomateDesktop_1.0.560.0_x64__8wekyb3d8bbwe\\PAD.Console.Host.exe");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Windows\\SysWOW64\\WindowsPowerShell\\v1.0\\powershell.exe");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell_ise.exe");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Windows\\SysWOW64\\WindowsPowerShell\\v1.0\\powershell_ise.exe");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\MdSched.exe");
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\eventvwr.exe");
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\Taskmgr.exe");
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\taskschd.msc");
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Program Files\\Windows NT\\Accessories\\wordpad.exe");
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Windows\\system32\\charmap.exe");
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\perfmon.msc");
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\RecoveryDrive.exe");
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\printmanagement.msc");
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            Process.Start("control.exe");
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\services.msc");
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\secpol.msc");
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\regedit.exe");
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\dfrgui.exe");
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\cleanmgr.exe");
        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\msinfo32.exe");
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\msconfig.exe");
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\comexp.msc");
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\compmgmt.msc");
        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\perfmon.exe");
        }

        private void Button_Click_32(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Users\\H WX\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\System Tools\\Run.lnk");
        }

        private void Button_Click_33(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\mstsc.exe");
        }

        private void Button_Click_34(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\WF.msc");
        }

        private void Button_Click_35(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\psr.exe");
        }
    }
}

