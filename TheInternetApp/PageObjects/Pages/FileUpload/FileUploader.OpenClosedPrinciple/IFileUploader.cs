using TheInternetApp.PageObjects.Pages.FileUpload.BuilderPattern;

namespace TheInternetApp.PageObjects.Pages.FileUpload.FileUploader.OpenClosedPrinciple;

public interface IFileUploader
{
    void Upload(UploadFile uploadFile);
}
