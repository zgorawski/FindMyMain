using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyMain.Connection.Requests
{
    public class GetSummonerRequest : IAPIRequest
    {
        public GetSummonerRequest(Region region, long summonerId)
        {
            this.region = RegionUtility.RegionToString(region);
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
                return $"/api/lol/{region}/v1.4/summoner/{summonerId}";
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