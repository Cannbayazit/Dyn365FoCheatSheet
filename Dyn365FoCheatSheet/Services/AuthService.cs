namespace Dyn365FoCheatSheet.Services
{
    public class AuthService
    {
        private readonly User _testUser = new User
        {
            Username = "admin",
            PasswordHash = "1234"
        };

        public Task<bool> LoginAsync(string username, string password)
        {
            bool isValid = username == _testUser.Username && password == _testUser.PasswordHash;
            return Task.FromResult(isValid);
        }
    }
}