using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ProductoDAO
    {
        public DataTable ObtenerTodos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                string query = "SELECT * FROM Productos WHERE Activo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable ObtenerPorTipo(string tipo)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                string query = "SELECT * FROM Productos WHERE Tipo = @Tipo AND Activo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Tipo", tipo);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool Insertar(string nombre, string tipo, decimal precio, string descripcion, string categoria)
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                string query = "INSERT INTO Productos (Nombre, Tipo, Precio, Descripcion, Categoria) VALUES (@Nombre, @Tipo, @Precio, @Descripcion, @Categoria)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Tipo", tipo);
                command.Parameters.AddWithValue("@Precio", precio);
                command.Parameters.AddWithValue("@Descripcion", descripcion);
                command.Parameters.AddWithValue("@Categoria", categoria);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public decimal ObtenerPrecio(int idProducto)
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                string query = "SELECT Precio FROM Productos WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", idProducto);

                connection.Open();
                var result = command.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }

        public DataTable ObtenerPlatillos()
        {
            return ObtenerPorTipo("Platillo");
        }

        public DataTable ObtenerBebidas()
        {
            return ObtenerPorTipo("Bebida");
        }
    }
}