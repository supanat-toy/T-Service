

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cTservice_work
    {
        public cTservice_work()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        [Key]
        public long Tservice_type_id { get; set; }
        public DateTime created_datetime { get; set; }
        public DateTime updated_datetime { get; set; }

    }
}