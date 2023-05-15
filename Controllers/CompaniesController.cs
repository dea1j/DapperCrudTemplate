using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperCrud.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DapperCrud.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : Controller
    {
        private readonly ICompanyRepository _companyRepo;

        public CompaniesController(ICompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _companyRepo.GetCompanies();

            return Ok(companies);
        }
    }
}