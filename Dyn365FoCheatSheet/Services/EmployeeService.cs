using Dyn365FoCheatSheet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyn365FoCheatSheet.Services
{
    internal class EmployeeService
    {

        public List<Employee> GetAllEmployee(DataTable dt)
        {

            List<Employee> employees = dt.AsEnumerable()
            .Select(row => new Employee
            {
                //SAYI = row.Field<int>("SAYI"),
                ISLETME = row.Field<string>("ISLETME"),
                //FIILIBOLUMKODU = row.Field<string>("FIILIBOLUMKODU"),
                //GECENYILDANDEVIR = row.Field<decimal>("GECENYILDANDEVIR"),
                //BUYILKULLANILAN = row.Field<decimal>("BUYILKULLANILAN"),
                //HAKEDILENYILLIKIZIN = row.Field<decimal>("HAKEDILENYILLIKIZIN"),
                //FIILIBIRIMKODU = row.Field<string>("FIILIBIRIMKODU"),
                SICILNO = row.Field<string>("SICILNO"),
                ADI = row.Field<string>("ADI"),
                SOYADI = row.Field<string>("SOYADI"),
                UNVANKODU = row.Field<string>("UNVANKODU"),
                UNVANADI = row.Field<string>("UNVANADI"),
                //KISIMKODU = row.Field<string>("KISIMKODU"),
                //KISIMTANIMI = row.Field<string>("KISIMTANIMI"),
                //TCNO = row.Field<string>("TCNO"),
                //AYRILMAKODU = row.Field<string>("AYRILMAKODU"),
                ISYERIADI = row.Field<string>("ISYERIADI"),
                //AYRILMAYIL = row.Field<string>("AYRILMAYIL"),
                //SGKISTENAYRILMA = row.Field<string>("SGKISTENAYRILMA"),
                //AYRILMAAY = row.Field<string>("AYRILMAAY"),
                //AYRILMAGUN = row.Field<string>("AYRILMAGUN"),
                //FIILISIRKETKODU = row.Field<string>("FIILISIRKETKODU"),
                //ISYERIKODU = row.Field<string>("ISYERIKODU"),
                //FIILIBIRIMTANIMI = row.Field<string>("FIILIBIRIMTANIMI"),
                //FIILIBOLUMTANIMI = row.Field<string>("FIILIBOLUMTANIMI"),
                //ISEBASLAMATARIHI = row.Field<int>("ISEBASLAMATARIHI"),
                //TAZMINATGIRISTARIHI = row.Field<string>("TAZMINATGIRISTARIHI"),
                //GRUBAGIRISTARIHI = row.Field<string>("GRUBAGIRISTARIHI"),
                //TAHSILKODU = row.Field<string>("TAHSILKODU"),
                //TAHSILTANIMI = row.Field<string>("TAHSILTANIMI"),
                //DOGUMTARIHIYIL = row.Field<int>("DOGUMTARIHIYIL"),
                //DOGUMTARIHIGUN = row.Field<int>("DOGUMTARIHIGUN"),
                //DOGUMTARIHIAY = row.Field<int>("DOGUMTARIHIAY"),
                //ILCE = row.Field<string>("ILCE"),
                //ILPLAKAKODU = row.Field<string>("ILPLAKAKODU"),
                //TELEFONNO1 = row.Field<string>("TELEFONNO1"),
                //SIRKETKODU = row.Field<string>("SIRKETKODU"),
                //GOREVLISIRKETKODU = row.Field<string>("GOREVLISIRKETKODU"),
                //GOREVLISIRKETADI = row.Field<string>("GOREVLISIRKETADI"),
                //Z5RZV15 = row.Field<string>("Z5RZV15"),
                //Z5ONCISY = row.Field<string>("Z5ONCISY"),
                //Z5ONCISYU = row.Field<string>("Z5ONCISYU"),
                //Z5GRVKOD1 = row.Field<string>("Z5GRVKOD1"),
                //FIILIUNVANKODU = row.Field<string>("FIILIUNVANKODU"),
                //FIILIUNVANADI = row.Field<string>("FIILIUNVANADI"),
                //UYRUK = row.Field<string>("UYRUK"),
                CINSIYET = row.Field<string>("CINSIYET")
            }).ToList();

            return employees;

        }

    }
}
