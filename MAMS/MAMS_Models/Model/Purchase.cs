using System;
using System.Collections.Generic;
using System.Text;

namespace MAMS_Models.Model
{
    public class Purchase
    {
        public int UID { get; set; }
        public string CustomerType { get; set; }
        public string CustomerName { get; set; } 
        public int Fk_CustomerId { get; set; }
        public int Fk_Crop { get; set; }
        public string CropName { get; set; }
        
        public int WeightInMaun { get; set; }
        public Decimal WeightInkg { get; set; }
        public Decimal TotalCropWeight { get; set; }
        public int PriceInMaun { get; set; }
        public Decimal PriceInKg { get; set; }
        public int TotalCropPrice { get; set; }
        public int TotalExp { get; set; } 
        public int TotalAmountwithExp { get; set; }
        public int FK_BagType { get; set; }
        public int BagWeight { get; set; }
        public int BagTotal { get; set; }
        public string AddDate { get; set; }
        public string AddBy { get; set; }
        public bool Status { get; set; }
    }
}
