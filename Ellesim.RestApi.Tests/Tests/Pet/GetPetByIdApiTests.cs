using Ellesim.RestApi.Framework.Actions;
using Ellesim.RestApi.Framework.Models.Pet;
using Ellesim.RestApi.Framework.Utils;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;

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
            RestResponse response = PetApi!.PetSection().ExecuteApiGetPetByIdRequest(expectedResponse.Id!.Value);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            PetApiModelV2 responseBody = response.ConvertToModel<PetApiModelV2>();
            responseBody.Should().BeEquivalentTo(expectedResponse);

        }
    }
}
