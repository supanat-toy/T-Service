using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;
using T_Service.Functions;
using T_Service.Providers;

namespace T_Service.Functions
{
    public class Service : FunctionsHelper
    {
        public readonly pMember _pMember;
        public readonly pSetup_work _pSetup_work;
        public readonly pDelivery_work _pDelivery_work;
    }
}