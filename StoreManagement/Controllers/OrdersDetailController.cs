using BusinessObjects.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersDetailController : ControllerBase
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrdersDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpGet("{orderId}/{productId}")]
        public ActionResult<OrderDetail> GetOrderDetail(int orderId, int productId)
        {
            var orderDetail = _orderDetailService.GetOrderDetails(orderId, productId);
            if (orderDetail != null)
            {
                return Ok(orderDetail);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<OrderDetail> AddOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail == null)
            {
                return BadRequest();
            }

            _orderDetailService.AddOrderDetail(orderDetail);
            return CreatedAtAction(nameof(GetOrderDetail), new { orderId = orderDetail.OrderId, productId = orderDetail.ProductId }, orderDetail);
        }

        [HttpPut("{orderId}/{productId}")]
        public IActionResult UpdateOrderDetail(int orderId, int productId, OrderDetail orderDetail)
        {
            if (orderDetail == null || orderDetail.OrderId != orderId || orderDetail.ProductId != productId)
            {
                return BadRequest();
            }

            var existingOrderDetail = _orderDetailService.GetOrderDetails(orderId, productId);
            if (existingOrderDetail == null)
            {
                return NotFound();
            }

            _orderDetailService.UpdateOrderDetail(orderDetail);
            return NoContent();
        }

        [HttpDelete("{orderId}/{productId}")]
        public IActionResult DeleteOrderDetail(int orderId, int productId)
        {
            var orderDetail = _orderDetailService.GetOrderDetails(orderId, productId);
            if (orderDetail == null)
            {
                return NotFound();
            }
            _orderDetailService.DeleteOrderDetail(orderId, productId);
            return NoContent();
        }
    }
}
