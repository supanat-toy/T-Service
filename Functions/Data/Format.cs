using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;

namespace T_Service.Functions
{
    public class Format : FunctionsHelper
    {
        public string GetFormatDate_dMyyyy(DateTime dt) // 9/3/2008
        {
            return String.Format("{0:d/M/yyyy}", dt).Replace("-","/");
        }
        public string GetFormatDate_dMMMMyyyy(DateTime dt) // 9 January 2008
        {
            return string.Format("{0:d MMMM yyyy}", dt).Replace("-", "/");
        }

        public string GetFormatDate_dMyyyyHHmmSS(DateTime dt)
        {
            return string.Format("{0:d/M/yyyy HH:mm:ss}", dt).Replace("-", "/");
        }

        public DateTime GetDateTime_dMyyyyHHmmSS(string dt)
        {
            string[] split = dt.Split(' ');
            string[] dateSplit = split[0].Split('/');
            string[] timeSplit = split[1].Split(':');

            return new DateTime(Convert.ToInt32(dateSplit[2]), Convert.ToInt32(dateSplit[1]), Convert.ToInt32(dateSplit[0]), Convert.ToInt32(timeSplit[0]), Convert.ToInt32(timeSplit[1]), Convert.ToInt32(timeSplit[2])); //string.Format("{0:d MMMM yyyy HH:mm:ss}", dt).Replace("-", "/");
        }
    }
}