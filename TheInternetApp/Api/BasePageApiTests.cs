using NUnit.Framework;
using NUnit.Framework.Interfaces;
using TheInternetApp.Utilities;

namespace TheInternetApp.Api;
public class BasePageTests
{
    public BasePageTests()
    {

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
