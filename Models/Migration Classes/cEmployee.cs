
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class cEmployee
    {
        public cEmployee()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        [Key]
        public long employee_id { get; set; }
        public string full_name { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public DateTime birthday_date { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string identity_card_number { get; set; }
        public DateTime created_datetime { get; set; }
        public DateTime updated_datetime { get; set; }
    }
}