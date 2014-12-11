using GetTaxiSolution.Data;
using GetTaxiSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace GetTaxiSolution.Controllers
{
    public class OrdersController : ApiController
    {
        private IOrdersRepository _ordersRepo;

        public OrdersController(IOrdersRepository ordersRepo)
        {
            this._ordersRepo = ordersRepo;
        }

        public IEnumerable<Order> GetOrders() {
            return _ordersRepo.GetAllOrders().ToList();
        }
    }
}