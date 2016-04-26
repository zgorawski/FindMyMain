using FindMyMain.Connection.Requests;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;

namespace FindMyMain.Connection
{
    public struct APIResponse<T> where T : new()
    {
        public T value { get; private set; }
        public bool isSuccess { get; private set; }

        public APIResponse(T value, bool isSuccess)
        {
            this.value = value;
            this.isSuccess = isSuccess;
        }
    }

    public class RiotAPIConnection
    {
        private static string apiKey = ConfigurationManager.AppSettings["APIKey"];

        public APIResponse<T> PerformRequest<T>(IAPIRequest request) where T: new()
        {
            RestClient client = new RestClient(request.domain);
            var restRequest = new RestRequest(request.endpoint, request.httpMethod);
            restRequest.AddParameter("api_key", apiKey);
            
            if (request.parameters != null) {
                foreach (var parameter in request.parameters)
                {
                    restRequest.AddParameter(parameter.Key, parameter.Value);
                }
            }


            IRestResponse<T> parsedResponse = client.Execute<T>(restRequest);

            if (parsedResponse.Data != null && parsedResponse.StatusCode == HttpStatusCode.OK)
            {
                return new APIResponse<T>(parsedResponse.Data, true);
            }

            return new APIResponse<T>(default(T), false);
        }
    }
}