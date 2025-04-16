using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                    return true; // Indica que la conexión fue exitosa
                }
                catch (SqlException ex) // Es mejor capturar excepciones específicas de SQL
                {
                    MessageBox.Show($"❌ Error al conectar a la base de datos: {ex.Message}\n\nDetalles:\n{ex.StackTrace}");
                    return false; // Indica que la conexión falló
                }
                catch (Exception ex) // Captura otras posibles excepciones
                {
                    MessageBox.Show($"❌ Error inesperado al conectar: {ex.Message}\n\nDetalles:\n{ex.StackTrace}");
                    return false;
                }
            }
        }

    }
}