namespace Dyn365FoCheatSheet.Services
{
    public class AuthService
    {
        private readonly List<User> _testUsers = new()
        {
            new User
            {
                Username = "1",
                PasswordHash = "1",
                Role = "Administrator"
            },
            new User
            {
                Username = "asaglik",
                PasswordHash = "1234",
                Role = "developer"
            }
           
        };

        public Task<bool> LoginAsync(string username, string password)
        {
            bool isValid = _testUsers.Any(u => u.Username == username && u.PasswordHash == password);
            return Task.FromResult(isValid);
        }

        public User? GetCurrentUser(string username)
        {
            return _testUsers.FirstOrDefault(u => u.Username == username);
        }
    }
}