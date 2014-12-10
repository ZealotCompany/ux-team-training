using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using GetTaxiSolution.Data;

namespace GetTaxiSolution.Controllers
{
    public class DriversController : ApiController
    {
        private IDriversRepository _repo;

        public DriversController(IDriversRepository repo)
        {
            this._repo = repo;
        }

        public IEnumerable<object> GetDrivers()
        {
            return _repo.GetDrivers();
        }
        
    }
}
