using GetTaxiSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTaxiSolution.Data
{
    public interface IOrdersRepository
    {
        IQueryable<Order> GetAllOrders();

        Order GetOrderByID(int orderID);
    }
}
