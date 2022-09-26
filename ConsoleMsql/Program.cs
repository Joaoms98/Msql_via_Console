using ConsoleMsql.Repository;

UserRepository user = new UserRepository();

Console.WriteLine("--------------Welcome to your database!----------------");
Console.WriteLine("--------------Press 1: for add user--------------------");
Console.WriteLine("--------------Press 2: for view all users--------------");
Console.WriteLine("--------------Press 3: for search a user---------------");
Console.WriteLine("--------------Press 4: for skip------------------------");

var option = Console.ReadLine();

while (option != "4")
{
    option = Console.ReadLine();

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
    if(option == "4")
    {
        break;
    }
}