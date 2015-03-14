using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLToolsX.Region
{
    class SEA : BaseRegion
    {
        public override string ServerHost
        {
            get { return "host=prod.lol.garenanow.com"; }
        }

        public override string LoginQueue
        {
            get { return "lq_uri=https://lq.lol.garenanow.com"; }
        }

        public override string ChatServer
        {
            get { return "xmpp_server_url=chat.lol.garenanow.com"; }
        }

        public override string LobbyLanding
        {
            get { return "lobbyLandingURL=http://lol.garena.com/landing.php"; }
        }

        public override string LadderUrl
        {
            get { return "ladderURL=http://lol.garena.com/ladders"; }
        }

        public override string HelpUrl
        {
            get { return "helpURL=http://lol.garena.com/support"; }
        }

        public override string StoryPage
        {
            get { return ""; }
        }

        public override string FeaturedGame
        {
            get { return ""; }
        }

        public override string EkgUrl
        {
            get { return ""; }
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
            get { return ""; }
        }
    }
}
