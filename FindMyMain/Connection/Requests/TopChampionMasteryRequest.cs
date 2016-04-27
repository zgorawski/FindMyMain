using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyMain.Connection.Requests
{
    public class TopChampionMasteryRequest : IAPIRequest
    {
        public TopChampionMasteryRequest(Region region, long summonerId, int limit = 1)
        {
            this.region = RegionUtility.regionToString(region);
            platformId = RegionUtility.regionToPlatformId(region);
            this.summonerId = summonerId;
            this.limit = limit;
        }

        private string region { get; set; }
        private string platformId { get; set; }
        private long summonerId { get; set; }
        private int limit { get; set; }

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
                return $"/championmastery/location/{platformId}/player/{summonerId}/topchampions";
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
                return new Dictionary<string, object> { { "count", limit } };
            }
        }
    }
}