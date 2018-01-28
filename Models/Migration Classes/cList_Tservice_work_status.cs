

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cList_Tservice_work_status
    {
        public cList_Tservice_work_status()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        public long list_Tservice_work_status_id { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }

    }
}