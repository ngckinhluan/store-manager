using BusinessObjects.Entities;
using Repositories.Implementation;
using Services.Interface;

namespace Services.Implementation;

public class OrderDetailService : IOrderDetailService
{
    private readonly OrderDetailRepository _orderDetailRepository = null;

    public OrderDetailService()
    {
        _orderDetailRepository ??= new OrderDetailRepository();
    }


    public List<OrderDetail> GetOrderDetails(int orderId, int productId)
    { 
        return _orderDetailRepository.GetOrderDetails(orderId, productId);
    }

    public void AddOrderDetail(OrderDetail orderDetail)
    {
        _orderDetailRepository.AddOrderDetail(orderDetail);
    }

    public void UpdateOrderDetail(OrderDetail orderDetail)
    {
        _orderDetailRepository.UpdateOrderDetail(orderDetail);
    }

    public void DeleteOrderDetail(int orderId, int productId)
    {
        _orderDetailRepository.DeleteOrderDetail(orderId, productId);
    }
}