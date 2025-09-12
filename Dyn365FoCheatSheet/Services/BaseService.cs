using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyn365FoCheatSheet.Services
{
    public class BaseService
    {
        public static void AppendQueryToFile(string filePath, string query)
        {
            File.AppendAllTextAsync(filePath, Environment.NewLine + query, Encoding.UTF8);
        }

        public static void AppendUniqueQueryToFile(string filePath, string query)
        {
            string existingContent = File.Exists(filePath)
                ? File.ReadAllText(filePath, Encoding.UTF8)
                : string.Empty;

            if (!existingContent.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                File.AppendAllText(filePath, Environment.NewLine + query, Encoding.UTF8);
            }
        }

        public static void RemoveQueryFromFile(string filePath, string query)
        {
            if (!File.Exists(filePath))
                return;

            var lines = File.ReadAllLines(filePath, Encoding.UTF8);

            // Sorgu ile tam eşleşen satırları kaldır
            var updatedLines = lines
                .Where(line => !line.Equals(query, StringComparison.OrdinalIgnoreCase))
                .ToArray();

            File.WriteAllLines(filePath, updatedLines, Encoding.UTF8);
        }
    }
}
