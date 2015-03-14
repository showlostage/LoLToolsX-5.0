using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLToolsX.Region
{
    interface IRegion
    {
        string ServerHost { get; }
        string LoginQueue { get; }
        string ChatServer { get; }
        string LobbyLanding { get; }
        string LadderUrl { get; }
        string HelpUrl { get; }
        string StoryPage { get; }
        string FeaturedGame { get; }
        string EkgUrl { get; }
        string RegionTag { get; }
        string RssStatusURLs { get; }
        string PlatformId { get; }
        string RiotDataServiceDataSendProbability { get; }
    }
}
