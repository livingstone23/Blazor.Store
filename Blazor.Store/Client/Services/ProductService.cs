using Blazor.Store.Client.Services.Interface;
using Blazor.Store.Shared.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blazor.Store.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Product>> GetByCategory(int productCategoryId)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Product>>($"api/product/GetByCategory/{productCategoryId}");

        }

        public async Task<Product> GetDetails(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"api/product/{id}");
        }
    }
}
