using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class mResult
    {
        public mResult()
        {
            isSucceed = false;
            message = "N/A";
        }

        public bool isSucceed { get; set; }
        public string message { get; set; }

    }
}