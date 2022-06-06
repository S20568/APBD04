using Cw5.Models;
using System.Threading.Tasks;

namespace Cw5.Services
{
    public interface IDbService
    {
        Task<int> AddProductToWarehouseAsync(ProductWarehouse productWarehouse);
    }
}
