using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using MahApps.Metro;
using MahApps.Metro.Controls;

using LoLToolsX.Logic;
using LoLToolsX.Region;
using LoLToolsX.Utils;

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
            InitComboBox();
            Core.MainWindow = this;
        }

        private void MainWindow1_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Core.LoLPath))
                Core.LoLPath = Core.GetLoLPath();
            lblToolsVerson.Content = Core.ToolsVersion;
            lblServer.Content = Core.GetCurrentServer().ToString();
            lblLolVersion.Content = Core.LoLVersion;
        }

        private void InitComboBox()
        {
            foreach (var i in Enum.GetValues(typeof(Server)))
            {
                cbChatServer.Items.Add(i.ToString());
                cbHelpPage.Items.Add(i.ToString());
                cbLadder.Items.Add(i.ToString());
                cbLobbyLanding.Items.Add(i.ToString());
                cbObsServer.Items.Add(i.ToString());
                cbRssNews.Items.Add(i.ToString());
                cbServer.Items.Add(i.ToString());
                cbStoryPage.Items.Add(i.ToString());
                cbSwitchServer.Items.Add(i.ToString());
            }
        }

        private void btnSwitchServer_Click(object sender, RoutedEventArgs e)
        {
            PropertiesManager propManager = new PropertiesManager(cbSwitchServer.SelectedValue.ToString());
            propManager.Write();
            propManager.Dispose();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            SeperatePropertiesWriter writer = new SeperatePropertiesWriter();
            writer.Write(cbChatServer.SelectedValue.ToString(), "ChatServer");
            writer.Write(cbHelpPage.SelectedValue.ToString(), "HelpUrl");
            writer.Write(cbLadder.SelectedValue.ToString(),"LadderUrl");
            writer.Write(cbLobbyLanding.SelectedValue.ToString(),"LobbyLanding");
            writer.Write(cbObsServer.SelectedValue.ToString(),"FeaturedGame");
            writer.Write(cbRssNews.SelectedValue.ToString(),"RssStatusURLs");
            writer.Write(cbServer.SelectedValue.ToString(),"ServerHost");
            writer.Write(cbChatServer.SelectedValue.ToString(), "LoginQueue");
            writer.Write(cbStoryPage.SelectedValue.ToString(),"StoryPage");
            writer.Dispose();
        }
    }
}
