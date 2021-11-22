﻿using Blazor.Store.Repositories.interfaz.store;
using Blazor.Store.Shared.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Store.Repositories.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProductCategoryRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<IEnumerable<ProductCategory>> GetAll()
        {
            var sql = @"Select Id as Id, Name as Name  
                        From ProductCategories ";



            return await _dbConnection.QueryAsync<ProductCategory>(sql, new { });
        }
    }
}
