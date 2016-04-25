using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace FindMyMain.Connection.Requests
{
    sealed class GameVersionRequest : IAPIRequest
    {
        GameVersionRequest(LolRegion region)
        {
            this.region = region;
        }

        private LolRegion region { get; set; }

        // IAPIRequest

        string IAPIRequest.domain
        {
            get
            {
                return "https://global.api.pvp.net";
            }
        }

        string IAPIRequest.endpoint
        {
            get
            {
                return $"/api/lol/static-data/{region}/v1.2/versions";
            }
        }

        Method IAPIRequest.httpMethod
        {
            get
            {
                return Method.GET;
            }
        }

        Dictionary<string, string> IAPIRequest.parameters
        {
            get
            {
                return null;
            }
        }
    }
}