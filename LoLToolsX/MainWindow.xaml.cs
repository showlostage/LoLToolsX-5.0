using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using MahApps.Metro;
using MahApps.Metro.Controls;

using LoLToolsX.Logic;
using LoLToolsX.Region;

namespace LoLToolsX
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Core.MainWindow = this;
        }

        private void MainWindow1_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Core.LoLPath))
                Core.LoLPath = Core.GetLoLPath();
            lblToolsVerson.Content = Core.GetToolsVersion;
        }
    }
}
