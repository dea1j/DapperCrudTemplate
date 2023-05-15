using System;
using DapperCrud.Entities;

namespace DapperCrud.Contracts
{
	public interface ICompanyRepository
	{
		public Task<IEnumerable<Company>> GetCompanies();
	}
}

