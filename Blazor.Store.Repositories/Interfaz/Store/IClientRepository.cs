using Blazor.Store.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Store.Repositories.Interfaz.Store
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAll();
    }
}
