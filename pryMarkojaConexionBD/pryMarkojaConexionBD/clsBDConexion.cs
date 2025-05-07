using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pryMarkojaConexionBD
{
    public class clsBDConexion
    {
        private const string conexionString = "Server=localhost;Database=Tienda;Trusted_Connection=True;";
        public static bool ProbarConexion()
        {
            using (SqlConnection conexionBD = new SqlConnection(conexionString))
            {
                try
                {
                    string nombreBaseDeDatos = conexionBD.Database;
                    conexionBD.Open();
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
        public static BindingList<clsProducto> CargarListaProductos()
        {
            BindingList<clsProducto> productos = new BindingList<clsProducto>();
            string query = "SELECT * FROM Productos";

            try
            {
                using (SqlConnection connection = new SqlConnection(conexionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int codigo = Convert.ToInt32(reader["Codigo"].ToString());
                                string nombre = reader["Nombre"].ToString();
                                string descripcion = reader["Descripcion"].ToString();
                                decimal precio = Convert.ToDecimal(reader["Precio"].ToString());
                                int stock = Convert.ToInt32(reader["Stock"].ToString());
                                string categoria = reader["Categoria"].ToString();
                                clsProducto producto = new clsProducto(codigo, nombre, descripcion, precio, stock, categoria);
                                productos.Add(producto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error inesperado al buscar productos: {ex.Message}\n\nDetalles:\n{ex.StackTrace}");
            }
            return productos;
        }
        public void AgregarProducto(clsProducto producto)
        {
            try
            {
                using (SqlConnection conexionBD = new SqlConnection(conexionString))
                {
                    conexionBD.Open();

                    string insertQuery = "INSERT INTO Productos (Codigo, Nombre, Descripcion, Precio, Stock, Categoria) VALUES " +
                                         "(@codigo, @nombre, @descripcion, @precio, @stock, @categoria)";

                    using (SqlCommand comando = new SqlCommand(insertQuery, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@codigo", producto.codigo);
                        comando.Parameters.AddWithValue("@nombre", producto.nombre);
                        comando.Parameters.AddWithValue("@descripcion", producto.descripcion);
                        comando.Parameters.AddWithValue("@precio", producto.precio);
                        comando.Parameters.AddWithValue("@stock", producto.stock);
                        comando.Parameters.AddWithValue("@categoria", producto.categoria);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ActualizarProducto(clsProducto producto)
        {
            try
            {
                using (SqlConnection conexionBD = new SqlConnection(conexionString))
                {
                    conexionBD.Open();
                    string nombreBaseDeDatos = conexionBD.Database;

                    string actualizarProdQuery = "UPDATE Productos SET Nombre = @nombre, Descripcion = @descripcion, " +
                                         "Precio = @precio, Stock = @stock, Categoria = @categoria WHERE Codigo = @codigo";

                    using (SqlCommand comando = new SqlCommand(actualizarProdQuery, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@codigo", producto.codigo);
                        comando.Parameters.AddWithValue("@nombre", producto.nombre);
                        comando.Parameters.AddWithValue("@descripcion", producto.descripcion);
                        comando.Parameters.AddWithValue("@precio", producto.precio);
                        comando.Parameters.AddWithValue("@stock", producto.stock);
                        comando.Parameters.AddWithValue("@categoria", producto.categoria);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EliminarProducto(int codigo)
        {
            try
            {
                using (SqlConnection conexionBD = new SqlConnection(conexionString))
                {
                    conexionBD.Open();
                    string eliminarProdQuery = "DELETE FROM Productos WHERE Codigo = @codigo";
                    using (SqlCommand comando = new SqlCommand(eliminarProdQuery, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@codigo", codigo);
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}