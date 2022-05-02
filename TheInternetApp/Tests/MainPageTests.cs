using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using TheInternetApp.Factories;
using TheInternetApp.PageObjects.MainPage;

namespace TheInternetApp.Tests;

[TestFixture]
public class MainPageTests
{
    private readonly MainPageObject _mainPageObject;

    public IWebDriver WebDriver { get; init; }

    public MainPageTests()
    {
        WebDriver = WebDriverFactory.CreateWebDriver(Environment.GetEnvironmentVariable("WebBrowser") ?? "GoogleChrome");
        _mainPageObject = new MainPageObject(WebDriver);
    }

    [SetUp]
    public void SetUp()
    {
        _mainPageObject.NavigateTo();
    }

    [Test]
    public void MainHeader_Value()
    {
        _mainPageObject.MainHeader.Text.Should().Be(MainPageConstants.MainHeaderValue);
    }

    [Test]
    public void Subheader_Value()
    {
        _mainPageObject.Subheader.Text.Should().Be(MainPageConstants.SubheaderValue);
    }
}
