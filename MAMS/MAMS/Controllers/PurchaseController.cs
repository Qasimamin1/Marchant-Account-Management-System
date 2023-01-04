using BOL;
using MAMS_Models.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAMS.Controllers
{
    public class PurchaseController : Controller
    {
        private CropBOL _objCropBOL;
        private PurchaseBOL _objPurchaseBOL;
        private CustomerType _custType;
        private List<CustomerType> _custTypeList;
        private List<Crop> _crops;
        private List<Bag> _bags;
        private CashHistory _cashHistory;
        private Purchase _purchase;
        private List<Purchase> _purchaseList;
        private Expense _expense;
        private List<Expense> _expenseList;

        public PurchaseController()
        {
            _objCropBOL = new CropBOL();
            _custType = new CustomerType();
            _custTypeList = new List<CustomerType>();
            _objPurchaseBOL = new PurchaseBOL();
            _cashHistory = new CashHistory();
            _crops = new List<Crop>();
            _bags = new List<Bag>();
            _purchase = new Purchase();
            _purchaseList = new List<Purchase>();
            _expense = new Expense();
            _expenseList = new List<Expense>();
        }
        public IActionResult Index()
        {
            _purchaseList = new List<Purchase>();
            _purchaseList = _objPurchaseBOL.GetAllPurchasedCrop();
            return View(_purchaseList);
        }
        public IActionResult PurchaseCrop()
        {
            _crops = new List<Crop>();
            _bags = new List<Bag>();
            _cashHistory = new CashHistory();
            _crops = _objCropBOL.GetCropInfo();
            _cashHistory = _objPurchaseBOL.GetCashHistory();
            _bags = _objPurchaseBOL.GetBags();

            ViewBag.Crops = _crops;
            ViewBag.Bags = _bags;
            ViewBag.CashHistory = _cashHistory.TotalCash;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPurchaseCrop(Purchase model, Expense[] expItems)
        {
            model.AddBy = "Usman";
            string response = _objPurchaseBOL.AddPurchaseCrop(model, expItems);
            response = JsonConvert.SerializeObject(response);
            return Json(new { success = "true", data = new { response, Error = "false" } });
        }

        [HttpPost]
        public async Task<IActionResult> GetCustomerType(string cusType)
        {
            List<CustomerType> customers = _objPurchaseBOL.GetCustomerType(cusType);
            return Json(new { success = "true", data = new { customers = customers, Error = "false" } });
        }
        [HttpPost]
        public IActionResult DeletePurchaseCrop(int purchCropId)
        {
            int affectedRows = _objPurchaseBOL.DeletePurchaseCrop(purchCropId);
            return Ok(affectedRows);
        }

        public IActionResult PurchaseCropEdit(int Id)
        {
            _crops = new List<Crop>();
            _bags = new List<Bag>();
            _cashHistory = new CashHistory();
            _purchase = new Purchase();
            _expenseList = new List<Expense>();
            _crops = _objCropBOL.GetCropInfo();
            _cashHistory = _objPurchaseBOL.GetCashHistory();
            _bags = _objPurchaseBOL.GetBags();
            _purchase = _objPurchaseBOL.GetPurchasedCropById(Id);
            _expenseList= _objPurchaseBOL.GetPurchasedExpenseById(Id);
            ViewBag.Crops = _crops;
            ViewBag.Bags = _bags;
            ViewBag.CashHistory = _cashHistory.TotalCash; 
            ViewBag.Expenses = _expenseList;

            return View(_purchase);
        }
    }
}
