using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Company.Service.Helper
{
    public class DocumentSettings
    {
        public static string UploadFile(IFormFile file, string folderName)
        {
            // 1.Get folder path:
            //var folderPath = @"D:\Backend\C#\C#\DotNetC#Assignments\Company.Web\wwwroot\Files\Images\"; // Problems on the server
                
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", folderName);

            // 2.Get File Name:
            //var fileName = file.FileName; // May problems -> more than file with same name => make the name unique to solve it.
            var fileName = $"{Guid.NewGuid} - {file.FileName}";

            // 3. Combine folder path to file path:
            var filePath = Path.Combine(folderPath, fileName);

            // 4. save the file:
            using var fileStream = new FileStream(filePath, FileMode.Create);

            file.CopyTo(fileStream);

            return fileName;
        }
    }
}
