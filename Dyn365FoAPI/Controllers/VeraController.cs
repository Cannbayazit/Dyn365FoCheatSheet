using Dyn365FoAPI.Models;
using Dyn365FoAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Dyn365FoAPI.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class VeraController : ControllerBase
    {
        [HttpPost]
        [Route("getEmployees")]
        public List<Employee> GetEmployes()
        {
           VeraService veraService = new VeraService();

            var dt = veraService.ExecuteQueryAsync("SELECT Z5CALADI, Z5CALSOY, Z5UNVAN FROM vperlibp.permasf").Result;
            List<Employee> employees = new List<Employee>();
            foreach (DataRow row in dt.Rows)
            {
                employees.Add(new Employee
                {
                    Id = 1,
                    Name = row["Z5CALADI"].ToString(),
                    LastName = row["Z5CALSOY"].ToString(),
                    Sector = row["Z5UNVAN"].ToString()
                });
            }
            return employees;
        }


    }
}
