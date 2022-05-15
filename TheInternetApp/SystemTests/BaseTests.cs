using NLog;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using TheInternetApp.Factories;

namespace TheInternetApp.SystemTests;

public class BaseTests
{
    protected static readonly Logger Logger = LogManager.GetLogger("myAppLoggerRules");

    public IWebDriver WebDriver { get; init; }

    public BaseTests()
    {
        Logger.Info("Started Main page tests.");
        WebDriver = WebDriverFactory.CreateWebDriver(Environment.GetEnvironmentVariable("WebBrowser") ?? "GoogleChrome");
        Logger.Info($"Web driver for browser: {WebDriver} has been created.");
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
        {
            Logger.Error($"Test failed. Reason is: {TestContext.CurrentContext.Result.Message}. " +
                         $"Stack trace: {TestContext.CurrentContext.Result.StackTrace}.");
        }
        else if (TestContext.CurrentContext.Result.Outcome == ResultState.Success)
        {
            Logger.Info("Test passed.");
        }
        else
        {
            Logger.Error($"Test did not run properly. Reason: {TestContext.CurrentContext.Result.Message}. " +
                         $"Stack trace: {TestContext.CurrentContext.Result.StackTrace}.");
        }
    }
}
