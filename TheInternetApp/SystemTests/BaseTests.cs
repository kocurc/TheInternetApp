using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using TheInternetApp.Factories;
using TheInternetApp.Utilities;

namespace TheInternetApp.SystemTests;

public class BaseTests
{
    public IWebDriver WebDriver { get; init; }

    public BaseTests()
    {
        WebDriver = WebDriverFactory.CreateWebDriver(Environment.GetEnvironmentVariable("WebBrowser") ?? "GoogleChrome");
        MyLogger.GetInstance().Info($"Web driver for browser: {WebDriver} has been created.");
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
        {
            MyLogger.GetInstance().Error($"Test failed. Reason is: {TestContext.CurrentContext.Result.Message}. " +
                                         $"Stack trace: {TestContext.CurrentContext.Result.StackTrace}.");
        }
        else if (TestContext.CurrentContext.Result.Outcome == ResultState.Success)
        {
            MyLogger.GetInstance().Info("Test passed.");
        }
        else
        {
            MyLogger.GetInstance().Error($"Test did not run properly. Reason: {TestContext.CurrentContext.Result.Message}. " +
                                         $"Stack trace: {TestContext.CurrentContext.Result.StackTrace}.");
        }
    }
}
