using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class OrderDAO
    {
        //Using Singleton Pattern
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Order> GetOrderList()
        {
            var members = new List<Order>();
            try
            {
                using var context = new FstoreContext();
                members = context.Orders.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return members;

        }

        public Order GetOrderByID(int OrderID)
        {
            Order mem = null;
            try
            {
                using var context = new FstoreContext();
                mem = context.Orders.SingleOrDefault(c=>c.OrderId == OrderID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return mem;
        }

        //-----------------------------------------------------------------
        //Add a new member
        public void AddNew(Order Order)
        {
            try
            {
                Order mem = GetOrderByID(Order.OrderId);
                if (mem == null)
                {
                    using var context = new FstoreContext();
                    context.Orders.Add(Order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Order is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //-----------------------------------------------------------------
        //Add a new member
        public void Update(Order Order)
        {
            try
            {
                Order mem = GetOrderByID(Order.OrderId);
                if (mem != null)
                {
                    using var context = new FstoreContext();
                    context.Orders.Update(Order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Order does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //-----------------------------------------------------------------
        //Add a new member
        public void Remove(int OrderId)
        {
            try
            {
                Order mem = GetOrderByID(OrderId);
                if (mem != null)
                {
                    using var context = new FstoreContext();
                    context.Orders.Remove(mem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Order does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Order> Filter(DateTime a, DateTime b)
        {
            var members = new List<Order>();
            var fil = new List<Order>();
            try
            {
                using var context = new FstoreContext();
                members = context.Orders.ToList();
                for (int i = 0; i < members.Count(); i++)
                {
                    if ((members[i].OrderDate >= a && members[i].OrderDate <= b) || (members[i].ShippedDate >= a && members[i].ShippedDate <= b))
                    {
                        fil.Add(members[i]);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return fil;
        }
    }
}
