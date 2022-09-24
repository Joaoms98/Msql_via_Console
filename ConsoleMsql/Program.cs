using Dapper;
using MySql.Data.MySqlClient;

var connection = new MySqlConnection
    ("server=localhost;port=3306;database=ConsoleMsql;user=root;password=*********;Persist Security Info=false;Connect Timeout=300");

var users = connection.Query<User>
    ("Select id, name, email, password, birthDate from User;");


// string name = "Lucas";
// string email = "lucas@example.com";
// string password = "password";

// var user = connection.Execute($"insert into User (Name, Email, Password) values ('{name}', '{email}', '{password}')");

Console.WriteLine(string.Join(Environment.NewLine,
    users.Select(u => $"{u.Name}, {u.Email}, {u.Password}, {u.BirthDate}")));

// Console.WriteLine(user);

public record User(int Id, string Name, string Email, string Password, DateTime BirthDate);
