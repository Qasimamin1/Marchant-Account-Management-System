using DAL;
using MAMS_Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BOL
{
    public class PurchaseBOL
    {
        private PurchaseDAL _objPurchaseDAL;
        private List<Bag> _bags;
        public PurchaseBOL()
        {
            _objPurchaseDAL = new PurchaseDAL();
            _bags = new List<Bag>();
        }
        public List<CustomerType> GetCustomerType(string cusType)
        {
            return _objPurchaseDAL.GetCustomerType(cusType);
        }
        public List<Bag> GetBags()
        {
            return _objPurchaseDAL.GetBags();
        }
        public string AddPurchaseCrop(Purchase purchase, Expense[] expenses)
        {
            return _objPurchaseDAL.AddPurchaseCrop(purchase, expenses);
        }
        public CashHistory GetCashHistory()
        {
            return _objPurchaseDAL.GetCashHistory();
        }
        public List<Purchase> GetAllPurchasedCrop()
        {
            return _objPurchaseDAL.GetAllPurchasedCrop();
        }
        public int DeletePurchaseCrop(int purchCropId)
        {
            return _objPurchaseDAL.DeletePurchaseCrop(purchCropId);
        }
        public Purchase GetPurchasedCropById(int purchCropId)
        {
            return _objPurchaseDAL.GetPurchasedCropById(purchCropId);
        }
        public List<Expense> GetPurchasedExpenseById(int purchCropId)
        {
            return _objPurchaseDAL.GetPurchasedExpenseById(purchCropId);
        }
        }
}
