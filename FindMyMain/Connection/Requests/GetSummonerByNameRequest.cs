using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyMain.Connection.Requests
{
    public class GetSummonerByNameRequest: IAPIRequest
    {
        public GetSummonerByNameRequest(Region region, string summonerName)
        {
            this.region = RegionUtility.RegionToString(region);
            this.summonerName = summonerName;
        }

        private string region { get; set; }
        private string summonerName { get; set; }

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
                return $"/api/lol/{region}/v1.4/summoner/by-name/{summonerName}";
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