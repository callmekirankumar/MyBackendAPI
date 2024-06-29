using MyBackendAPI.DTOs;
using MyBackendAPI.Models;
using MyBackendAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBackendAPI.Services
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _orderRepository.GetAllAsync();
        }

        public async Task<Order> AddAsync(OrderDTO orderDTO)
        {
            var order = new Order
            {
                FirstName = orderDTO.FirstName,
                LastName = orderDTO.LastName,
                Description = orderDTO.Description,
                Quantity = orderDTO.Quantity
            };

            return await _orderRepository.AddAsync(order);
        }

        public async Task DeleteAsync(int id)
        {
            await _orderRepository.DeleteAsync(id);
        }

    }
}
