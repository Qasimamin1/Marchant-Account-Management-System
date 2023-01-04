using System;
using System.Collections.Generic;
using System.Text;

namespace MAMS_Models.Model
{
   public class Crop
    {
        public int UID { get; set; }
        public string Name { get; set; }
        public string AddDate { get; set; }
        public string AddedBy { get; set; }
        public bool Status { get; set; }
    }
}
