namespace TheInternetApp.PageObjects.Pages.FileUpload.BuilderPattern
{
    public class UploadFileBuilder
    {
        private readonly UploadFile _uploadFile = new UploadFile();

        public void SetFileName(string fileName)
        {
            _uploadFile.Name = fileName;
        }

        public void SetFilePath(string filePath)
        {
            _uploadFile.FilePath = filePath;
        }
    }
}
