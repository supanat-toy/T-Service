using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;

namespace T_Service.Functions
{
    public class Service : FunctionsHelper
    {
        public readonly qCelebrity _qCelebrity;
        public readonly qCustomer _qCustomer;
        public readonly qMovie _qMovie;
        public readonly qUser _qUser;
    }
}