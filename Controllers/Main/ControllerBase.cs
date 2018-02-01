using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;
using T_Service.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace T_Service.Controllers
{
    [Authorize]
    public class ControllerBase : Controller
    {
        protected readonly T_ServiceContext _db;
        public ControllerBase(T_ServiceContext db)
        {
            _db = db;
        }
        
        protected void ClearSession()
        {
            HttpContext.Session.Clear();
        }
    }
} 