
using MyBackendAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBackendAPI.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAllAsync();
        Task<Order> AddAsync(Order order);
        Task<Order> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
