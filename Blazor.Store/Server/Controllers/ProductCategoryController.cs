
using Blazor.Store.Repositories.interfaz.store;
using Blazor.Store.Shared.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Store.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {


        private readonly IProductCategoryRepository _productCategoryRepository;


        public ProductCategoryController(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<ProductCategory>> Get()
        {
            return await _productCategoryRepository.GetAll();
        }


    }

    
}
