using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using QuanLyKVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyKVC.Controllers.Core
{
    public interface ICacheHelper
    {
        Dictionary<string, Khutrochoi> GetSystemConfig();
        void SetSystemConfig(List<Khutrochoi> khutrochois);
        void SetSystemConfig(Dictionary<string, Khutrochoi> khutrochois);
    }
    public class CacheHelper : ICacheHelper
    {
        private readonly MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());
        //System config
        public Dictionary<string, Khutrochoi> GetSystemConfig()
        {
            Dictionary<string, Khutrochoi> obj = null;
            _cache.TryGetValue<string>("Khutrochoi", out var json);

            if (json != null)
            {
                obj = JsonConvert.DeserializeObject<Dictionary<string, Khutrochoi>>(json);
            }

            return obj;
        }
        public void SetSystemConfig(List<Khutrochoi> khutrochois)
        {
            SetSystemConfig(khutrochois.ToDictionary(p => p.MaKhu));
        }
        public void SetSystemConfig(Dictionary<string, Khutrochoi> khutrochois)
        {
            var json = JsonConvert.SerializeObject(khutrochois);
            _cache.Set("Khutrochoi", json);
        }
    }

       
}