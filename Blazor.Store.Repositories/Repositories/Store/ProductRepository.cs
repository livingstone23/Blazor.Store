using Blazor.Store.Repositories.Interfaz.Store;
using Blazor.Store.Shared.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Store.Repositories.Repositories.Store
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProductRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Product>> GetByCategory(int productCategoryId)
        {
            var sql = @"Select Id, Name, Price, CategoryId From Products Where CategoryId = @Id";

            return await _dbConnection.QueryAsync<Product>(sql, new { Id = productCategoryId });
        }
    }
}
