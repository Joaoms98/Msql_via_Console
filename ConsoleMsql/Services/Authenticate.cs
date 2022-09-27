using ConsoleMsql.Models;

namespace ConsoleMsql.Services
{
    public class Authenticate
    {
        Admin admin = new Admin();

        public void Login (string email, string password)
        {
            if (email != admin.email && password != admin.password)
            {
                throw new Exception("!!!! [Login invalid] !!!!");
            }
        }
    }
}