using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class mSetup_work: mTservice_work
    {
        public mSetup_work()
        {
            
        }
        public cSetup_work setup_work { get; set; }
        public List<cSetup_product> setup_productList { get; set; }
        public List<cSetup_product_accessory> setup_product_accessoryList { get; set; }
    }
}