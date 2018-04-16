using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;

namespace T_Service.Functions
{
    public class API : FunctionsHelper
    {
        public string authorization = "123";
        public int getA(int a) {
            return a;
        }
    }
}