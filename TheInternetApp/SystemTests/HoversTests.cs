using FluentAssertions;
using NUnit.Framework;
using TheInternetApp.PageObjects.Hovers;
using TheInternetApp.Utilities;

namespace TheInternetApp.SystemTests;

public class HoversTests : BaseTests
{
    private bool _disposedValue;
    private HoversPageObject? _hoversPageObject;

    public HoversTests()
    {
        _hoversPageObject = new HoversPageObject(WebDriver);
    }

    [SetUp]
    public void SetUp()
    {
        MyLogger.GetInstance().Info($"Started {this.GetType()} test.");

        var uri = _hoversPageObject?.NavigateTo(HoversPageConstants.HoversPageUri);

        MyLogger.GetInstance().Debug($"Structure of tests: {_hoversPageObject}.");
        MyLogger.GetInstance().Info($"Managed to navigate to Main page URI: {uri}.");
    }

    [Test(Description = "Given First image - When I hover it - Then It shows user name and link to his profile")]
    public void FirstImage_IClickOnHoverLink_ItRedirectsMeToProfileAccount()
    {
        const int userImageIndex = 0;

        MyLogger.GetInstance()
            .Info(
                "Started test: Given first image - When I hover it - Then it shows user name and link to his profile.");
        MyLogger.GetInstance().Info($"Is element displayed: {_hoversPageObject?[userImageIndex].Displayed}.");
        _hoversPageObject?.MoveToElement(_hoversPageObject[userImageIndex]);
        MyLogger.GetInstance().Info("Checking the display state of User name header.");
        _hoversPageObject?.UserNameHeaders.ElementAt(userImageIndex).Displayed.Should().BeTrue();
        MyLogger.GetInstance().Info("Checking the display state of User view link.");
        _hoversPageObject?.UserViewsLinks.ElementAt(userImageIndex).Displayed.Should().BeTrue();

        var userName = _hoversPageObject?.GetUserName(userImageIndex);

        MyLogger.GetInstance().Info($"Checking the correctness of user name value of index: {userImageIndex}.");
        userName.Should().Be(HoversPageConstants.FirstUserName);
    }

    [Test(Description = "Given Second image - When I hover it - Then It shows user name and link to his profile")]
    public void SecondImage_IClickOnHoverLink_ItRedirectsMeToProfileAccount()
    {
        _hoversPageObject = new HoversPageObject(WebDriver);

        const int userImageIndex = 1;

        MyLogger.GetInstance()
            .Info(
                "Started test: Given Second image - When I hover it - Then It shows user name and link to his profile.");
        _hoversPageObject?.MoveToElement(_hoversPageObject[userImageIndex]);
        MyLogger.GetInstance().Info("Hovered mouse over second user image.");
        MyLogger.GetInstance().Info("Checking the display state of User name header.");
        _hoversPageObject?.UserNameHeaders.ElementAt(userImageIndex).Displayed.Should().BeTrue();
        MyLogger.GetInstance().Info("Checking the display state of User view link.");
        _hoversPageObject?.UserViewsLinks.ElementAt(userImageIndex).Displayed.Should().BeTrue();

        var userName = _hoversPageObject?.GetUserName(userImageIndex);

        MyLogger.GetInstance().Info($"Checking the correctness of user name value of index: {userImageIndex}.");
        userName.Should().Be(HoversPageConstants.SecondUserName);
    }

    [Test(Description = "Given Third image - When I hover it - Then It shows user name and link to his profile")]
    public void ThirdImage_IClickOnHoverLink_ItRedirectsMeToProfileAccount()
    {
        _hoversPageObject = new HoversPageObject(WebDriver);

        const int userImageIndex = 2;

        MyLogger.GetInstance()
            .Info(
                "Started test: Given Third image - When I hover it - Then It shows user name and link to his profile.");
        MyLogger.GetInstance().Info($"Is element displayed: {_hoversPageObject?[userImageIndex].Displayed}.");
        _hoversPageObject?.MoveToElement(_hoversPageObject[userImageIndex]);
        MyLogger.GetInstance().Info("Hovered mouse over first user image.");
        MyLogger.GetInstance().Info("Checking the display state of User name header.");
        _hoversPageObject?.UserNameHeaders.ElementAt(userImageIndex).Displayed.Should().BeTrue();
        MyLogger.GetInstance().Info("Checking the display state of User view link.");
        _hoversPageObject?.UserViewsLinks.ElementAt(userImageIndex).Displayed.Should().BeTrue();

        var userName = _hoversPageObject?.GetUserName(userImageIndex);

        MyLogger.GetInstance().Info($"Checking the correctness of user name value of index: {userImageIndex}.");
        userName.Should().Be(HoversPageConstants.ThirdUserName);
    }

    protected override void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            _hoversPageObject = null;
            _disposedValue = true;
        }

        base.Dispose(disposing);
    }
}
