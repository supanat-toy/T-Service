using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_Service.Models;
using Newtonsoft.Json;


namespace T_Service.Models
{
    public class mMember
    {
        public mMember()
        {
            
        }
        [Required (ErrorMessage = "NEED")]
        public cMember member { get; set; }
        public bool isAdmin { get; set; }
        public List<cMember_book_address> book_addressList { get; set; }
    }
}