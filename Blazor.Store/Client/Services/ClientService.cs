using Blazor.Store.Client.Services.Interface;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blazor.Store.Client.Services
{
    public class ClientService : IClientService
    {
        private readonly HttpClient _httpClient;
        public ClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Blazor.Store.Shared.Model.Client>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Blazor.Store.Shared.Model.Client>>($"api/client");
        }

    }
}
