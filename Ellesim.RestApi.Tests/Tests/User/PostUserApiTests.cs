using Ellesim.RestApi.Framework.Models.Common;
using Ellesim.RestApi.Framework.Models.Pet;
using Ellesim.RestApi.Framework.Models.User;
using Ellesim.RestApi.Framework.Utils;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using RestSharp;

namespace Ellesim.RestApi.Tests.Tests.User
{
    public class PostUserApiTests : PetApiTestsBase
    {
        [Test]
        public void CreateUser_WithValidFullData_ShouldBeCreated()
        {
            //Arrange
            var userBody = new UserApiModelV2
            {
                Email = "test@test.com",
                FirstName = "Linda",
                LastName = "Sim",
                Password = "123456",
                Phone = "1234567890",
                UserStatus = 1
            };

            //Act
            RestResponse response = PetApi!.UserSection()
                .ExecutePostUserRequest(userBody);

            //Assert
            response.StatusCode
                .Should()
                .Be(System.Net.HttpStatusCode.OK);
            CommonApiResponseModel responseBody = response
                .ConvertToModel<CommonApiResponseModel>();
            using(new AssertionScope())
            {
                responseBody.Code.Should().Be(200);
                responseBody.Type.Should().Be("unknown");
            }
        }
    }
}
