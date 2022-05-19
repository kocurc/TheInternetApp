using OpenQA.Selenium;
using TheInternetApp.PageObjects.Base;

namespace TheInternetApp.PageObjects.Hovers;

public class HoversPageObject : BasePageObject
{
    #region PageElementsLocators

    private readonly By _firstImageLocator;
    private readonly By _secondImageLocator;
    private readonly By _thirdImageLocator;
    private readonly By _userNameHeaderLocator;
    private readonly By _userViewLinkLocator;

    #endregion

    #region PageElements

    public IWebElement FirstImage => WebDriver.FindElement(_firstImageLocator);
    public IWebElement SecondImage => WebDriver.FindElement(_secondImageLocator);
    public IWebElement ThirdImage => WebDriver.FindElement(_thirdImageLocator);
    public IWebElement UserNameHeader => WebDriver.FindElement(_userNameHeaderLocator);
    public IWebElement UserViewLink => WebDriver.FindElement(_userViewLinkLocator);

    #endregion

    public HoversPageObject(IWebDriver webDriver) : base(webDriver)
    {
        _firstImageLocator = By.ClassName("");
        _secondImageLocator = By.ClassName("");
        _thirdImageLocator = By.ClassName("");
        _userNameHeaderLocator = By.ClassName("");
        _userViewLinkLocator = By.ClassName("");

    }
}
