using MySqlConnector;
using System.Data;

namespace BuscadorPrecio
{
    internal static class DbUtils
    {
        private static string connectionString = "Server=localhost;Database=productose;Uid=root;Pwd=;";

        public static DataTable ExecuteQuery(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    connection.Open();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
            }
        }
    }
}
