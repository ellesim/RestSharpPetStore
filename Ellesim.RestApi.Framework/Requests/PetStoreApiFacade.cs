using Ellesim.RestApi.Framework.Requests.Pet;
using Ellesim.RestApi.Framework.Requests.User;

namespace Ellesim.RestApi.Framework.Requests
{
    public class PetStoreApiFacade
    {
        private readonly string _baseUrl;

        public PetStoreApiFacade(string baseUrl)
        {
            _baseUrl = baseUrl;
        }
        public PetApiRequests PetSection() => new (_baseUrl);

        public UserApiRequests UserSection() => new(_baseUrl);

    }
}
