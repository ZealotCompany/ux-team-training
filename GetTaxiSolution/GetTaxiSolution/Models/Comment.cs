using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetTaxiSolution.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int BidID { get; set; }
        public string Text { get; set; }
    }
}