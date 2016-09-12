using PageContentBackendService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PageContentBackendService.Services
{
    public class CacheProvider : ICacheProvider
    {
        public ICache GetCache()
        {
            return MemoryCache.Current;
        }
    }
}
