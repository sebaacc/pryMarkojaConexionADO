using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMarkojaConexionBD
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        int codigo;
        String nombre;
        String descripcion;
        String categoria;
        decimal precio;
        int stock;
        clsListaProductos listaProductos = new clsListaProductos();

        private void frm_menu_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDatos.Columns.Add("Codigo", "Código");
                dgvDatos.Columns.Add("Nombre", "Nombre");
                dgvDatos.Columns.Add("Descripcion", "Descripción");
                dgvDatos.Columns.Add("Precio", "Precio");
                dgvDatos.Columns.Add("Categoria", "Categoría");
                dgvDatos.Columns.Add("Stock", "Stock");

                clsBDConexion.ProbarConexion(); 
                //listaProductos.productos = clsBDConexion.BuscarProductos();
                //MessageBox.Show(listaProductos.productos[0].nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            //clsBDConexion.buscar_producto();
        }

        private void cargar()
        {
            try
            {
                codigo = Convert.ToInt32(txtCodigo.Text);
                nombre = txtNombre.Text;
                descripcion = txtDescripcion.Text;
                precio = Convert.ToDecimal(txtPrecio.Text);
                categoria = txtCategoria.Text;
                stock = Convert.ToInt32(txtStock.Text);

                listaProductos.cargarProducto(codigo, nombre, descripcion, precio, stock, categoria);

                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
                txtPrecio.Text = "";
                txtCategoria.Text = "";
                txtStock.Text = "";

                //falta recorrer lista y mostrar en la grilla.
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: Ingresa datos válidos en los campos numéricos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        private void eliminar()
        {
            try
            {
                // Obtiene el código a eliminar del TextBox
                String codigoEliminar = txtCodigoEliminar.Text;

                // Itera a través de las filas del DataGridView
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    // Verifica si el código de la fila coincide con el código a eliminar
                    if (row.Cells["Codigo"].Value != null && row.Cells["Codigo"].Value.ToString() == codigoEliminar)
                    {
                        dgvDatos.Rows.Remove(row);

                        MessageBox.Show("Producto con código " + codigoEliminar + " eliminado.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpia el TextBox de código a eliminar.
                        txtCodigoEliminar.Text = "";

                        // Sale del bucle, ya que se encontró y eliminó la fila
                        return;
                    }
                }

                // Si no se encontró el código, muestra un mensaje de error
                MessageBox.Show("No se encontró ningún producto con el código " + codigoEliminar + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void eliminar(String codigoEliminar)
        {
            try
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Cells["Codigo"].Value != null && row.Cells["Codigo"].Value.ToString() == codigoEliminar)
                    {
                        dgvDatos.Rows.Remove(row);

                        MessageBox.Show("Producto con código " + codigoEliminar + " eliminado.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                        txtCodigoEliminar.Text = "";

                        return;
                    }
                }

                MessageBox.Show("No se encontró ningún producto con el código " + codigoEliminar + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void modificar()
        {
            if(!string.IsNullOrEmpty(txtModificar.Text))
            {
                try
                {
                    foreach (DataGridViewRow fila in dgvDatos.Rows)
                    {
                        if (fila.IsNewRow) continue;

                        if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == txtModificar.Text)
                        {
                            txtCodigo.Text = txtModificar.Text;
                            txtNombre.Text = fila.Cells[1].Value?.ToString();
                            txtDescripcion.Text = fila.Cells[2].Value?.ToString();
                            txtPrecio.Text = fila.Cells[3].Value?.ToString();
                            txtCategoria.Text = fila.Cells[4].Value?.ToString();
                            txtStock.Text = fila.Cells[5].Value?.ToString();
                            break;
                        }
                    }
                    eliminar(txtModificar.Text);
                    MessageBox.Show("Proceda a modificar los datos del producto y luego haga clic en cargar. De lo contrario, se perderan los datos.", "Información para modificar");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error: Ingresa un codigo válido. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un código de producto existente.");
            }
        }
        */
    }
}
