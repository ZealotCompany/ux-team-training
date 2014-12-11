using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GetTaxiSolution;
using GetTaxiSolution.Models;

namespace GetTaxiSolution.Data
{
    public class DriversRepository : IDriversRepository
    {
        private TaxiAppDbContext _dbContext;
        public DriversRepository(TaxiAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Driver> GetDrivers()
        {
            return _dbContext.Drivers.ToList();
        }
    }
}