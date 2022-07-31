using OpenQA.Selenium.DevTools.V101.Browser;

namespace TheInternetApp.PageObjects.Pages.FileUpload.BuilderPattern
{
    public class UploadFileBuilder
    {
        private readonly UploadFile _uploadFile = new UploadFile();

        public UploadFile Build()
        {
            return _uploadFile;
        }

        public UploadFileBuilder SetFileName(string fileName)
        {
            _uploadFile.Name = fileName;

            return this;
        }

        public UploadFileBuilder SetFilePath(string filePath)
        {
            _uploadFile.FilePath = filePath;

            return this;
        }
    }
}
