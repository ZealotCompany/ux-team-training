using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetTaxiSolution.Models
{
    public class Bid
    {
        public int BidID { get; set; }
        public int OrderID { get; set; }
        public int DriverID { get; set; }
        public decimal Price { get; set; }
    }
}
