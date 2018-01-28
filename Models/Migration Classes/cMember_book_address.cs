
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cMember_book_address
    {
        public cMember_book_address()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        public long member_book_address_id { get; set; }
        public string member_email { get; set; }
        public string receiver_name { get; set; }
        public string place_name { get; set; }
        public string address_details { get; set; }
        public int amphur_id { get; set; }
        public int district_id { get; set; }
        public int province_id { get; set; }
        public int zip_code { get; set; }
        public string phone_number { get; set; }
        public string map_google_url { get; set; }
        public string map_image_url { get; set; }
        public DateTime created_datetime { get; set; }
        public DateTime updated_datetime { get; set; }
    }
}