using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetTaxiSolution.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public  string Model { get; set; }
        public CarBrand Brand { get; set; }
        public  CarType Type { get; set; } 
        public DateTime Year { get; set; } 
        public string ImageUrl { get; set; } 
    }
}