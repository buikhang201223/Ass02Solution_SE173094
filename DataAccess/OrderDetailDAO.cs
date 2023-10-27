using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        //Using Singleton Pattern
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetailList()
        {
            var members = new List<OrderDetail>();
            try
            {
                using var context = new FstoreContext();
                members = context.OrderDetails.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return members;

        }

        public OrderDetail GetOrderDetailByID(int OrderID, int ProductID)
        {
            OrderDetail mem = null;
            try
            {
                using var context = new FstoreContext();
                mem = context.OrderDetails.SingleOrDefault(c=> c.OrderId==OrderID && c.ProductId==ProductID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return mem;
        }

        //-----------------------------------------------------------------
        //Add a new member
        public void AddNew(OrderDetail OrderDetail)
        {
            try
            {
                OrderDetail mem = GetOrderDetailByID(OrderDetail.OrderId, OrderDetail.ProductId);
                if (mem == null)
                {
                    using var context = new FstoreContext();
                    context.OrderDetails.Add(OrderDetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The OrderDetail is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //-----------------------------------------------------------------
        //Add a new member
        public void Update(OrderDetail OrderDetail)
        {
            try
            {
                OrderDetail mem = GetOrderDetailByID(OrderDetail.OrderId, OrderDetail.ProductId);
                if (mem != null)
                {
                    using var context = new FstoreContext();
                    context.OrderDetails.Update(OrderDetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The OrderDetail does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //-----------------------------------------------------------------
        //Add a new member
        public void Remove(int OrderId, int ProductId)
        {
            try
            {
                OrderDetail mem = GetOrderDetailByID(OrderId, ProductId);
                if (mem != null)
                {
                    using var context = new FstoreContext();
                    context.OrderDetails.Remove(mem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The  OrderDetail does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
