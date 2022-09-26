using Dapper;
using ConsoleMsql.Data;
using ConsoleMsql.Models;

namespace ConsoleMsql.Repository
{
    public class UserRepository : ConnectionString
    { 
        public void NewUser()
        {
            string name;
            string email; 
            string password; 

            Console.Write("Whrite user name: ");
            name = Console.ReadLine();
            Console.Write("Whrite user email: ");
            email = Console.ReadLine();
            Console.Write("Whrite user password: ");
            password = Console.ReadLine();

            Connection.Execute
            ($"insert into User (Name, Email, Password) values ('{name}', '{email}', '{password}')");

            Console.WriteLine("Usuário cadastrado com sucesso");
        }

        public void GetUsers()
        {
            var users = Connection.Query<UserModel>
            ($"Select * from User;");

            Console.WriteLine(string.Join(Environment.NewLine,
            users.Select(u => $"{u.Id},{u.Name}, {u.Email}, {u.Password}, {u.BirthDate}")));   
        }

        public void GetUserByAtribute()
        {
            string parameterSearch, attributeName;

            Console.WriteLine("Whrite the parameter search");
            parameterSearch = Console.ReadLine();

            Console.WriteLine("whrite the attributename");
            attributeName = Console.ReadLine();

            var users = Connection.Query<UserModel>
            ($"Select * from User Where {parameterSearch} = '{attributeName}';");

            Console.WriteLine(string.Join(Environment.NewLine,
            users.Select(u => $"{u.Id},{u.Name}, {u.Email}, {u.Password}, {u.BirthDate}")));   
        }
    }
}