using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionDB
    {
        private static string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=RestauranteDB;Integrated Security=true;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}