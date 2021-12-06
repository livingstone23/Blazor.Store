using Blazor.Store.Repositories.Interfaz.Store;
using Blazor.Store.Shared.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Store.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;


        public ProductController(IProductRepository productCategoryRepository)
        {
            _productRepository = productCategoryRepository;
        }

        [HttpGet("GetByCategory/{productCategoryId}")]
        public async Task<IEnumerable<Product>> GetByCategory(int productCategoryId)
        {
            return await _productRepository.GetByCategory(productCategoryId);
        }



        [HttpGet("{id}")]
        public async Task<Product> GeDetails(int id)
        {
            return await _productRepository.GetDatails(id);
        }


    }
}
