using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TheInternetApp.PageObjects.Base;

public abstract class BasePageObject
{
    public IWebDriver WebDriver;
    public Actions Action;

    protected BasePageObject(IWebDriver webDriver)
    {
        WebDriver = webDriver;
        Action = new Actions(WebDriver);
    }

    public virtual string NavigateTo(string uri)
    {
        WebDriver.Navigate().GoToUrl(uri);

        return uri;
    }
}
