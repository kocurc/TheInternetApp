using OpenQA.Selenium;

namespace TheInternetApp.PageObjects.Base;

public abstract class BasePageObject
{
    public IWebDriver WebDriver;

    protected BasePageObject(IWebDriver webDriver)
    {
        WebDriver = webDriver;
    }

    public abstract string NavigateTo(string uri);
}
