using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLToolsX.Region
{
    class OCE : BaseRegion
    {
        public override string ServerHost
        {
            get { return "host=prod.oc1.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "lq_uri=https://lq.oc1.lol.riotgames.com "; }
        }

        public override string ChatServer
        {
            get { return "xmpp_server_url=chat.oc1.lol.riotgames.com"; }
        }

        public override string LobbyLanding
        {
            get { return "lobbyLandingURL=http://landing.leagueoflegends.com/spectator_swf/landingPage.swf"; }
        }

        public override string LadderUrl
        {
            get { return "ladderURL=http://www.leagueoflegends.com/ladders"; }
        }

        public override string HelpUrl
        {
            get { return ""; }
        }

        public override string StoryPage
        {
            get { return "storyPageURL=http://www.leagueoflegends.com/story"; }
        }

        public override string FeaturedGame
        {
            get { return "featuredGamesURL=http://spectator.oc1.lol.riotgames.com:80/observer-mode/rest/featured"; }
        }

        public override string EkgUrl
        {
            get { return "ekg_uri=https://ekg.riotgames.com"; }
        }

        public override string RegionTag
        {
            get { return "oce"; }
        }

        public override string RssStatusURLs
        {
            get { return "rssStatusURLs=http://oce.leagueoflegends.com/en/rss.xml"; }
        }

        public override string PlatformId
        {
            get { return "OC1"; }
        }

        public override string RiotDataServiceDataSendProbability
        {
            get { return "riotDataServiceDataSendProbability=1.0"; }
        }
    }
}
