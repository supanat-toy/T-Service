


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cList_evaluated_question_choice
    {
        public cList_evaluated_question_choice()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        public long evaluated_questtion_choice_id { get; set; }
        public double version_number { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }
        public DateTime created_datetime { get; set; }
        public DateTime updated_datetime { get; set; }
    }
}