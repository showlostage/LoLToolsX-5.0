using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoLToolsX.Properties;
using Microsoft.Win32;
using System.IO;

namespace LoLToolsX
{
    class Core
    {
        public static MainWindow MainWindow;

        private static Server _sever;
        public static Server CurrentServer
        {
            get
            {
                if (_sever == null)
                    return Server.TW;
                return _sever;
            }
            set
            {
                if (value.GetType() == typeof(Server))
                    _sever = value;
            }
        }

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

        public static string GetToolsVersion
        {
            get
            {
                return System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
            }
        }

        public static string GetLoLPath()
        {
            StringBuilder path = new StringBuilder();
            RegistryKey regKey = Registry.LocalMachine;

            if (regKey.OpenSubKey("SOFTWARE\\Garena\\LoLTW") != null)
                path.Append(regKey.OpenSubKey("SOFTWARE\\Garena\\LoLTW").GetValue("Path"));
            else
            {
                regKey = Registry.CurrentUser;
                if (regKey.OpenSubKey("Software\\Garena\\LoLTW") != null)
                    path.Append(regKey.OpenSubKey("Software\\Garena\\LoLTW").GetValue("Path"));
            }

#if DEBUG
            System.Windows.MessageBox.Show(path.ToString());
#endif
            return path.ToString();
        }

        public static Server GetCurrentServer()
        {
            Server server = Server.TW;
            if (!String.IsNullOrEmpty(LoLPath))
            {
                //string lolProp = File.ReadAllText(LoLPath + "Air\lol.properties",Encoding.Default);
                StreamReader reader = new StreamReader(LoLPath + "Air\lol.properties",Encoding.Default);
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line.StartsWith("host="))
                    {
                        switch (line)
                        {
                            //TODO
                        }
                    }
                }
            }
            return server;
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
}
