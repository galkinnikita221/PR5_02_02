using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes
{
    public class Connection
    {
        private static string conf = "server=localhost;port=3306;database=pr5;uid=root;pwd=root;";
        public static MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection(conf);
            connection.Open();
            return connection;
        }
        public static MySqlDataReader Query(string Query, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(Query, connection);
            return command.ExecuteReader();
        }
        public static void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
            MySqlConnection.ClearPool(connection);
        }
    }
}
