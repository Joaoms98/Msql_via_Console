using MySql.Data.MySqlClient;

namespace ConsoleMsql.Data
{
    public class ConnectionString
    {
        public static MySqlConnection Connection { get; set; }

         public ConnectionString()
         {
            Connection = new MySqlConnection
            ("server=localhost;port=3306;database=ConsoleMsql;user=root;password=Sociologia@98;Persist Security Info=false;Connect Timeout=300");
         }
    }
}