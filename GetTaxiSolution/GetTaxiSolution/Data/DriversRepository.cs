using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetTaxiSolution.Data
{
    public class DriversRepository : IDriversRepository
    {
        public IEnumerable<object> GetDrivers()
        {
            return new List<object>() { 
            
                new {
                    name = "Anara",
                    exp = 15
                },
                new {
                    name = "Rufet",
                    exp = 10
                },
                new {
                    name = "Orxan",
                    exp = 5
                }
            };
        }
    }
}