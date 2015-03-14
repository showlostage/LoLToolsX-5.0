using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLToolsX.Region
{
    class NA : BaseRegion
    {
        public override string ServerHost
        {
            get { return "host=prod.na2.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "lq_uri=https://lq.na2.lol.riotgames.com/"; }
        }

        public override string ChatServer
        {
            get { return "xmpp_server_url=chat.na2.lol.riotgames.com"; }
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
            get { return "featuredGamesURL=http://spectator.na2.lol.riotgames.com:80/observer-mode/rest/"; }
        }

        public override string EkgUrl
        {
            get { return "ekg_uri=https://ekg.riotgames.com"; }
        }

        public override string RegionTag
        {
            get { return "na"; }
        }

        public override string RssStatusURLs
        {
            get { return "rssStatusURLs=http://na.leagueoflegends.com/en/rss.xml"; }
        }

        public override string PlatformId
        {
            get { return "NA1"; }
        }

        public override string RiotDataServiceDataSendProbability
        {
            get { return "riotDataServiceDataSendProbability=1.0"; }
        }
    }
}
