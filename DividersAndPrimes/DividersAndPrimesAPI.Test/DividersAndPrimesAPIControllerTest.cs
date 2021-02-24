using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using Xunit;
using DividersAndPrimes.API;
using Newtonsoft.Json;

namespace DividersAndPrimesAPI.Test
{
    public class DividersAndPrimesAPIControllerTest : IClassFixture<WebApplicationFactory<DividersAndPrimes.API.Controllers.DividersAndPrimesController>>
    {
        public HttpClient _client { get; }

        public DividersAndPrimesAPIControllerTest(WebApplicationFactory<DividersAndPrimes.API.Controllers.DividersAndPrimesController> fixture)
        {
            _client = fixture.CreateClient();
        }

        [Fact]
        public async void GetShoudRetrieveCorrectStatusCode()
        {
            var responseOk = await _client.GetAsync("/DividersAndPrimes?number=45");
            Assert.Equal("OK", responseOk.StatusCode.ToString());

            var responseBadRequest = await _client.GetAsync("/DividersAndPrimes?number=string");
            Assert.Equal("BadRequest", responseBadRequest.StatusCode.ToString());
        }

        [Fact]
        public async void GetShoudRetrieveCorrectJson()
        {
            var responseOk = await _client.GetAsync("/DividersAndPrimes?number=45");

            string actual = await responseOk.Content.ReadAsStringAsync();
            
            string expected = "{\"entryValue\":45,\"dividers\":\"1 3 5 9 15 45\",\"dividersAndPrimes\":\"3 5\"}";

            Assert.Equal(expected, actual);

        }
    }
}
