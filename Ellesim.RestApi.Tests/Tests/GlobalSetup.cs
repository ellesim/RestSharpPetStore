using Ellesim.RestApi.Framework.Requests.Pet;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ellesim.RestApi.Tests.Tests
{
    [SetUpFixture]
    public class GlobalSetup
    {
        public static string? BaseUrl;

        [OneTimeSetUp]
        public void BeforeFixture()
        {
            BaseUrl = TestContext.Parameters["baseUrl"]!;
            BaseUrl.Should().NotBeNullOrEmpty("baseUrl parameter should be specified");

        }
    }
}
