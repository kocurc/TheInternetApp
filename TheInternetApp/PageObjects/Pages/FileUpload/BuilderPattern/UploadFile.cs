﻿namespace TheInternetApp.PageObjects.Pages.FileUpload.BuilderPattern
{
    public class UploadFile
    {
        public string? Name { get; set; }
        public string? FilePath { get; set; }

        public UploadFile() { }

        public UploadFile(string? name, string? filePath)
        {
            Name = name;
            FilePath = filePath;
        }

        public override string ToString()
        {
            if (Name == null)
            {
                throw new ArgumentNullException(nameof(Name));
            }

            if (FilePath == null)
            {
                throw new ArgumentNullException(nameof(FilePath));
            }

            return Path.Combine(Name, FilePath);
        }
    }
}