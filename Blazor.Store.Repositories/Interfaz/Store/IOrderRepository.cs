using Blazor.Store.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Store.Repositories.Interfaz.Store
{
    public interface IOrderRepository
    {
        Task<bool> InsertOrder(Order order);
        Task<bool> UpdateOrder(Order order);
        Task DeleteOrder(int id);

        Task<int> GetNextNumber();

        Task<int> GetNextId();

        Task<IEnumerable<Order>> GetAll();

        Task<Order> GetDetails(int id);
    }
}
