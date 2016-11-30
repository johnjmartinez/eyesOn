using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOn.Interfaces
{
    public interface IPlatformService
    {
        Task<byte[]> ReadFile(string path);
        Task<string> DownloadAndCacheImage(int index, string url);
        Task<byte[]> ReadFileAndResize(string filePath, float iMAGESIZE_THUMB);
        Task<string> CacheImage(byte[] bytes);
    }
}
