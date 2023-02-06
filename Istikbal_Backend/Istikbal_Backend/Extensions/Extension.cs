using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using System;

namespace Istikbal_Backend.Extensions
{
    public static class Extension
    {
        public static async Task<string> SaveFile(this IFormFile formfile, IWebHostEnvironment env, string folder)
        {
            string path = env.WebRootPath;
            string filename = Guid.NewGuid().ToString() + formfile.FileName;
            string result = Path.Combine(path, folder, filename);

            using (FileStream fileStream = new FileStream(result, FileMode.Create))
            {
                await formfile.CopyToAsync(fileStream);
            }
            return filename;

        }
        public static void Deletemage(string path)
        {
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            };
        }
        public static string Savemage(this IFormFile file, IWebHostEnvironment env, string folder)
        {
            string filename = Guid.NewGuid().ToString() + file.FileName;
            string path = Path.Combine(env.WebRootPath, folder, filename);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            };
            return filename;
        }
    }
}
