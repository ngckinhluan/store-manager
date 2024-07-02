using BusinessObjects.Entities;
using Repositories.Implementation;
using Services.Interface;

namespace Services.Implementation;

public class OrderService : IOrderService
{
    private readonly OrderRepository _orderRepository = null;

    public OrderService()
    {
        _orderRepository ??= new OrderRepository();
    }
    
    public List<Order> GetOrders()
    {
        return _orderRepository.GetOrders();
    }

    public Order GetOrderById(int id)
    {
        return _orderRepository.GetOrderById(id);
    }

    public Order AddOrder(Order order)
    {
        return _orderRepository.AddOrder(order);
    }

    public void DeleteOrder(int id)
    {
        _orderRepository.DeleteOrder(id);
    }

    public Order UpdateOrder(int id, Order order)
    {
        return _orderRepository.UpdateOrder(id, order);
    }
}