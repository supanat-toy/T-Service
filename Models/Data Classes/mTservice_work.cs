using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class mTservice_work
    {
        public mTservice_work()
        {

        }
        public long Tservice_work_id { get; set; }
        public cMember member { get; set; }
        public cList_Tservice_type Tservice_type { get; set; }
        public cList_Tservice_work_status Tservice_work_status { get; set; }
        public List<mEvaluation_question> evaluation_questionList { get; set; }
        public List<cEmployee> employeeList { get; set; }
        public string created_datetime { get; set; }
        public string updated_datetime { get; set; }

    }
}