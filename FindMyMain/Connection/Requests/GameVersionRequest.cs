﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace FindMyMain.Connection.Requests
{
    public class GameVersionRequest : IAPIRequest
    {
        public GameVersionRequest(LolRegion region)
        {
            this.region = Enum.GetName(typeof(LolRegion), region);
        }

        private string region { get; set; }

        // IAPIRequest

        public string domain
        {
            get
            {
                return "https://global.api.pvp.net";
            }
        }

        public string endpoint
        {
            get
            {
                return $"/api/lol/static-data/{region}/v1.2/versions";
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