using OpenQA.Selenium;

namespace TheInternetApp.PageObjects.Base;

public abstract class BasePageObject
{
    public IWebDriver? WebDriver;

    public abstract void NavigateTo();
}
