using System.Net;
using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using TheInternetApp.PageObjects.MainPage;
using TheInternetApp.Utilities;

namespace TheInternetApp.Api;

public class MainPageApiTests  : BasePageTests
{

    public RestClient RestClient { get; init; }

    public MainPageApiTests()
    {
        RestClient = new RestClient(MainPageConstants.MainPageUri);
    }

    [SetUp]
    public void SetUp()
    {
        MyLogger.GetInstance().Info($"Started {this.GetType()} test.");
    }

    [Test(Description = "Given Main page - When I request it with GET method - Then status is OK")]
    public async Task MainPageIRequestItWithGetMethodStatusIsOk()
    {
        RestRequest restRequest = new RestRequest("", Method.Get);
        RestResponse restResponse = await RestClient.ExecuteAsync(restRequest);

        MyLogger.GetInstance().Info($"Checking basic status values of main page GET response.");
        restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        restResponse.ResponseStatus.Should().Be(ResponseStatus.Completed);
        restResponse.ContentType.Should().Be("text/html");
    }
}
