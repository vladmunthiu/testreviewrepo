using RestSharp;
using System;
using Xunit;

namespace SampleApplication.FunctionalTests
{
    public class UnitTest1
    {
        [Fact]
        public void CallFuntion1WithParams()
        {
            var client = new RestClient("https://sampleapp-dev.azurewebsites.net/");
            var request = new RestRequest("api/Function1?code=b0DHJDALasLuuAEE7b/j/6t6NsWST4gXGK6VZ7MYrqbITwa1bTp4WQ==&name=Bill", Method.GET);
            var result = client.Execute(request);
            Assert.Equal("\"Hello Bill! Welcome to Azure Functions!\"", result.Content);
        }

        [Fact]
        public void CallFuntion1WithoutParams()
        {
            var client = new RestClient("https://sampleapp-dev.azurewebsites.net/");
            var request = new RestRequest("api/Function1?code=b0DHJDALasLuuAEE7b/j/6t6NsWST4gXGK6VZ7MYrqbITwa1bTp4WQ==", Method.GET);
            var result = client.Execute(request);
            Assert.Equal("\"Hello there! Welcome to Azure Functions!\"", result.Content);
        }
    }
}
