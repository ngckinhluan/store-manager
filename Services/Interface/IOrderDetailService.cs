using BusinessObjects.Entities;

namespace Services.Interface;

public interface IOrderDetailService
{
    List<OrderDetail> GetOrderDetails(int orderId, int productId);
    void AddOrderDetail(OrderDetail orderDetail);
    void UpdateOrderDetail(OrderDetail orderDetail);
    void DeleteOrderDetail(int orderId, int productId);
}