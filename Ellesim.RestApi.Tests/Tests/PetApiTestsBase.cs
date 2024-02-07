using Ellesim.RestApi.Framework.Requests;
using Ellesim.RestApi.Framework.Requests.Pet;
using NUnit.Framework;

namespace Ellesim.RestApi.Tests.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public abstract class PetApiTestsBase
    {
        protected PetStoreApiFacade PetApi;
        protected string? BaseUrl;

        [OneTimeSetUp]
        public void BeforeFixture()
        {
            BaseUrl = GlobalSetup.BaseUrl;
            PetApi = new PetStoreApiFacade(BaseUrl!);        }
    }
}
