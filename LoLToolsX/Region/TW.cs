using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLToolsX.Region
{
    class TW : BaseRegion, IRegion
    {

        public override string ServerHost
        {
            get { return "host=prodtw.lol.garenanow.com"; }
        }

        public override string LoginQueue
        {
            get { return "lq_uri=https://loginqueuetw.lol.garenanow.com"; }
        }

        public override string ChatServer
        {
            get { return "xmpp_server_url=chattw.lol.garenanow.com"; }
        }

        public override string LobbyLanding
        {
            get { return "lobbyLandingURL=http://lobby.lol.tw/"; }
        }

        public override string LadderUrl
        {
            get { return "ladderURL=http://lol.garena.tw/ladders"; }
        }

        public override string HelpUrl
        {
            get { return "helpURL=http://lobby.lol.tw/"; }
        }

        public override string StoryPage
        {
            get { return "storyPageURL=http://lol.garena.tw/story/index.php?game_box=true"; }
        }

        public override string FeaturedGame
        {
            get { return "featuredGamesURL=http://112.121.84.194:8088/observer-mode/rest/featured"; }
        }

        public override string EkgUrl
        {
            get { return "ekg_uri=https://ekg.riotgames.com"; }
        }

        public override string RegionTag
        {
            get { return ""; }
        }

        public override string RssStatusURLs
        {
            get { return ""; }
        }

        public override string PlatformId
        {
            get { return ""; }
        }

        public override string RiotDataServiceDataSendProbability
        {
            get { return "riotDataServiceDataSendProbability=1.0"; }
        }
    }
}
