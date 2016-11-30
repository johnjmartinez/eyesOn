using System;
using System.Net;
using System.Threading.Tasks;

using Android.Graphics;
using Android.Content;

using Java.IO;

using EyesOn.Interfaces;

namespace EyesOn.UI.Droid
{
    public class DroidPlatformService : IPlatformService
    {
        private Context _context;
        public DroidPlatformService(Context context)
        {
            _context = context;
        }

        #region IPlatformService implementation

        public async Task<byte[]> ReadFile(string path)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(path);
            return bytes;
        }

        public async Task<string> DownloadAndCacheImage(int index, string url)
        {
            var outputFile = CreateTempFile();

            var httpReq = (HttpWebRequest)WebRequest.Create(new Uri(url));
            httpReq.Method = "GET";
            using (var response = await httpReq.GetResponseAsync())
            {
                using (System.IO.Stream s = response.GetResponseStream())
                {
                    using (System.IO.FileStream fileStream = System.IO.File.OpenWrite(outputFile.AbsolutePath))
                    {
                        await s.CopyToAsync(fileStream);
                        await s.FlushAsync();
                        await fileStream.FlushAsync();
                    }
                }
            }

            return outputFile.AbsolutePath;
        }

        public async Task<string> CacheImage(byte[] bytes)
        {
            var outputFile = CreateTempFile();
            System.IO.MemoryStream s = new System.IO.MemoryStream(bytes);
            using (System.IO.FileStream fileStream = System.IO.File.OpenWrite(outputFile.AbsolutePath))
            {
                await s.CopyToAsync(fileStream);
                await s.FlushAsync();
                await fileStream.FlushAsync();
            }
            return outputFile.AbsolutePath;
        }

        public async Task<byte[]> ReadFileAndResize(string filePath, float IMAGESIZE_THUMB)
        {
            Bitmap bitmap = await BitmapFactory.DecodeFileAsync(filePath);
            Bitmap resizedBitmap = Bitmap.CreateScaledBitmap(bitmap, (int)IMAGESIZE_THUMB, (int)IMAGESIZE_THUMB, false);
            bitmap.Recycle();

            byte[] bytes = BitmapToByteArray(resizedBitmap);
            resizedBitmap.Recycle();
            return bytes;
        }

        byte[] BitmapToByteArray(Bitmap bitmap)
        {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            bitmap.Compress(Bitmap.CompressFormat.Png, 0, stream);
            byte[] bitmapData = stream.ToArray();
            return bitmapData;
        }
        
        File CreateTempFile()
        {
            File outputDir = _context.CacheDir;
            File outputFile = File.CreateTempFile("image_cache", "png");
            return outputFile;
        }
        #endregion
    }
}