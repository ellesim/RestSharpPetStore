using Ellesim.RestApi.Framework.Requests.Pet;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellesim.RestApi.Tests.Tests
{
    [TestFixture]
    public abstract class PetApiTestsBase
    {
        protected PetApiRequests? PetApiRequests;
        protected string? BaseUrl;

        [OneTimeSetUp]
        public void BeforeFixture()
        {
            BaseUrl = GlobalSetup.BaseUrl;
            PetApiRequests = new PetApiRequests(BaseUrl!);
        }
    }
}
