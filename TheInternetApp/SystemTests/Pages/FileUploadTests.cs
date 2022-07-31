using NUnit.Framework;
using TheInternetApp.PageObjects.Pages.FileUpload;
using TheInternetApp.PageObjects.Pages.FileUpload.BuilderPattern;
using TheInternetApp.PageObjects.Pages.FileUpload.FileUploader.OpenClosedPrinciple;
using TheInternetApp.SystemTests.Base;

namespace TheInternetApp.SystemTests.Pages
{
    public class FileUploadTests : BaseTests
    {
        private readonly FileUploadObject _chooseFileUploadObject;
        private readonly FileUploadObject _dragAndDropFileUploadObject;
        private readonly UploadFileBuilder _uploadFileBuilder = new UploadFileBuilder();

        public FileUploadTests()
        {

            _chooseFileUploadObject = new FileUploadObject(WebDriver, new ChooseFileUploader());
            _dragAndDropFileUploadObject = new FileUploadObject(WebDriver, new DragAndDropFileUploader());
        }

        [Test(Description = "Given File - When I choose it - Then The file name is visible")]
        public void File_IChooseIt_TheFileNameIsVisible()
        {
            UploadFile uploadFile = _uploadFileBuilder.SetFileName("").SetFilePath("").Build();
        }
    }
}
