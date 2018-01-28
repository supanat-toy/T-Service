using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class mUser
    {
        public mUser()
        {
            // isSuccess = false;
            // message = "N/A";
        }
        [Required (ErrorMessage = "NEED")]
        public long userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public DateTime createdDatetime { get; set; }
        public DateTime updatedDatetime { get; set; }
        public bool isDeleted { get; set; }
        public bool isAdmin { get; set; }
        public string ImageURL { get; set; }
    }
}