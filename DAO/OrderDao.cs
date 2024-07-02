using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;

namespace DAO
{

    public class OrderDao
    {
        private readonly StoremanagementContext _context = null;

        public OrderDao()
        {
            _context ??= new StoremanagementContext();
        }

        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders.Find(id);
        }

        public Order AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }

        public void DeleteOrder(int id)
        {
            var order = GetOrderById(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Order not found");
            }
        }

        public Order UpdateOrder(int id, Order order)
        {
            var existingOrder = GetOrderById(id);
            if (existingOrder != null)
            {
                existingOrder.Freight = order.Freight;
                existingOrder.OrderDate = order.OrderDate;
                existingOrder.RequiredDate = order.RequiredDate;
                existingOrder.ShippedDate = order.ShippedDate;
                _context.Orders.Update(existingOrder);
                _context.SaveChanges();
                return existingOrder;
            }
            else
            {
                throw new KeyNotFoundException("Order not found");
            }
        }
    }
}
