using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class OrderDetailDao
    {
        private readonly StoremanagementContext _context = null;

        public OrderDetailDao()
        {
            _context = new StoremanagementContext();
        }
        public List<OrderDetail> GetOrderDetails(int orderId, int productId)
        {
            return _context.OrderDetails.Include(od => od.Order)
                .Include(od => od.Product)
                .Where(od => od.OrderId == orderId && od.ProductId == productId)
                .ToList();
        }
        public void AddOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }
        
        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            var existingOrderDetail = _context.OrderDetails
                .FirstOrDefault(od => od.OrderId == orderDetail.OrderId && od.ProductId == orderDetail.ProductId);

            if (existingOrderDetail != null)
            {
                existingOrderDetail.UnitPrice = orderDetail.UnitPrice;
                existingOrderDetail.Quantity = orderDetail.Quantity;
                existingOrderDetail.Discount = orderDetail.Discount;
                _context.SaveChanges();
            }
        }
        public void DeleteOrderDetail(int orderId, int productId)
        {
            var orderDetail = _context.OrderDetails
                .FirstOrDefault(od => od.OrderId == orderId && od.ProductId == productId);

            if (orderDetail != null)
            {
                _context.OrderDetails.Remove(orderDetail);
                _context.SaveChanges();
            }
        }
    }
}
