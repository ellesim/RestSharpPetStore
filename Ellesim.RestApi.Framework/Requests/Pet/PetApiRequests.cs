using Ellesim.RestApi.Framework.Models.Pet;
using Ellesim.RestApi.Framework.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace Ellesim.RestApi.Framework.Requests.Pet
{
    public class PetApiRequests : ApiRequestBase
    {
        public PetApiRequests(string baseUrl) : base(baseUrl)
        {
            
        }

        public RestResponse ExecuteApiPostPetRequest(PetApiModelV2 requestBody)
        {
            var request = new RestRequest(EndpointPaths.PetResourceUrl(), Method.Post);
            request.AddHeaders(_headers);

            string stringJson = JsonConvert.SerializeObject(requestBody);
            request.AddBody(stringJson);
            RestResponse response = Client.Execute(request);
            return Client!.Execute(request);
        }

        public RestResponse ExecuteApiGetPetByIdRequest(long petId)
        {
            var request = new RestRequest(EndpointPaths.PetByIdResourceUrl(petId), Method.Get);
            request.AddHeaders(_headers);
            return Client!.Execute(request);
        }

        public RestResponse ExecuteApiPutPetRequest(int petId, PetApiModelV2 requestBody)
        {
            var request = new RestRequest(EndpointPaths.PetByIdResourceUrl(petId), Method.Put);
            request.AddHeaders(_headers);
            string stringJson = JsonConvert.SerializeObject(requestBody);
            request.AddBody(stringJson);
            return Client!.Execute(request);
        }


    }
}
