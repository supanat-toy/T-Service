using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;
using T_Service.Functions;

namespace T_Service.Controllers
{
    public class A_CelebrityController : FunctionsHelper
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}