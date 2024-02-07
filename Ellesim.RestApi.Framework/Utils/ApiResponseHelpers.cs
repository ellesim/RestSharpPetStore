using FluentAssertions;
using Newtonsoft.Json;
using RestSharp;

namespace Ellesim.RestApi.Framework.Utils
{
    public static class ApiResponseHelpers
    {
        public static T ConvertToModel<T>(this RestResponse response)
        {
            var convertedModel = JsonConvert.DeserializeObject<T>(response.Content!);
            convertedModel.Should().NotBeNull();
            return convertedModel;
        }
    }
}
