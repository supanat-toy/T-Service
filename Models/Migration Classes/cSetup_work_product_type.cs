
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cSetup_work_product_type
    {
        public cSetup_work_product_type()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        public long setup_work_product_type_id { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }
        public string description { get; set; }
        public string remark { get; set; }
    }
}