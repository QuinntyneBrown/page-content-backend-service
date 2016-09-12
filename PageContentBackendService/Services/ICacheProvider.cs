using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PageContentBackendService.Services
{
    public interface ICacheProvider
    {
        ICache GetCache();
    }
}
