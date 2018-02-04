

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cList_setup_product_main
    {
        public cList_setup_product_main()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        [Key]
        public long setup_product_main_id { get; set; }
        public string nameEN { get; set; }
        public string nameTH { get; set; }
        public double setup_equipment_price { get; set; }
        public double setup_non_equipment_price { get; set; }
        public string remark { get; set; }
        public double description { get; set; }
        public int setup_work_product_type_id { get; set; }
        public bool isHidden { get; set; }
    }
}