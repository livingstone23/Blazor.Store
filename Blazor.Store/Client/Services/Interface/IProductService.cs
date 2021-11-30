using Blazor.Store.Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Store.Client.Services.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetByCategory(int productCategoryId);
    }
}
