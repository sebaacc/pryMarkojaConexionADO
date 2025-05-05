using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace pryMarkojaConexionBD
{
    public class clsBDConexion
    {
        private const string ConnectionString = "Server=localhost;Database=Tienda;Trusted_Connection=True;";
        public static bool ProbarConexion()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    string nombreBaseDeDatos = connection.Database;
                    connection.Open();
                    MessageBox.Show("✅ Conexión exitosa a la base de datos: " + nombreBaseDeDatos);
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
        public static List<clsProducto> BuscarProductos()
        {
            List<clsProducto> productos = new List<clsProducto>();
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
                        clsProducto producto = new clsProducto
                        {
                            codigo = Convert.ToInt32(reader["Codigo"].ToString()),
                            nombre = reader["Nombre"].ToString(),
                            descripcion = reader["Descripcion"].ToString(),
                            precio = Convert.ToDecimal(reader["Precio"].ToString()),
                            stock = Convert.ToInt32(reader["Stock"].ToString()),
                            categoria = reader["Categoria"].ToString()
                        };
                        productos.Add(producto);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Error inesperado al buscar productos: {ex.Message}\n\nDetalles:\n{ex.StackTrace}");
                }
            }
            connection.Close();
            return productos;
        }
    }
}