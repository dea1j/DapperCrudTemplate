using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DapperCrud.Context
{
	public class DapperContext
	{
		private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration, string connectionString)
        {
            _configuration = configuration;
            _connectionString = configuration.GetConnectionString("sqlConnection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}

