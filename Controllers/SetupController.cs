using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;
using T_Service.Functions;

namespace T_Service.Controllers
{
    public class SetupController : FunctionsHelper
    {
        public IActionResult Index()
        {
            // List<> customerList = new List<mCustomer>();
            // customerList = _service._qCustomer.getList();

            return View();
        }
        public IActionResult Create()
        {
            // customer = customer == null ? new cSetup_work() : customer;
            // return View(customer);
            return View();
        }

        public IActionResult Create(cSetup_work customer)
        {
            // if (true){
            //     return View("New", customer);
            // } else {
            //     return RedirectToAction("Index");
            // }
            return View();
        }

        public IActionResult Update(string q)
        {
            // long id = Convert.ToInt64(_security.Decrypt(q));
            // customer = customer == null ? _service._qCustomer.getDetails(id) : customer;


            // return View(customer);
            return View();
        }

        public IActionResult Update(string q, cSetup_work customer)
        {
            // long id = Convert.ToInt64(_security.Decrypt(q));
            // return View();

            // if (true){
            //     _service._qCustomer.updateDB(id, customer);
            //     return RedirectToAction("Index");
            // } else {
                
            //     return RedirectToAction("Edit", new { q = q, customer = customer } );
            // }
            return View();
        }
        public IActionResult Delete(string q, cSetup_work customer)
        {
            // long id = Convert.ToInt64(_security.Decrypt(q));
            // if (true){
            //     customer.isRequestedDeleted = true;
            //     _service._qCustomer.updateDB(id, customer);
            // }
            // return RedirectToAction("Index");
            return View();
        } 
    }
}