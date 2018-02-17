using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class mDelivery_work: mTservice_work
    {
        public mDelivery_work()
        {

        }
        public cDelivery_work delivery_work { get; set; }
        public List<cDelivery_product> delivery_productList { get; set; }
    }
}