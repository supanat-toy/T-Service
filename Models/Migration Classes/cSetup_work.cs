
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cSetup_work
    {
        public cSetup_work()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        [Required (ErrorMessage = "NEED")]
        public long Tservice_work_id { get; set; }
        public long setup_work_id { get; set; }
        public long setup_work_product_type_id { get; set; }
        public DateTime setup_appointed_datetime { get; set; }
        public DateTime setup_finished_datetime { get; set; }
        public double setup_price { get; set; }
        public string description { get; set; }
        public string member_email { get; set; }
        public DateTime created_datetime { get; set; }
        public DateTime updated_datetime { get; set; }
        public string identity_card_number { get; set; }
    }
}