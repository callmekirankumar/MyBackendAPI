using MyBackendAPI.DTOs;
using MyBackendAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBackendAPI.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllAsync();
        Task<Order> AddAsync(OrderDTO orderDTO);
        Task DeleteAsync(int id);
    }
}
