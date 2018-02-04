using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;
using T_Service.Data;

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
        protected readonly T_ServiceContext _db;
        public FunctionsHelper()
        {
            
        }
        public FunctionsHelper(T_ServiceContext db)
        {
            _db = db;
        }
    }
    
}

        
