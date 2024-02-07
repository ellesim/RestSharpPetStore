using Ellesim.RestApi.Framework.Models.User;
using Ellesim.RestApi.Framework.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace Ellesim.RestApi.Framework.Requests.User
{
    public class UserApiRequests : ApiRequestBase
    {
        public UserApiRequests(string baseUrl) : base(baseUrl)
        {
        }

        public RestResponse ExecutePostUserRequest(UserApiModelV2 body)
        {
            var request = new RestRequest(EndpointPaths.UserResourceUrl(), Method.Post);
            request.AddHeaders(_headers);

            string stringJson = JsonConvert.SerializeObject(body);
            request.AddBody(stringJson);

            return Client!.Execute(request);
        }
    }
}
