using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetTaxiSolution.Models
{
    public class Rank
    {
        public int RankID { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}