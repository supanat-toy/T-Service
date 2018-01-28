

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cList_evaluated_question
    {
        public cList_evaluated_question()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        public long evaluated_question_id { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }
        public double version_number { get; set; }
        public bool hasChoice { get; set; }
        public long Tservice_type_id { get; set; }
        public bool isActive { get; set; }
        public DateTime created_datetime { get; set; }
        public DateTime updated_datetime { get; set; }
    }
}