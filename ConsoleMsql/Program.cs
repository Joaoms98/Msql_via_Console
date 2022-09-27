using ConsoleMsql.Repository;
using ConsoleMsql.Services;

UserRepository user = new UserRepository();
Authenticate login = new Authenticate();

Console.WriteLine("--------------Welcome to your database!----------------");
Console.WriteLine("-----------------------Login---------------------------");
Console.Write("Email: ");
var email = Console.ReadLine();
Console.Write("Password: ");
var password = Console.ReadLine();

login.Login(email, password);

Console.WriteLine($"-------------Olá {email}--------------------------");
Console.WriteLine("--------------Press 1: for add user--------------------");
Console.WriteLine("--------------Press 2: for view all users--------------");
Console.WriteLine("--------------Press 3: for search a user---------------");
Console.WriteLine("--------------Press 4: for skip------------------------");

var option = Console.ReadLine();

while (option != "4")
{
    if(option == "1")
    {
        user.NewUser();
    }
    if(option == "2")
    {
        user.GetUsers(); 
    }
    if(option == "3")
    {
        user.GetUserByAtribute();
    }

    Console.WriteLine("--------------Press 1: for add user--------------------");
    Console.WriteLine("--------------Press 2: for view all users--------------");
    Console.WriteLine("--------------Press 3: for search a user---------------");
    Console.WriteLine("--------------Press 4: for skip------------------------");
    option = Console.ReadLine();

    if(option == "4")
    {
        break;
    }
}