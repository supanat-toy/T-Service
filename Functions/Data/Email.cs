using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using T_Service.Models;

namespace T_Service.Functions
{
    public class Email : FunctionsHelper
    {
        public mResult SendEmail(string a)
        {
            mResult result = new mResult();

            MailMessage mail = new MailMessage();
            mail.To.Add("");
            mail.From = new MailAddress("form_send_email.sender_email", "form_send_email.sender_name");
            mail.Subject = "form_send_email.subject";
            //PartialViewResult Body = form_send_email.body;
            mail.Body = "form_send_email.body";
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //"https://mail.tsky.co.th"; //"smtp.gmail.com"; //"mail.tsky.co.th";
            smtp.Port = 587; //587; //2096; //
            smtp.UseDefaultCredentials = false;
            //smtp.TargetName = "STARTTLS/smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential
            ("form_send_email.sender_email", "form_send_email.sender_password"); // Enter senders User name and password
            smtp.EnableSsl = true;
            smtp.Send(mail);

            result.isSucceed = true;
            result.message = "Send Successfully";
            return result;
            //}
        }
    }
}