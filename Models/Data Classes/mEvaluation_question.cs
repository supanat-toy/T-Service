using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class mEvaluation_question
    {
        public mEvaluation_question()
        {
            
        }

        public long evaluated_question_id { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }
        public double version_number { get; set; }
        public bool hasChoice { get; set; }
        public cList_Tservice_type Tservice_type { get; set; }
        public string created_datetime { get; set; }
        public string updated_datetime { get; set; }
        public List<cList_evaluated_question_choice> question_choiceList { get; set; }
    }
}