

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cList_setup_product_accessory
    {
        public cList_setup_product_accessory()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        public long list_setup_product_accessory_id { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }
        public int quantity_available { get; set; }
        public long setup_work_product_type_id { get; set; }
        public string setup_product_unit_name { get; set; }
        public double setup_product_price { get; set; }
        public string remark { get; set; }
        public double setup_product_surplus_price { get; set; }
        public string setup_product_surplus_unit_name { get; set; }
        public bool isHidden { get; set; }

    }
}