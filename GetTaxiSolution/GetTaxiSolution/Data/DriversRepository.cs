using GetTaxiSolution.Models;
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
            
                new Driver() {
                    DriverID = 1,
                    FirsName = "Anar",
                    LastName = "Azadaliyev",
                    BirthDate = "27-09-1986",
                    Gender = Gender.MALE
                },
                new Driver() {
                    DriverID = 2,
                    FirsName = "Azer",
                    LastName = "Safarov",
                    BirthDate = "22-02-1990",
                    Gender = Gender.MALE
                },
                new Driver() {
                    DriverID = 3,
                    FirsName = "Rufet",
                    LastName = "Isayev",
                    BirthDate = "21-11-1993",
                    Gender = Gender.MALE
                }
            };
        }
    }
}