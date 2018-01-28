using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;

namespace T_Service.Functions
{
    public class User: FunctionsHelper
    {
        // public mCustomer GetCustomerProfile()
        // {
        //     mCustomer customer = new mCustomer();
        //     var json_cookie = cookieProvider.GetCookie("customer_Profile");
        //     if (json_cookie != null)
        //     {
        //         customer = JsonConvert.DeserializeObject<mCustomer>(json_cookie.Value);
        //         return customer;
        //     }
        //     else
        //     {
        //         return null;
        //     }
           
        // }

        // public void SetCustomerProfile(mCustomer newCustomer)
        // {
        //     cookieProvider.SetCookie(newCustomer, "customer_Profile", 365);
        // }

        // public void ClearCustomerProfile()
        // {
        //     cookieProvider.ClearCookie("customer_Profile");
        // }
    }
}