using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyn365FoCheatSheet.Services
{
    internal class VeraService
    {
        private const string ConnectionString = "Provider=IBMDA400;Data Source=10.3.0.7;User ID=UYG_PER;Password=UYG_PER";

        public  DataTable ExecuteQuery(string filePath,string extendQuery="")
        {
            
            using var connection = new OleDbConnection(ConnectionString);

            if (extendQuery != "")
            {
                BaseService.AppendUniqueQueryToFile(filePath, extendQuery);
            }

            string sql = File.ReadAllText(filePath, Encoding.UTF8);


            using var command = new OleDbCommand(sql, connection);
            var dataTable = new DataTable();

            connection.OpenAsync();
            using var reader =  command.ExecuteReader();
            dataTable.Load(reader);

            return dataTable;
        }

        public async Task<int> ExecuteNonQueryAsync(string sql)
        {
            using var connection = new OleDbConnection(ConnectionString);
            using var command = new OleDbCommand(sql, connection);

            await connection.OpenAsync();
            return await command.ExecuteNonQueryAsync();
        }
    }
}
