using Blazor.Store.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Store.Repositories.interfaz.store
{
    public interface IProductCategoryRepository
    {
        Task<IEnumerable<ProductCategory>> GetAll();
    }
}
