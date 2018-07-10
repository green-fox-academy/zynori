using Frontend;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace FrontendTest
{
    public class UnitTest1
    {
        private HttpClient Client { get; set; }
        private TestServer Server { get; set; }

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Theory]
        [InlineData(1)]
        public void Test1(int input)
        {
            Assert.True(input < 10);
        }

        [Fact]
        public async Task ShouldGetDoubling()
        {
            //arrange
            var response = await Client.GetAsync("/doubling");
            //act
            var statusCode = response.StatusCode;
            //assert
            Assert.Equal(HttpStatusCode.OK, statusCode);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(987)]
        public async Task ShouldGetDoubledNumber(int input)
        {
            var response = await Client.GetAsync($"/doubling?={input}");

            Assert.Equal(JsonConvert.SerializeObject(new { received = input, result = input * 2 }),
                response.Content.ReadAsStringAsync().Result);
        }
    }
}
