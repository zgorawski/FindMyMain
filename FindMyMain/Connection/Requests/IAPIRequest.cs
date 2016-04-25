using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace FindMyMain.Connection.Requests
{
    interface IAPIRequest
    {
        string domain { get; }
        string endpoint { get; }
        Method httpMethod { get; }
        Dictionary<string, string> parameters { get; }
    }
}
