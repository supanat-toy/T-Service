using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class mSetup_product
    {
        public mSetup_product()
        {
            
        }
        public cSetup_product setup_product { get; set; }
        public List<cSetup_product_accessory> setup_product_accessoryList { get; set; }
    }
}