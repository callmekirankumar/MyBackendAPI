using Microsoft.AspNetCore.Mvc;
using MyBackendAPI.DTOs;
using MyBackendAPI.Services;
using System.Threading.Tasks;

namespace MyBackendAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orders = await _orderService.GetAllAsync();
            return Ok(orders);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderDTO orderDTO)
        {
            if (string.IsNullOrWhiteSpace(orderDTO.LastName) || orderDTO.LastName.Length > 20)
                return BadRequest("Last Name is mandatory and should be a maximum of 20 characters.");

            if (string.IsNullOrWhiteSpace(orderDTO.Description) || orderDTO.Description.Length > 100)
                return BadRequest("Description is mandatory and should be a maximum of 100 characters.");

            if (orderDTO.Quantity < 1 || orderDTO.Quantity > 20)
                return BadRequest("Quantity should be between 1 and 20.");

            var order = await _orderService.AddAsync(orderDTO);
            return CreatedAtAction(nameof(GetAll), new { id = order.Id }, order);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _orderService.DeleteAsync(id);
            return NoContent();
        }
    }
}
