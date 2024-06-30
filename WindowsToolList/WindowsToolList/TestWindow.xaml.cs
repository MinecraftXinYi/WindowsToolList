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

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WindowsToolList
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TestWindow : Window
    {
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
                    string json = File.ReadAllText("test.json");
                    JsonArray data = (JsonArray)JsonArray.Parse(json);
                    foreach (var item in data)
                    {
                        try
                        {
                            toolList.Add(new WindowsTool()
                            {
                                Name = item["Name"].ToString() ?? "Name",
                                Path = item["Path"].ToString() ?? "C:\\Windows\\System32\\cmd.exe",
                                Type = (int)item["Type"],
                                UseShellExecute = (bool)item["UseShellExecute"],
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
    }
}
