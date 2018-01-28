
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cSetup_product
    {
        public cSetup_product()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        public long setup_product_id { get; set; }
        public long setup_work_id { get; set; }
        public long setup_product_main_id { get; set; }
        public double product_accessory_total_price { get; set; }
        public double product_main_total_price { get; set; }
        public bool isCancelled { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }
        public string product_code { get; set; }
        public double product_quantity_number { get; set; }
        public DateTime created_datetime { get; set; }
        public DateTime updated_datetime { get; set; }
    }
}