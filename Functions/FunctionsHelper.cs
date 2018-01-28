using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;

namespace T_Service.Functions
{
    public class FunctionsHelper: Controller 
    {
        protected readonly API _api;
        protected readonly Cache _cache;
        protected readonly Cookie _cookie;
        protected readonly Email _email;
        protected readonly Format _format;
        protected readonly Image _image;
        protected readonly Security _security;
        protected readonly Storage _storage;
        protected readonly User _user;
        protected readonly Service _service;
        public void a(){
            string a = _api.authorization;
        }

        // protected readonly Microsoft.AspNetCore.Http.IHttpContextAccessor m_httpContextAccessor;
        // public static void Configure(Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor)
        // {
        //     m_httpContextAccessor = httpContextAccessor;
        // }
        // public static Microsoft.AspNetCore.Http.HttpContext Current
        // {
        //     get
        //     {
        //         return m_httpContextAccessor.HttpContext;
        //     }
        // }
       
    }
    
}

        
