using Blazor.Store.Shared.Model;
using System.Threading.Tasks;

namespace Blazor.Store.Client.Services.Interface
{
    public interface IOrderService
    {
        Task SaveOrder(Order order);

    }
}
