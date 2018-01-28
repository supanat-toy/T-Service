

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cTservice_work_employee
    {
        public cTservice_work_employee()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        public long Tservice_work_id { get; set; }
        public long employee_id { get; set; }
    }
}