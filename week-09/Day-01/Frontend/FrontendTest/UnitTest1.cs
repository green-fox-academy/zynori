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

        [Fact]
        public async Task ShouldGetNotFoundDoubling()
        {
            var response = await Client.GetAsync("/doublinger");
            var statusCode = response.StatusCode;
            Assert.Equal(HttpStatusCode.NotFound, statusCode);
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

        [Theory]
        [InlineData("Bela", "ghost")]
        [InlineData("Jeno", "duck")]
        public async Task ShouldGetNameAndTitle(string name, string title)
        {
            var response = await Client.GetAsync($"/greeter?={name}&title={title}");

            Assert.Equal(JsonConvert.SerializeObject(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" }),
                response.Content.ReadAsStringAsync().Result);
        }

        [Fact]
        public async Task ShouldMissName()
        {
            var response = await Client.GetAsync($"/greeter?title=student");

            Assert.Equal(JsonConvert.SerializeObject(new { error = "Please provide both the name and the title!" }),
                response.Content.ReadAsStringAsync().Result);
        }
    }
}
