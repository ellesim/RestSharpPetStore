using Ellesim.RestApi.Framework.Models.Pet;
using FluentAssertions;
using FluentAssertions.Execution;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace Ellesim.RestApi.Tests.Tests.Pet
{
    public class PostPetApiTests : PetApiTestsBase
    {

        [Test]
        public void CreatePet_withCorrectData_ShouldBeCreated()
        {
            // Arrange
            // ---Model with correct data should be prepared
            var petBody = new PetApiModelV2
            {
                Category = new Category
                {
                    Id = 1,
                },
                Name = "Penny",
                PhotoUrls = new List<string>
                {
                "https://www.google"
                },
                Tags = new List<Tag>
                {
                new Tag
                {
                Id = 1,
                Name = "dog"
            }
        },
                Status = "available"
            };

            // Act
            // ---Send request
            // POST
            // https://petstore.swagger.io/v2/pet
            // -H 'accept: application/json'
            // -H 'Content-Type: application/json'
            // -body
            RestResponse response = PetApiRequests!.ExecuteApiPostPetRequest(petBody);



            // Assert
            // ---Verify status code is 200
            // ---Verify response body is equal to expected
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var responseBody = JsonConvert.DeserializeObject<PetApiModelV2>(response.Content!);
            responseBody.Should().NotBeNull();

            using (new AssertionScope())
            {
                // compare the response body to the request body, but exclude the top-level id
                responseBody.Should().BeEquivalentTo(petBody, res => res.Excluding(res => res.Id));
                responseBody!.Id.Should().NotBeNull().And.BeGreaterThan(0);
            }  

        }

        [Test]
        public void CreatePet_WithCategoryIdDoesNotExist_ShouldBeCreated()
        {
            // Arrange
            // ---Model with correct data should be prepared
            var petBody = new PetApiModelV2
            {
                Name = "Penny",
                PhotoUrls = new List<string>
                {
                "https://www.google"
                },
                Tags = new List<Tag>
                {
                new Tag
                {
                Id = 1,
                Name = "dog"
            }
        },
                Status = "available"
            };

            // Act
            // ---Send request
            // POST
            // https://petstore.swagger.io/v2/pet
            // -H 'accept: application/json'
            // -H 'Content-Type: application/json'
            // -body
            RestResponse response = PetApiRequests!.ExecuteApiPostPetRequest(petBody);


            // Assert
            // ---Verify status code is 200
            // ---Verify response body is equal to expected
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var responseBody = JsonConvert.DeserializeObject<PetApiModelV2>(response.Content!);
            responseBody.Should().NotBeNull();
            // compare the response body to the request body, but exclude the top-level id
            responseBody.Should().BeEquivalentTo(petBody, res => res.Excluding(res => res.Id));


        }
    }
}
