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
    public class A_CustomerController : FunctionsHelper
    {
        // public IActionResult Index()
        // {
        //     List<mCustomer> customerList = new List<mCustomer>();
        //     customerList = _service._qCustomer.getList();

        //     return View(customerList);
        // }
        // public IActionResult New(mCustomer customer = null)
        // {
        //     customer = customer == null ? new mCustomer() : customer;
        //     return View(customer);
        // }

        // public IActionResult Create(mCustomer customer)
        // {
        //     if (true){
        //         return View("New", customer);
        //     } else {
        //         return RedirectToAction("Index");
        //     }
            
        // }

        // public IActionResult Edit(string q, mCustomer customer = null)
        // {
        //     long id = Convert.ToInt64(_security.Decrypt(q));
        //     customer = customer == null ? _service._qCustomer.getDetails(id) : customer;


        //     return View(customer);
        // }

        // public IActionResult Update(string q, mCustomer customer)
        // {
        //     long id = Convert.ToInt64(_security.Decrypt(q));
        //     return View();

        //     if (true){
        //         _service._qCustomer.updateDB(id, customer);
        //         return RedirectToAction("Index");
        //     } else {
                
        //         return RedirectToAction("Edit", new { q = q, customer = customer } );
        //     }
        // }
        // public IActionResult Delete(string q, mCustomer customer)
        // {
        //     long id = Convert.ToInt64(_security.Decrypt(q));
        //     if (true){
        //         customer.isRequestedDeleted = true;
        //         _service._qCustomer.updateDB(id, customer);
        //     }
        //     return RedirectToAction("Index");
        // } 
    }
}