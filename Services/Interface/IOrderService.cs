using BusinessObjects.Entities;

namespace Services.Interface;

public interface IOrderService
{
    public List<Order> GetOrders();
    public Order GetOrderById(int id);
    public Order AddOrder(Order order);
    public void DeleteOrder(int id);
    public Order UpdateOrder(int id, Order order);
}