using FluentAssertions;
using NUnit.Framework;
using TheInternetApp.PageObjects.MainPage;

namespace TheInternetApp.Tests;

public class MainPageTests
{
    private readonly MainPageObject _mainPageObject;

    public MainPageTests()
    {
        _mainPageObject = new MainPageObject();
    }

    [SetUp]
    public void SetUp()
    {
        _mainPageObject.NavigateTo();
    }

    [Test]
    public void MainHeader_Value()
    {
        _mainPageObject.MainHeader.Text.Should().Be(MainPageConstants.SubheaderValue);
    }

    [Test]
    public void Subheader_Value()
    {
        _mainPageObject.Subheader.Text.Should().Be(MainPageConstants.SubheaderValue);
    }
}
