using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using LoLToolsX.Region;
using LoLToolsX.Utils;

namespace LoLToolsX.Logic
{
    class PropertiesManager
    {
        IRegion region;
        readonly string LOL_PROPERTIES = Core.LoLPath + "\\Air\\lol.properties";
        StreamWriter writer;

        public PropertiesManager(string server) : this(EnumUtils.ParseEnum<Server>(server))
        {
            
        }
        public PropertiesManager(Server server)
        {
            region = Core.EnumToRegion[server];
            writer = new StreamWriter(LOL_PROPERTIES,false,Encoding.Default);
        }
        public PropertiesManager(IRegion server)
        {
            region = server;
            writer = new StreamWriter(LOL_PROPERTIES,false,Encoding.Default);
        }

        public void Write()
        {
            writer.Write(region.ToString());
            Dispose();
        }

        public void Dispose()
        {
            if (writer != null)
            {
                writer.Flush();
                writer.Dispose();
                writer = null;
            }
        }
    }

    class SeperatePropertiesWriter
    {
        readonly string LOL_PROPERTIES = Core.LoLPath + "\\Air\\lol.properties";
        StreamWriter writer;

        public SeperatePropertiesWriter()
        {
            writer = new StreamWriter(LOL_PROPERTIES, false, Encoding.Default);
            writer.Write(Environment.NewLine);
        }

        public void Write(string server,string property)
        {
            var serverEnum = EnumUtils.ParseEnum<Server>(server);
            var region = Core.EnumToRegion[serverEnum];
            var info = typeof(IRegion).GetProperty(property);
            var value = info.GetValue(region, null).ToString();
            if (!String.IsNullOrEmpty(value))
                writer.WriteLine(info.GetValue(region,null).ToString() + "\r\n");
        }

        public void Dispose()
        {
            if (writer != null)
            {
                writer.Flush();
                writer.Dispose();
                writer = null;
            }
        }
    }
}
