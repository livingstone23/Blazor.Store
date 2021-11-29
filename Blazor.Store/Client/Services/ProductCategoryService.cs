using Blazor.Store.Client.Services.Interface;
using Blazor.Store.Shared.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blazor.Store.Client.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly HttpClient _httpClient;

        public ProductCategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductCategory>> GetProductCategories()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ProductCategory>>($"api/productcategory");
        }


    }
}
