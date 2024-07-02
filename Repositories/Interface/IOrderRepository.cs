using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IOrderRepository
    {
        public List<Order> GetOrders();
        public Order GetOrderById(int id);
        public Order AddOrder(Order order);
        public void DeleteOrder(int id);
        public Order UpdateOrder(int id, Order order);
    }
}
