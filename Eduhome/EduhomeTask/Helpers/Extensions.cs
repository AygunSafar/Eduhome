﻿using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.Web.CodeGeneration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace EduhomeTask.Helpers
{
    public static class Extensions
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }
        public static bool IsOlder1MB(this IFormFile file)
        {
            return file.Length > 1024 * 1024;
        }

        public static async Task<string> SaveFileAsync(this IFormFile file, string folder)
        {
            string filename = Guid.NewGuid()+file.FileName;
            string path = Path.Combine(folder, filename);
            using (FileStream fileStream = new FileStream(path,FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return filename;

        }

    }
}
