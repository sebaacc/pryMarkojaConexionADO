using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace pryMarkojaConexionBD
{
    public class cls_bd_conexion
    {
        private const string ConnectionString = "Server=localhost;Database=Tienda;Trusted_Connection=True;";
        public static bool probar_conexion()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("✅ Conexión exitosa a la base de datos.");
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"❌ Error al conectar a la base de datos: {ex.Message}\n\nDetalles:\n{ex.StackTrace}");
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Error inesperado al conectar: {ex.Message}\n\nDetalles:\n{ex.StackTrace}");
                    return false;
                }
            }
        }
        public static void buscar_producto()
        {
            string query = "SELECT * FROM Productos";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        MessageBox.Show($"{reader["Nombre"]} - {reader["Descripcion"]}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Error inesperado al conectar: {ex.Message}\n\nDetalles:\n{ex.StackTrace}");
                }

            }
        }
    }
}