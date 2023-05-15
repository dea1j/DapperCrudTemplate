using System;
using Dapper;
using DapperCrud.Context;
using DapperCrud.Contracts;
using DapperCrud.Entities;

namespace DapperCrud.Repository
{
	public class CompanyRepository : ICompanyRepository
    {
		private readonly DapperContext _context;

        public CompanyRepository(DapperContext context) => _context = context;


        public async Task<IEnumerable<Company>> GetCompanies()
        {
            var query = "SELECT * FROM Companies";

            using (var connection = _context.CreateConnection())
            {
                var companies = await connection.QueryAsync<Company>(query);
                return companies;
            }
        }
    }
}

