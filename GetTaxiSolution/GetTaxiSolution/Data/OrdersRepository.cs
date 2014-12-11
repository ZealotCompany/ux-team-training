using GetTaxiSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetTaxiSolution.Data
{
    public class OrdersRepository : IOrdersRepository
    {
        private TaxiAppDbContext _dbContext;

        public OrdersRepository(TaxiAppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public IQueryable<Models.Order> GetAllOrders()
        {
            return _dbContext.Orders;
        }

        public Order GetOrderByID(int orderID)
        {
            return _dbContext.Orders.Where(order => order.OrderID == orderID).FirstOrDefault();
        }
    }
}