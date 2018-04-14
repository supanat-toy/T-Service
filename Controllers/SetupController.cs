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
            // var a = _service._pSetup_work;
            // var itemList = _service._pSetup_work.serviceList();

            // var setupProductList = new List<cList_setup_product_main>();
            // setupProductList = _service._pSetup_work.getSetupProductMainList();

            // var setupProductAccessoryList = new List<cList_setup_product_accessory>();
            // setupProductAccessoryList = _service._pSetup_work.getSetupProductAccessoryList();
            // List<> customerList = new List<mCustomer>();
            // customerList = _service._qCustomer.getList();

            // ViewData["itemList"] = itemList as List<cList_Tservice_type>;
            return View();
        }
        public IActionResult Create()
        {
            // customer = customer == null ? new cSetup_work() : customer;
            // return View(customer);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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

        [HttpPost]
        [ValidateAntiForgeryToken]
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
        public IActionResult Delete(string q)
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