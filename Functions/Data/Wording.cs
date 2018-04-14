using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;

namespace T_Service.Functions 
{
    public class Wording : FunctionsHelper
    {
        public string insertedDB_succeed = "Insert Successfully";
        public string updatedDB_succeed = "Update Successfully";
        public string deletedDB_succeed = "Delete Successfully";
    }
}