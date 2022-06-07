using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using TheInternetApp.Factories;
using TheInternetApp.Utilities;

namespace TheInternetApp.SystemTests;

public class BaseTests : IDisposable
{
    private bool _disposedValue;

    public IWebDriver WebDriver { get; init; }

    public BaseTests()
    {
        var x = Environment.GetEnvironmentVariable("WebBrowser");

        WebDriver = WebDriverFactory.CreateWebDriver(Environment.GetEnvironmentVariable("WebBrowser") ??
                                                     "GoogleChromeHeadful");
        MyLogger.GetInstance().Info($"Web driver for browser: {WebDriver} has been created.");
    }

    ~BaseTests()
    {
        Dispose(false);
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
    
    protected virtual void Dispose(bool disposing)
    {
        // If true - do not allow redundant Dispose calls.
        if (_disposedValue)
        {
            return;
        }

        // If true - release managed resources.
        if (disposing) 
        {
            WebDriver.Close();
            WebDriver.Quit();
            WebDriver.Dispose();
        }

        // Space for Dispose(false) - where unmanaged resources should be released, like File handles
        // And large fields set to null as well.

        _disposedValue = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
