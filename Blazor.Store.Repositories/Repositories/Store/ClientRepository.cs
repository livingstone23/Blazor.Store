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
    public  class ClientRepository : IClientRepository
    {
        private readonly IDbConnection _dbConnection;
        public ClientRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<IEnumerable<Client>> GetAll()
        {
            var sql = @"SELECT Id, FirstName, LastName, 
                                BirthDate, Phone, Address 
                        FROM Clients ";

            return await _dbConnection.QueryAsync<Client>(sql, new { });
        }
    }
}
