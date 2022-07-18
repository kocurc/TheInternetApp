using OpenQA.Selenium;
using TheInternetApp.PageObjects.Base;
using TheInternetApp.PageObjects.Pages.FileUpload.FileUploader;

namespace TheInternetApp.PageObjects.Pages.FileUpload
{
    public class HorizontalSliderObject : BasePageObject
    {
        // Open Close Principle
        private readonly IFileUploader _fileUploader;
        public UploadFile UploadFile { get; set; } = null!;

        public HorizontalSliderObject(IWebDriver webDriver, IFileUploader fileUploader) : base(webDriver)
        {
            _fileUploader = fileUploader;
        }

        public void Upload()
        {
            _fileUploader.Upload(UploadFile);
        }
    }
}
