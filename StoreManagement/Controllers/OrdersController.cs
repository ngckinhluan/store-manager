using BusinessObjects.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Implementation;
using Services.Interface;

namespace StoreManagement.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService = null;

    public OrdersController()
    {
        _orderService ??= new OrderService();
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
    {
        if (_orderService.GetOrders() != null) return _orderService.GetOrders().ToList();
        return NotFound();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Order>> GetOrder(int id)
    {
        if (_orderService.GetOrders() == null) NotFound();
        var order = _orderService.GetOrderById(id);
        if (order == null) return NotFound(); 
        return order;
    }
    
    [HttpPut("UpdateOrder")]
    public async Task<ActionResult<Order>> UpdateOrder(int id, Order order)
    {
        if (id != order.OrderId) return BadRequest();
        _orderService.UpdateOrder(id, order);
        return NoContent();
    }
    
    [HttpPost("AddNewOrder")]
    public async Task<ActionResult<Order>> AddOrder(Order order)
    {
        if (_orderService.GetOrders() == null) return Problem("Entity set 'OrchidContext.orchid' is null");
        _orderService.AddOrder(order);
        return CreatedAtAction("GetOrder", new { id = order.OrderId }, order);
    }
    
    [HttpDelete("DeleteOrder")]
    public async Task<IActionResult> DeleteOrder(int id)
    {
        if (_orderService.GetOrders() == null) return NotFound();
        _orderService.DeleteOrder(id);
        return NoContent();
    }
}