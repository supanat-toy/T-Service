using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;
using T_Service.Providers;

namespace T_Service.Functions
{
    public class Service : FunctionsHelper
    {
        public readonly pCelebrity _qCelebrity;
        public readonly pCustomer _qCustomer;
        public readonly pMovie _qMovie;
        public readonly pUser _qUser;
    }
}