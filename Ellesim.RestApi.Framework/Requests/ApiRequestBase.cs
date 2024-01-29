using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellesim.RestApi.Framework.Requests
{
    public abstract class ApiRequestBase
    {
        protected readonly RestClient? Client;

        protected readonly Dictionary<string, string> _headers = new()
        {
            { "accept", "application/json" },
            { "Content-Type", "application/json" }
        };

        protected ApiRequestBase(string baseUrl)
        {
            Client = new RestClient(baseUrl);
        }

    }
}
