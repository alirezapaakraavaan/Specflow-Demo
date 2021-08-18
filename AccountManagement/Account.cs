using System.Linq;

namespace AccountManagement
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Authenticate()
        {
            return DataStore.Accounts.Any(x => x.Username == Username && x.Password == Password)
                ? "Authenticated"
                : "Access Denied";
        }
    }
}