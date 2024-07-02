using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDao _orderDao = null;

        public OrderRepository()
        {
            _orderDao ??= new OrderDao();
        }
        
        public List<Order> GetOrders()
        {
            return _orderDao.GetOrders();
        }

        public Order GetOrderById(int id)
        {
            return _orderDao.GetOrderById(id);
        }

        public Order AddOrder(Order order)
        {
            return _orderDao.AddOrder(order);
        }

        public void DeleteOrder(int id)
        {
            _orderDao.DeleteOrder(id);
        }

        public Order UpdateOrder(int id, Order order)
        {
            return _orderDao.UpdateOrder(id, order);
        }
    }
}
