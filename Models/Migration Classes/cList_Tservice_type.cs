

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cList_Tservice_type
    {
        public cList_Tservice_type()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        public long Tservice_type_id { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }

    }
}