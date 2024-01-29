using Ellesim.RestApi.Framework.Actions;
using Ellesim.RestApi.Framework.Models.Pet;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ellesim.RestApi.Tests.Tests.Pet
{
    internal class GetPetByIdApiTests : PetApiTestsBase
    {
        [Test]
        public void GetFirstPet_IdExists_ShouldBeReturned()
        {
            //Arange
            PetApiModelV2 expectedResponse = PetActionRequests.CreateNewPet(BaseUrl!);

            //Act
            RestResponse response = PetApiRequests!.ExecuteApiGetPetByIdRequest(expectedResponse.Id!.Value);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var responseBody = JsonConvert.DeserializeObject<PetApiModelV2>(response.Content!);
            responseBody.Should().NotBeNull();
            responseBody.Should().BeEquivalentTo(expectedResponse);

        }
    }
}
