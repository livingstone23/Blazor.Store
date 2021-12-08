using Blazor.Store.Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Store.Client.Services.Interface
{
    public interface IOrderService
    {
        Task SaveOrder(Order order);
        public Task<int> GetNextNumber();

        Task<IEnumerable<Order>> GetAll();

        Task<Order> GetDetails(int id);

        Task DeleteOrder(int id);

    }
}
