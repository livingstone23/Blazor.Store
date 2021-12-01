using Blazor.Store.Repositories.Interfaz.Store;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Store.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Blazor.Store.Shared.Model.Client>> Get()
        {
            return await _clientRepository.GetAll();
        }


    }
}
