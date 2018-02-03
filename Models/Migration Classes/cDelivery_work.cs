


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cDelivery_work
    {
        public cDelivery_work()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        [Key]
        public long delivery_work_id { get; set; }
        public long Tservice_work_id { get; set; }
        public long Tservice_type_id { get; set; }
        public DateTime delivery_appointed_datetime { get; set; }
        public DateTime delivery_finished_datetime { get; set; }
        public long delivery_address_amphur_id { get; set; }
        public long delivery_address_district_id { get; set; }
        public long delivery_address_province_id { get; set; }
        public int delivery_address_zip_code { get; set; }
        public string delivery_address_phone_number { get; set; }
        public string delivery_address_receiver_name { get; set; }
        public string delivery_address_place_name { get; set; }
        public string delivery_address_details { get; set; }
        public string delivery_address_map_google_url { get; set; }
        public string delivery_address_map_image_url { get; set; }
        public string member_email { get; set; }
        public string remark_member { get; set; }
        public string remark_employee { get; set; }
        public bool isCancelled { get; set; }
        public string receipt_number { get; set; }
        public string signature_customer_image_url { get; set; }
        public long Tservice_work_status_id { get; set; }
        public double delivery_distance_kilometre { get; set; }
        public DateTime created_datetime { get; set; }
        public DateTime updated_datetime { get; set; }
    }
}