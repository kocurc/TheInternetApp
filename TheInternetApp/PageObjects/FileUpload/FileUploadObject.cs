using OpenQA.Selenium;
using TheInternetApp.PageObjects.Base;

namespace TheInternetApp.PageObjects.FileUpload
{
    public class HorizontalSliderObject : BasePageObject
    {
        private UploadFile UploadFile { get; set; } = null!;

        public HorizontalSliderObject(IWebDriver webDriver) : base(webDriver) { }
    }
}
