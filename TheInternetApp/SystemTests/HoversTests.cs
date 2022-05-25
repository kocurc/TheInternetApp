using NUnit.Framework;
using TheInternetApp.PageObjects.Hovers;
using TheInternetApp.Utilities;

namespace TheInternetApp.SystemTests;

public class HoversTests : BaseTests
{
    private bool _disposedValue;
    private HoversPageObject? _hoversPageObject;

    public HoversTests()
    {
        _hoversPageObject = new HoversPageObject(WebDriver);
    }

    [SetUp]
    public void SetUp()
    {
        MyLogger.GetInstance().Info($"Started {this.GetType()} tests.");

        var uri = _hoversPageObject.NavigateTo(HoversPageConstants.HoversPageUriDocker);

        MyLogger.GetInstance().Info($"Managed to navigate to Main page URI: {uri}.");
    }

    [Test(Description = "Given first image - When I click on hover link - Then it redirects me to profile account")]
    public void FirstImage_IClickOnHoverLink_ItRedirectsMeToProfileAccount()
    {
        if (_hoversPageObject == null)
        {
            throw new ArgumentNullException(nameof(_hoversPageObject));
        }

        // Hover over first image
        _hoversPageObject.Action.MoveToElement(_hoversPageObject.FirstImage).Perform();
        MyLogger.GetInstance().Info("Hovered mouse over first user image.");

        // Check if data of first user if displayed


        // Click on first user link


        // Check if redirects page to its profile

    }

    protected override void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            _hoversPageObject = null;
            _disposedValue = true;
        }

        base.Dispose(disposing);
    }
}
