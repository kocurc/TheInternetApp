using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace TheInternetApp.Factories;

public static class WebDriverFactory
{
    public static IWebDriver CreateWebDriver(WebBrowserType webBrowserType)
    {
        switch (webBrowserType)
        {
            case WebBrowserType.GoogleChrome:
                ChromeOptions chromeOptions = new();
                chromeOptions.AddArgument("--headless");
                return new ChromeDriver("./", chromeOptions);
            case WebBrowserType.MicrosoftEdge:
                EdgeOptions edgeOptions = new();
                edgeOptions.AddArgument("--headless");
                return new EdgeDriver("./", edgeOptions);
            default:
                throw new ArgumentOutOfRangeException(nameof(webBrowserType), webBrowserType, null);
        }
    }
}
