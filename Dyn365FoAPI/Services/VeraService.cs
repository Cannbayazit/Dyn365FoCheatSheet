using System.Data;
using System.Data.OleDb;

namespace Dyn365FoAPI.Services
{
    public class VeraService
    {
        private const string ConnectionString = "Provider=IBMDA400;Data Source=10.3.0.7;User ID=UYG_PER;Password=UYG_PER";

        public async Task<DataTable> ExecuteQueryAsync(string sql)
        {
            using var connection = new OleDbConnection(ConnectionString);
            using var command = new OleDbCommand(sql, connection);
            var dataTable = new DataTable();

            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();
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
