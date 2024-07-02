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
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly OrderDetailDao _orderDetailDao = null;

        public OrderDetailRepository()
        {
            _orderDetailDao ??= new OrderDetailDao();
        }
        
        public List<OrderDetail> GetOrderDetails(int orderId, int productId)
        {
            return _orderDetailDao.GetOrderDetails(orderId, productId);
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailDao.AddOrderDetail(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailDao.UpdateOrderDetail(orderDetail);
        }

        public void DeleteOrderDetail(int orderId, int productId)
        {
            _orderDetailDao.DeleteOrderDetail(orderId, productId);
        }
    }
}
