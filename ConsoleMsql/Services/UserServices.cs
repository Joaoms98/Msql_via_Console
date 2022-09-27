namespace ConsoleMsql.Services
{
    public class UserServices
    {
        public bool UserIsValid(string name, string email)
        {
            if(!email.Contains("@") && !email.Contains(".com"))
            {
                Console.WriteLine("!!!! [Invalid email address provided] !!!!");
                return false;
            }
            
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("!!!! [Name must not be empty.] !!!!");
                return false;
            }
            
            if(name.Length > 25)
            {
                Console.WriteLine("!!!! [name must be minor 25 characters] !!!!");
                return false;
            }
            
            if(email.Length > 25)
            {
                Console.WriteLine("!!!! [email must be minor 25 characters] !!!!");
                return false;
            }

            return true;
        }
    }
}