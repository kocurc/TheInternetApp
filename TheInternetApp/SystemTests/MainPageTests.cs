﻿using FluentAssertions;
using NUnit.Framework;
using TheInternetApp.PageObjects.MainPage;

namespace TheInternetApp.SystemTests;

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
        var uri = _mainPageObject.NavigateTo(MainPageObject.Uri);

        Logger.Info($"Managed to navigate to Main page URI: {uri}.");
    }

    [Test(Description = "Main header value")]
    public void MainHeader_Value()
    {
        Logger.Info("Stared test: Main header value.");
        _mainPageObject.MainHeader.Text.Should().Be(MainPageConstants.MainHeaderValue);
    }

    [Test(Description = "Subheader value")]
    public void Subheader_Value()
    {
        Logger.Info("Stared test: Subheader Value.");
        _mainPageObject.Subheader.Text.Should().Be(MainPageConstants.SubheaderValue);
    }
}
