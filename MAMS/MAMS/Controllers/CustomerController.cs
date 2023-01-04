using MAMS_Models.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAMS.Controllers
{
    public class CustomerController : Controller
    {
        private BOL.CustomerBOL _objCustomerBOL;
        public CustomerController()
        {
            _objCustomerBOL = new BOL.CustomerBOL();
        }
        public IActionResult Index()
        {
            List<Customer> customers= _objCustomerBOL.GetCustomerInfo();
            return View(customers);
        }
        
        public IActionResult NewCustomerAdd( )
        {            
            return View();
        }
        [HttpPost]
        public IActionResult NewCustomerAdd(Customer customer)
        {
            int affectedRows = 0;
            if (customer!=null)
            {
                affectedRows= _objCustomerBOL.InsertCustomerInfo(customer);
                if (affectedRows>0)
                {
                    ModelState.Clear(); 
                }
            }
            ViewBag.CusAddStatus = affectedRows;
            return View();
        }
        
        public IActionResult CustomerEdit(int Id)
        {
             var customer = _objCustomerBOL.GetSpecificCustomerInfo(Id);

            return View(customer);
        }
        [HttpPost]
        public IActionResult CustomerEdit(Customer customer)
        {
            int affectedRows = 0;
            if (customer != null)
            {
                affectedRows = _objCustomerBOL.CustomerEdit(customer);
                if (affectedRows > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            ViewBag.CusAddStatus = affectedRows;
            return View();
        }
        [HttpPost]
        public IActionResult DeleteCustomer(int cusId)
        {
            int affectedRows = _objCustomerBOL.DeleteCustomer(cusId); 
            return Ok(affectedRows);
        }
         
    }
}
