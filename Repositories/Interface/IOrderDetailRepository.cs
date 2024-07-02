using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;

namespace Repositories.Interface
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrderDetails(int orderId, int productId);
        void AddOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(OrderDetail orderDetail);
        void DeleteOrderDetail(int orderId, int productId);
    }
}
