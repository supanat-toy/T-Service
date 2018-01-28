using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;

namespace T_Service.Functions
{
    public class Cache : FunctionsHelper
    {
        // public object GetCacheData(string key)
        // {
        //     return m_httpContextAccessor.HttpContext.Current.Cache[key];
        // }

        // public void SetCacheData(string key, object value, double minute)
        // {
        //     HttpContext.Current.Cache.Insert(key, value, null, DateTime.Now.AddMinutes(minute), TimeSpan.Zero, CacheItemPriority.Default, null);
        // }
    }
}