using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetailList();
        public OrderDetail GetOrderDetailByID(int OrderID, int ProductID) => OrderDetailDAO.Instance.GetOrderDetailByID(OrderID, ProductID);
        public void InsertOrderDetail(OrderDetail OrderDetail) => OrderDetailDAO.Instance.AddNew(OrderDetail);
        public void DeleteOrderDetail(int OrderID, int ProductID) => OrderDetailDAO.Instance.Remove(OrderID, ProductID);
        public void UpdateOrderDetail(OrderDetail OrderDetail) => OrderDetailDAO.Instance.Update(OrderDetail);

      
    }
}
