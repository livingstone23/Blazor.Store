using Blazor.Store.Repositories.Interfaz.Store;
using Blazor.Store.Shared.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blazor.Store.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Order order )
        {
            if (order == null)
                return BadRequest();

            if (order.OrderNumber == 0)
                ModelState.AddModelError("Order Number", "Order number can't be empty");

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            await _orderRepository.InsertOrder(order);

            return NoContent();
        }
    }
}
