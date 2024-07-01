using MySqlConnector;
using System.Data;

namespace BuscadorPrecio
{
    internal static class DbUtils
    {
        private static string connectionString = "Server=localhost;Database=productose;Uid=root;Pwd=;";

        // Método para obtener la cadena de conexión
        public static string GetConnectionString()
        {
            return connectionString;
        }

        // Método para ejecutar una consulta SQL que devuelve un DataTable
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

        // Ejemplo de método para ejecutar una consulta de modificación (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
    }
}
