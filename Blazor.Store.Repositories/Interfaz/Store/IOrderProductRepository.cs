using Blazor.Store.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Store.Repositories.Interfaz.Store
{
    public interface IOrderProductRepository
    {
        Task<bool> InsertOrderProduct(int orderId, Product product);
        Task<IEnumerable<Product>> GetByOrder(int orderId);
        Task<bool> DeleteOrderProductByOrder(int orderId);

    }
}
