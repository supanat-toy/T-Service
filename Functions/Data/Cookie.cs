using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using T_Service.Models;


namespace T_Service.Functions
{
    public class Cookie : FunctionsHelper
    {
        // public bool SetCookie(object object_, string cookie_name, int dayNumber)
        // {
        //     if (ClearCookie(cookie_name))
        //     {
        //         dynamic json = JsonConvert.SerializeObject(object_);
        //         //dynamic json_encrypt = securityProvider.Encrypt(json);
        //         var encodeJson = HttpUtility.UrlEncode(json);

        //         HttpCookie cookie = new HttpCookie(cookie_name);
        //         cookie.Value = encodeJson;
        //         cookie.Expires.AddDays(dayNumber);
        //         HttpContext.Current.Response.Cookies.Add(cookie);
                
        //     }
        //     return true;
        // }

        // public bool IsEmptyCookie(string cookie_name)
        // {
        //     return HttpContext.Current.Request.Cookies[cookie_name] == null;
        // }

        // public HttpCookie GetCookie(string cookie_name)
        // {
        //     HttpCookie json_cookie = HttpContext.Current.Request.Cookies[cookie_name];

        //     var decodeJson = "";
        //     if (json_cookie != null)
        //     {
        //         decodeJson = HttpUtility.UrlDecode(json_cookie.Value);
        //     }
            

        //     //var dejson_value = JsonConvert.DeserializeObject<object>(decodeJson);

        //     dynamic cookie = new HttpCookie("abc");
            
        //     if (json_cookie != null)
        //     {
        //         cookie.Expires.AddMinutes(5);
        //         //dynamic decrypt = securityProvider.Decrypt(json_cookie.Value);
        //         cookie.Value = decodeJson;
        //     }
        //     else
        //     {
        //         cookie = null;
        //     }
            
        //     return cookie;
        // }

        // public bool ClearCookie(string cookie_name)
        // {
        //     if (HttpContext.Current.Request.Cookies[cookie_name] != null)
        //     {
        //         var c = new HttpCookie(cookie_name);
        //         c.Expires = DateTime.Now.AddDays(-1);
        //         HttpContext.Current.Response.Cookies.Add(c);
        //     }
        //     return true;
        // }
    }
}