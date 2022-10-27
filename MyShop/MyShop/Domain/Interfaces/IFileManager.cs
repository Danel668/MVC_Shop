using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace MyShop.Domain.Interfaces
{
    public interface IFileManager
    {
        Task<string> SaveImage(IFormFile image);
        bool RemoveImage(string image);
        FileStream ImageStream(string image);
    }
}
