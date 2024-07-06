using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Collections.ObjectModel;
using WindowsToolList.Models;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WindowsToolList
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TestWindow : Window
    {
        [DllImport("kernel32.dll")]
        public static extern int WinExec(string exeName, int operType);

        public TestWindow()
        {
            this.InitializeComponent();
            Title = "Test Window";
            ExtendsContentIntoTitleBar = true;
            SetTitleBar(newTitleBar);

            ObservableCollection<WindowsTool> toolList = new ObservableCollection<WindowsTool>();
            if (File.Exists("test.json"))
            {
                try
                {
                    JsonDocumentOptions jsonDocumentOptions = new JsonDocumentOptions()
                    {
                        AllowTrailingCommas = true,
                        CommentHandling = JsonCommentHandling.Skip
                    };
                    string json = File.ReadAllText("test.json");
                    JsonDocument jsonDocument = JsonDocument.Parse(json, jsonDocumentOptions);
                    foreach (JsonElement item in jsonDocument.RootElement.GetProperty("WindowsTools").EnumerateArray())
                    {
                        try
                        {
                            toolList.Add(new WindowsTool()
                            {
                                Name = item.GetProperty("Name").GetString() ?? "Name",
                                Path = item.GetProperty("Path").GetString() ?? "C:\\Windows\\System32\\cmd.exe",
                                Type = item.GetProperty("Type").GetInt16(),
                                UseShellExecute = item.GetProperty("UseShellExecute").GetBoolean(),
                                FontIcon = item.GetProperty("FontIcon").GetString()
                            });
                        }
                        catch (Exception) { }
                    }
                    itemsviewer.ItemsSource = toolList;
                }
                catch (Exception ex)
                {
                    ContentDialog dialog = new ContentDialog();
                    dialog.Title = "Error";
                    dialog.Content = new TextBlock()
                    {
                        Text = ex.Message,
                    };
                }
            }
        }

        private void itemsviewer_ItemInvoked(ItemsView sender, ItemsViewItemInvokedEventArgs args)
        {
            try
            {
                WindowsTool tool = (WindowsTool)args.InvokedItem;
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.UseShellExecute = tool.UseShellExecute;
                if (tool.Type.Equals(WindowsToolType.EXE))
                {
                    processStartInfo.FileName = tool.Path;
                }
                else if (tool.Type.Equals(WindowsToolType.MSC))
                {
                    processStartInfo.FileName = "C:\\Windows\\System32\\mmc.exe";
                    processStartInfo.Arguments = tool.Path;
                }
                else if (tool.Type.Equals(WindowsToolType.CPL))
                {
                    processStartInfo.FileName = "C:\\Windows\\System32\\control.exe";
                    processStartInfo.Arguments = tool.Path;
                }
                Process.Start(processStartInfo);
            }
            catch (Exception) { }
        }
    }
}
