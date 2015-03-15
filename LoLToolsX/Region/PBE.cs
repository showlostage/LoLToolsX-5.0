using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLToolsX.Region
{
    class PBE : BaseRegion
    {
        public override string ServerHost
        {
            get { return "host=prod.pbe1.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "lq_uri=https://lq.pbe1.lol.riotgames.com/login-queue/rest/queue"; }
        }

        public override string ChatServer
        {
            get { return "xmpp_server_url=chat.pbe1.lol.riotgames.com"; }
        }

        public override string LobbyLanding
        {
            get { return "lobbyLandingURL=http://d2q6fdmnncz9b0.cloudfront.net/landingPage.swf"; }
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
            get { return "featuredGamesURL=http://spectator.pbe1.lol.riotgames.com:8088/observer-mode/rest/featured"; }
        }

        public override string EkgUrl
        {
            get { return "ekg_uri=https://ekg.riotgames.com "; }
        }

        public override string RegionTag
        {
            get { return "regionTag=pbe1"; }
        }

        public override string RssStatusURLs
        {
            get { return "rssStatusURLs=http://na.leagueoflegends.com/en/rss.xml"; }
        }

        public override string PlatformId
        {
            get { return "platformId=PBE"; }
        }

        public override string RiotDataServiceDataSendProbability
        {
            get { return "riotDataServiceDataSendProbability=1.0"; }
        }
    }
}
