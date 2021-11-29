using Blazor.Store.Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Store.Client.Services.Interface
{
    public interface IProductCategoryService
    {
        Task<IEnumerable<ProductCategory>> GetProductCategories();


    }
}
