using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyn365FoCheatSheet.Models
{
    internal class EmployeeSalary
    {
        public string?  Adi{ get; set; }
        public string?  SoyadAdi{ get; set; }
        public decimal? NetMaas { get; set; }   // C13NETMAAS
        public decimal? Kestop { get; set; }    // C13KESTOP
        public string CalKod { get; set; }

        public decimal? Ucret { get; set; }     // B79UCRET
        public decimal? OdesNo { get; set; }        // B79ODESNO
        public decimal? OdeYil { get; set; }        // B79ODEYIL

    }
}
