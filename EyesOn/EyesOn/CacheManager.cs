using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.IO;

using EyesOn.Interfaces;

namespace EyesOn
{
    public class CacheManager
    {
        public static float IMAGESIZE_THUMB = 100f;
        private static CacheManager _instance;
        public static CacheManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CacheManager();
                }
                return _instance;
            }
        }

        Dictionary<string, string> _dictCacheImages;
        int _index;
        IPlatformService _platformService;

        public CacheManager()
        {
            _dictCacheImages = new Dictionary<string, string>();
            _index = 0;
        }
        public void Init(IPlatformService platformService)
        {
            _platformService = platformService;
        }
        public async Task<byte[]> LoadImageData(string url, bool isNeededResize)
        {
            string filePath = null;
            if (_dictCacheImages.ContainsKey(url))
            {
                string value = null;
                bool result = _dictCacheImages.TryGetValue(url, out value);
                if (result)
                {
                    filePath = value;
                }
            }
            else
            {
                _index++;
                filePath = await _platformService.DownloadAndCacheImage(_index, url);
                if (filePath != null)
                {
                    if (_dictCacheImages.ContainsKey(url))
                    {
                        _dictCacheImages.Remove(url);
                    }
                    _dictCacheImages.Add(url, filePath);
                }
            }

            if (filePath != null)
            {
                if (isNeededResize)
                {
                    return await _platformService.ReadFileAndResize(filePath, IMAGESIZE_THUMB);
                }
                else
                {
                    return await _platformService.ReadFile(filePath);
                }
            }
            return null;
        }

        public async Task<byte[]> CacheImageAndResize(string urlPicture, byte[] bits)
        {
            if (_dictCacheImages.ContainsKey(urlPicture))
            {
                _dictCacheImages.Remove(urlPicture);
            }
            string filePath = await _platformService.CacheImage(bits);
            if (filePath != null)
            {
                _dictCacheImages.Add(urlPicture, filePath);
            }
            return await _platformService.ReadFileAndResize(filePath, IMAGESIZE_THUMB);
        }
    }
}
