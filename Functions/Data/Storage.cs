using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;

namespace T_Service.Functions
{
    public class Storage : FunctionsHelper
    {
        public string userProfile = "up";
        public void ClearSession()
        {
            HttpContext.Session.Clear();
        }
    }
}