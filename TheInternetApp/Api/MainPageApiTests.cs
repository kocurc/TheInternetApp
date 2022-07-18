using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using TheInternetApp.PageObjects.Pages.MainPage;
using TheInternetApp.Utilities;

namespace TheInternetApp.Api;

public class MainPageApiTests  : BasePageTests
{

    public IRestApiExecutor<RestResponse> RestClient { get; init; }

    public MainPageApiTests()
    {
        RestClient = new RestSharpRestApiExecutor();
    }

    [SetUp]
    public void SetUp()
    {
        MyLogger.GetInstance().Info($"Started {this.GetType()} test.");
    }

    [Test(Description = "Given Main page - When I request it with GET method - Then status is OK")]
    public async Task MainPageIRequestItWithGetMethodStatusIsOk()
    {
        await RestClient.ExecuteAsyncGetMethod(MainPageConstants.MainPageUri);

        MyLogger.GetInstance().Info($"Checking basic status values of main page GET response.");
        RestClient.StatusCode.Should().Be("200");
        RestClient.ResponseStatus.Should().Be("Completed");
        RestClient.ContentType.Should().Be("text/html");
    }
}
