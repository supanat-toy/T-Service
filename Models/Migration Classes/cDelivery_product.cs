


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cDelivery_product
    {
        public cDelivery_product()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        [Key]
        public long delivery_work_id { get; set; }
        public long delivery_product_id { get; set; }
        public string product_code { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }
        public int quantity_number { get; set; }
        public bool isCancelled { get; set; }
        public DateTime created_datetime { get; set; }
        public DateTime updated_datetime { get; set; }
    }
}