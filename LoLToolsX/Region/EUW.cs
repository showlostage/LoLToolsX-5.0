using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLToolsX.Region
{
    class EUW : BaseRegion
    {
        public override string ServerHost
        {
            get { return "host=prod.euw1.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "lq_uri=https://lq.euw1.lol.riotgames.com/"; }
        }

        public override string ChatServer
        {
            get { return "xmpp_server_url=chat.eu1.lol.riotgames.com"; }
        }

        public override string LobbyLanding
        {
            get { return "lobbyLandingURL=http://landing.leagueoflegends.com/spectator_swf/landingPage.swf"; }
        }

        public override string LadderUrl
        {
            get { return ""; }
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
            get { return "http://spectator.eu.lol.riotgames.com:8088/observer-mode/rest/featured"; }
        }

        public override string EkgUrl
        {
            get { return "ekg_uri=https://ekg.riotgames.com"; }
        }

        public override string RegionTag
        {
            get { return "euw"; }
        }

        public override string RssStatusURLs
        {
            get { return "http://euw.leagueoflegends.com/en/rss.xml"; }
        }

        public override string PlatformId
        {
            get { return "EUW1"; }
        }

        public override string RiotDataServiceDataSendProbability
        {
            get { return ""; }
        }
    }
}
