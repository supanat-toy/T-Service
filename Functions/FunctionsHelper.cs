using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;
using T_Service.Data;
using T_Service.Providers;

namespace T_Service.Functions
{
    public class FunctionsHelper : Controller 
    {
        protected static readonly API _api = new API();
        protected static readonly Cache _cache = new Cache();
        protected static readonly Cookie _cookie = new Cookie();
        protected static readonly Email _email = new Email();
        protected static readonly Format _format = new Format();
        protected static readonly Image _image = new Image();
        protected static readonly Security _security = new Security();
        protected static readonly Storage _storage = new Storage();
        protected static readonly User _user = new User();
        protected static readonly Wording _wording = new Wording();
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

        
