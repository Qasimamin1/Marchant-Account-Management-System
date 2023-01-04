using System;
using System.Collections.Generic;
using System.Text;

namespace MAMS_Models.Model
{
    public class Expense
    {
        public int UID { get; set; }
        public string ExpDescription { get; set; }
        public int Amount { get; set; }
        public string AddDate { get; set; }
        public string AddBy { get; set; }
        public bool Status { get; set; }
    }
}
