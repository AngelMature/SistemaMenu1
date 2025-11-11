using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class EmpleadoDB
    {
        public DataTable ObtenerTodos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                string query = "SELECT * FROM Empleados WHERE Activo = 1";
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
                string query = "SELECT * FROM Empleados WHERE Tipo = @Tipo AND Activo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Tipo", tipo);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool Insertar(string nombre, string tipo, decimal salario, DateTime fechaContratacion)
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                string query = "INSERT INTO Empleados (Nombre, Tipo, Salario, FechaContratacion) VALUES (@Nombre, @Tipo, @Salario, @Fecha)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Tipo", tipo);
                command.Parameters.AddWithValue("@Salario", salario);
                command.Parameters.AddWithValue("@Fecha", fechaContratacion);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ObtenerMeseros()
        {
            return ObtenerPorTipo("Mesero");
        }

        public DataTable ObtenerChefs()
        {
            return ObtenerPorTipo("Chef");
        }

        public DataTable ObtenerCajeros()
        {
            return ObtenerPorTipo("Cajero");
        }
    }
}