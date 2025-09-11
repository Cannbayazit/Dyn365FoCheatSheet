using Dyn365FoCheatSheet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyn365FoCheatSheet.Services
{
    internal class SalaryService
    {
        public List<EmployeeSalary> GetEmployeeSalaries(DataTable dt)
        {
            List<EmployeeSalary> employeeSalaries = dt.AsEnumerable()
            .Select(row => new EmployeeSalary
            {
                Adi = row.Field<string>("Z5CALADI"),
                SoyadAdi = row.Field<string>("Z5CALSOY"),
                CalKod = row.Field<string>("C13CALKOD"),
                NetMaas = row.Field<decimal?>("C13NETMAAS"),
                //Kestop = row.Field<decimal?>("C13KESTOP"),
                Ucret = row.Field<decimal?>("B79UCRET"),
                OdesNo = row.Field<decimal?>("B79ODESNO"),
                OdeYil = row.Field<decimal>("B79ODEYIL"),
            }).ToList();
            return employeeSalaries;
        }
    }
}
