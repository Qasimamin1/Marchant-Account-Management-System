using System;
using System.Collections.Generic;
using System.Text;

namespace MAMS_Models.Model
{
    public class CashHistory
    {
        public int UID { get; set; }
        public string Details { get; set; }
        public string CashProfit { get; set; }
        public string CashLost { get; set; }
        public string TotalCash { get; set; }
        public string DateTime { get; set; }
    }
}
