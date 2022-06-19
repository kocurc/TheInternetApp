using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace TheInternetApp.Factories;

public static class WebDriverFactory
{
    public static IWebDriver CreateWebDriver(WebBrowserType webBrowserType)
    {
        var webDriverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        switch (webBrowserType)
        {
            case WebBrowserType.GoogleChrome:
                ChromeOptions chromeOptions = new();
                chromeOptions.AddArgument("--headless");
                chromeOptions.AddArgument("--no-sandbox");
                return new ChromeDriver(webDriverPath, chromeOptions);
            case WebBrowserType.MicrosoftEdge:
                EdgeOptions edgeOptions = new();
                edgeOptions.AddArgument("--headless");
                return new EdgeDriver(webDriverPath, edgeOptions);
            default:
                throw new ArgumentOutOfRangeException(nameof(webBrowserType), webBrowserType, null);
        }
    }

    public static IWebDriver CreateWebDriver(string webBrowserType)
    {
        ChromeOptions chromeOptions = new();

        switch (webBrowserType)
        {
            case "GoogleChrome":
                chromeOptions.AddArgument("--headless");
                chromeOptions.AddArgument("--no-sandbox");
                return new ChromeDriver("", chromeOptions);
            case "GoogleChromeHeadful":
                chromeOptions.AddArgument("--no-sandbox");
                return new ChromeDriver("", chromeOptions);
            case "MicrosoftEdge":
                EdgeOptions edgeOptions = new();
                edgeOptions.AddArgument("--headless");
                return new EdgeDriver("", edgeOptions);
            default:
                throw new ArgumentOutOfRangeException(nameof(webBrowserType), webBrowserType, null);
        }
    }
}
