using System;
using System.Security.Cryptography;
using System.Text;

namespace Dyn365FoCheatSheet.Services
{
    internal class TokenService
    {
        public string GeneratePassword(string sirKod)
        {
            // Convert sirKod to bytes
            var sirKodBytes = Encoding.UTF8.GetBytes(sirKod);

            // Calculate how many random bytes are needed
            // Base64 encoding: 3 bytes -> 4 chars, so for 200 chars: (200 / 4) * 3 = 150 bytes
            int totalBytesNeeded = (int)Math.Ceiling(200 * 3.0 / 4.0);
            int randomBytesNeeded = Math.Max(0, totalBytesNeeded - sirKodBytes.Length);

            // Generate random bytes
            var randomBytes = new byte[randomBytesNeeded];
            RandomNumberGenerator.Fill(randomBytes);

            // Combine sirKod bytes and random bytes
            var combinedBytes = new byte[sirKodBytes.Length + randomBytes.Length];
            Buffer.BlockCopy(sirKodBytes, 0, combinedBytes, 0, sirKodBytes.Length);
            Buffer.BlockCopy(randomBytes, 0, combinedBytes, sirKodBytes.Length, randomBytes.Length);

            // Convert to Base64 string
            var base64 = Convert.ToBase64String(combinedBytes);

            // Ensure the result is exactly 200 characters
            if (base64.Length > 200)
                base64 = base64.Substring(0, 200);
            else if (base64.Length < 200)
                base64 = base64.PadRight(200, 'A'); // Pad with 'A' if needed

            return base64;
        }
    }
}
