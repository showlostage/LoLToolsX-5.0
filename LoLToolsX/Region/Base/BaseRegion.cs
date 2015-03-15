using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoLToolsX.Utils;

namespace LoLToolsX.Region
{
    abstract class BaseRegion : IRegion
    {
        public abstract string ServerHost { get; }

        public abstract string LoginQueue { get; }

        public abstract string ChatServer { get; }

        public abstract string LobbyLanding { get; }

        public abstract string LadderUrl { get; }

        public abstract string HelpUrl { get; }

        public abstract string StoryPage { get; }

        public abstract string FeaturedGame { get; }

        public abstract string EkgUrl { get; }

        public abstract string RegionTag { get; }

        public abstract string RssStatusURLs { get; }

        public abstract string PlatformId { get; }

        public abstract string RiotDataServiceDataSendProbability { get; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            IList<System.Reflection.PropertyInfo> properties = Util.GetProperties(typeof(IRegion));
            foreach (var p in properties)
            {
                var v = p.GetValue(this, null).ToString();
                if (!String.IsNullOrEmpty(v))
                {
                    str.Append(v + "\r\n");
                }
            }
            return str.ToString();
        }
    }
}
