using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        Order GetOrderByID(int OrderID);
        void InsertOrder(Order order);
        void DeleteOrder(int OrderID);
        void UpdateOrder(Order order);
        List<Order> GetOrderByOrderdDate(DateTime dateTime1, DateTime dateTime2);
    }
}
