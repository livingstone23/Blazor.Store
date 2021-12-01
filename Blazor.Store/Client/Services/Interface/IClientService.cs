using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Store.Client.Services.Interface
{
    public interface IClientService
    {
        Task<IEnumerable<Blazor.Store.Shared.Model.Client>> GetAll();
    }
}
