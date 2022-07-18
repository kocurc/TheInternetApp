using FluentAssertions;
using NUnit.Framework;
using TheInternetApp.PageObjects.Pages.MainPage;
using TheInternetApp.SystemTests.Base;
using TheInternetApp.Utilities;

namespace TheInternetApp.SystemTests.Pages;

[TestFixture]
public class MainPageTests : BaseTests
{
    private readonly MainPageObject _mainPageObject;

    public MainPageTests()
    {
        _mainPageObject = new MainPageObject(WebDriver);
    }

    [SetUp]
    public void SetUp()
    {
        MyLogger.GetInstance().Info($"Started {GetType()} test.");

        var uri = _mainPageObject.NavigateTo(MainPageConstants.MainPageUri);

        MyLogger.GetInstance().Info($"Managed to navigate to Main page URI: {uri}.");
    }

    [Test(Description = "Main header value")]
    public void MainHeader_Value()
    {
        MyLogger.GetInstance().Info("Started test: Main header value.");
        _mainPageObject.MainHeader?.Text.Should().Be(MainPageConstants.MainHeaderValue);
    }

    [Test(Description = "Subheader value")]
    public void Subheader_Value()
    {
        MyLogger.GetInstance().Info("Started test: Subheader Value.");
        _mainPageObject.Subheader?.Text.Should().Be(MainPageConstants.SubheaderValue);
    }
}
