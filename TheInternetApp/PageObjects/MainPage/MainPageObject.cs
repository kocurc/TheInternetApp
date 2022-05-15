using OpenQA.Selenium;
using TheInternetApp.PageObjects.Base;

namespace TheInternetApp.PageObjects.MainPage;

public class MainPageObject : BasePageObject
{
    public const string Uri = MainPageConstants.MainPageUriDocker;

    #region PageElementsLocators

    private readonly By _mainHeaderLocator;
    private readonly By _subheaderLocator;

    #endregion

    #region PageElements

    public IWebElement MainHeader => WebDriver.FindElement(_mainHeaderLocator);
    public IWebElement Subheader => WebDriver.FindElement(_subheaderLocator);

    #endregion

    public MainPageObject(IWebDriver webDriver) : base(webDriver)
    {
        _mainHeaderLocator = By.ClassName(MainPageConstants.MainHeaderClassName);
        _subheaderLocator = By.TagName("h2");
    }

    public override string NavigateTo(string uri)
    {
        WebDriver.Navigate().GoToUrl(uri);

        return uri;
    }
}
