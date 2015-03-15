using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoLToolsX.Properties;
using Microsoft.Win32;
using System.IO;

using LoLToolsX.Region;

namespace LoLToolsX.Logic
{
    class Core
    {
        public static MainWindow MainWindow;

        private static Server _sever;
        public static Server CurrentServer
        {
            get
            {
                return _sever;
            }
            set
            {
                if (value.GetType() == typeof(Server))
                    _sever = value;
            }
        }

        public static IRegion CurrentRegion { get; set; }

        public static Dictionary<Server, IRegion> EnumToRegion = new Dictionary<Server, IRegion>() 
        {
            {Server.TW, new TW()},
            {Server.NA, new NA()},
            {Server.KR, new KR()},
            {Server.SEA, new SEA()},
            {Server.EUW, new EUW()},
            {Server.EUNE, new EUNE()},
            {Server.OCE, new OCE()},
            {Server.PBE, new PBE()}
        };

        public static string LoLPath
        {
            get
            { return Settings.Default.LoLPath; }
            set
            {
                if (value.Contains("LoLTW"))
                {
                    if (!value.EndsWith("\\"))
                        value += "\\";
                    MainWindow.lblPath.Content = value;
                    Settings.Default.LoLPath = value;
                }
            }
        }

        public static string ToolsVersion
        {
            get
            {
                return System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
            }
        }

        public static string LoLVersion
        {
            get
            {
                return System.IO.File.ReadAllText(Core.LoLPath + "lol.version");
            }
        }

        public static string GetLoLPath()
        {
            string path = "";
            RegistryKey regKey = Registry.LocalMachine;

            if (regKey.OpenSubKey("SOFTWARE\\Garena\\LoLTW") != null)
                path = regKey.OpenSubKey("SOFTWARE\\Garena\\LoLTW").GetValue("Path").ToString();
            else
            {
                regKey = Registry.CurrentUser;
                if (regKey.OpenSubKey("Software\\Garena\\LoLTW") != null)
                    path = regKey.OpenSubKey("Software\\Garena\\LoLTW").GetValue("Path").ToString();
            }
            path = path.Substring(0, path.Length - 1);
            if (!path.EndsWith("LoLTW"))
            {
                using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
                {
                    dialog.Description = "請選擇 LoLTW 目錄";
                    //dialog.RootFolder = Environment.SpecialFolder.ProgramFiles;

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (dialog.SelectedPath.EndsWith("LoLTW") || !dialog.SelectedPath.EndsWith("LoLTW\\"))
                        {
                            Core.LoLPath = dialog.SelectedPath;
                            regKey.CreateSubKey("Software\\Garena\\LoLTW").SetValue("Path", Core.LoLPath);
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("LoLTW 目錄選擇錯誤，按確定離開程式", "錯誤", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("LoLTW 目錄沒有選擇，按確定離開程式","錯誤",System.Windows.MessageBoxButton.OK,System.Windows.MessageBoxImage.Error);
                        Environment.Exit(0);
                    }
                }
            }

#if DEBUG
            System.Windows.MessageBox.Show(path);
#endif

            regKey.Close();
            return path.ToString();
        }

        public static Server GetCurrentServer()
        {
            Server server = Server.TW;
            if (!String.IsNullOrEmpty(LoLPath))
            {
                //string lolProp = File.ReadAllText(LoLPath + "Air\lol.properties",Encoding.Default);
                using (var reader = new StreamReader(LoLPath + "Air\\lol.properties",Encoding.Default))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (line.StartsWith("host="))
                        {
                            var value = Core.EnumToRegion.Values;
                            foreach (var v in value)
                            {
                                if (v.ServerHost == line)
                                    //System.Windows.MessageBox.Show(v.GetType().ToString());
                                    return LoLToolsX.Utils.EnumUtils.ParseEnum<Server>(v.GetType().ToString().Replace("LoLToolsX.Region.", ""));
                            }
                        }
                    }
                }
            }
            return server;
        }
    }

    public enum Server
    {
        TW,
        NA,
        KR,
        SEA,
        EUW,
        EUNE,
        OCE,
        PBE,
        //CN,
    }
}