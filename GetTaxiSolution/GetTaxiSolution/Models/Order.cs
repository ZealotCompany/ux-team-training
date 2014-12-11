using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GetTaxiSolution.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal SuggestedPrice { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
        public IEnumerable<Bid> Bids { get; set; }

        [Column("CHOSEN_BID_ID")]
        public Bid ChosenBid { get; set; }
    }
}