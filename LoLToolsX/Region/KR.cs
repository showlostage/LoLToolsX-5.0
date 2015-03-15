using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLToolsX.Region
{
    class KR : BaseRegion
    {
        public override string ServerHost
        {
            get { return "host=prod.kr.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "lq_uri=https://lq.kr.lol.riotgames.com"; }
        }

        public override string ChatServer
        {
            get { return "xmpp_server_url=chat.kr.lol.riotgames.com"; }
        }

        public override string LobbyLanding
        {
            get { return "lobbyLandingURL=http://www.leagueoflegends.co.kr/Launcher/launcher_main.php"; }
        }

        public override string LadderUrl
        {
            get { return "ladderURL=http://www.leagueoflegends.co.kr"; }
        }

        public override string HelpUrl
        {
            get { return ""; }
        }

        public override string StoryPage
        {
            get { return "storyPageURL=http://leagueoflegends.co.kr/Launcher/launcher_journal.php"; }
        }

        public override string FeaturedGame
        {
            get { return "featuredGamesURL=http://spectator.kr.lol.riotgames.com:80/observer-mode/rest/featured"; }
        }

        public override string EkgUrl
        {
            get { return "ekg_uri=https://ekg.riotgames.com"; }
        }

        public override string RegionTag
        {
            get { return "regionTag=kr"; }
        }

        public override string RssStatusURLs
        {
            get { return ""; }
        }

        public override string PlatformId
        {
            get { return "platformId=KR"; }
        }

        public override string RiotDataServiceDataSendProbability
        {
            get { return "riotDataServiceDataSendProbability=1.0"; }
        }
    }
}
