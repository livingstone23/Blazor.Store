
using Blazor.Store.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Store.Repositories.Interfaz.Store
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetByCategory(int productCategoryId);
    }
}
