
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cSetup_product_accessory
    {
        public cSetup_product_accessory()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        [Key]
        public long setup_product_accessory_id { get; set; }
        public long setup_product_id { get; set; }
        public long setup_work_id { get; set; }
        public long list_setup_product_accessory_id { get; set; }
        public double product_accessory_price { get; set; }
        public double product_accessory_quantity { get; set; }
        public string product_accessory_surplus_price { get; set; }
        public string product_accessory_surplus_quantity { get; set; }
        public bool isCancelled { get; set; }
        public DateTime created_datetime { get; set; }
        public DateTime updated_datetime { get; set; }
    }
}