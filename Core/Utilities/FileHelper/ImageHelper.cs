using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileHelper
{
    public class ImageHelper
    {
        public static string UploadImage(IFormFile file, String mainPath)
        {
            var newGuidPath = CreateUniqueName(Path.GetExtension(file.FileName));
            using (FileStream fileStream = System.IO.File.Create(mainPath + newGuidPath))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }

            return newGuidPath;
        }

        public static void DeleteImage(String path)
        {
            File.Delete(path);
        }
        public static string MainPath()
        {
            var path = Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "\\Images\\";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }

        public static string CreateUniqueName(string extension)
        {
            return Guid.NewGuid().ToString("N") + "_MKZ" + extension;
        }
    }
}
