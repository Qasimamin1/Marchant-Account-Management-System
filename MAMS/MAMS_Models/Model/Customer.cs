using System;
using System.Collections.Generic;
using System.Text;

namespace MAMS_Models.Model
{
    public class Customer
    {
        public int UID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CNIC { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CusType { get; set; }
        public string ComShopName { get; set; }
        public string ComAddress { get; set; }
        public bool Status { get; set; }
        public string AddDate { get; set; }
        public string AddedBy { get; set; }
    }
}
