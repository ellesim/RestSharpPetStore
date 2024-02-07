using Newtonsoft.Json;

namespace Ellesim.RestApi.Framework.Models.Common
{
    public class CommonApiResponseModel
    {
        [JsonProperty("code")]
        public int? Code { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}
