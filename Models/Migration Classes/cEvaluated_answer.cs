


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cEvaluated_answer
    {
        public cEvaluated_answer()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        [Key]
        public long Tservice_type_id { get; set; }
        public long evaluated_answer_id { get; set; }
        public long evaluated_question_choice_id { get; set; }
        public long evaluated_question_id { get; set; }
        public long Tservice_work_id { get; set; }
        public DateTime created_datetime { get; set; }
        public DateTime updated_datetime { get; set; }
    }
}