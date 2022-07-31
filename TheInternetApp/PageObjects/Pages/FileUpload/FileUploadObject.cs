using OpenQA.Selenium;
using TheInternetApp.PageObjects.Base;
using TheInternetApp.PageObjects.Pages.FileUpload.BuilderPattern;
using TheInternetApp.PageObjects.Pages.FileUpload.FileUploader;
using TheInternetApp.PageObjects.Pages.FileUpload.FileUploader.OpenClosedPrinciple;

namespace TheInternetApp.PageObjects.Pages.FileUpload
{
    public class FileUploadObject : BasePageObject
    {
        // SOLID. Open Close Principle
        private readonly IFileUploader _fileUploader;
        public UploadFile UploadFile { get; set; } = null!;

        public FileUploadObject(IWebDriver webDriver, IFileUploader fileUploader) : base(webDriver)
        {
            _fileUploader = fileUploader;
        }

        public void Upload()
        {
            _fileUploader.Upload(UploadFile);
        }
    }
}
