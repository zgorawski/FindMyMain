using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace FindMyMain.Connection.Requests
{
    public class RecentGamesRequest : IAPIRequest
    {
        public RecentGamesRequest(Region region, long summonerId)
        {
            this.region = RegionUtility.regionToString(region);
            this.summonerId = summonerId;
        }

        private string region { get; set; }
        private long summonerId { get; set; }

        // IAPIRequest

        public string domain
        {
            get
            {
                return $"https://{region}.api.pvp.net";
            }
        }

        public string endpoint
        {
            get
            {
                return $"/api/lol/{region}/v1.3/game/by-summoner/{summonerId}/recent";
            }
        }

        public Method httpMethod
        {
            get
            {
                return Method.GET;
            }
        }

        public Dictionary<string, object> parameters
        {
            get
            {
                return null;
            }
        }
    }
}