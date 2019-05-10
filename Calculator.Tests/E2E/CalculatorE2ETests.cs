using Calculator.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using Xunit;

namespace Calculator.Tests.E2E
{
    public class CalculatorE2ETests
    {
        private TestServer _host;
        private HttpClient _client;

        public CalculatorE2ETests()
        {
            _host = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());

            _client = _host.CreateClient();
        }

        [Fact]
        public async void CanHit_LandingEndpoint()
        {
            // Arrange
            string expected = "Welcome to the Calculator App. Visit /add/{num1},{num2} to add the two numbers. Visit /subtract/{num1},{num2} to subtract the two numbers.";

            // Act
            var response = await _client.GetAsync("/api/calculator");
            response.EnsureSuccessStatusCode();

            string actual = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void CanHit_AddEndpoint_AndGet_CorrectResult_1_2()
        {
            // Arrange
            string expected = "3.0";

            // Act
            var response = await _client.GetAsync("/api/calculator/add/1,2");
            response.EnsureSuccessStatusCode();

            string actual = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void CanHit_SubtractEndpoint_AndGet_CorrectResult_6_3()
        {
            // Arrange
            string expected = "3.0";

            // Act
            var response = await _client.GetAsync("/api/calculator/subtract/6,3");
            response.EnsureSuccessStatusCode();

            string actual = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
