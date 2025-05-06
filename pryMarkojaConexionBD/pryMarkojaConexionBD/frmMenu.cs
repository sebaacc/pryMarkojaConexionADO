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
    public partial class frmMenu : Form
    {
        public frmMenu()
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
                clsBDConexion.ProbarConexion(); 
                listaProductos.productos = clsBDConexion.CargarListaProductos();

                listaProductos.CargarGrilla(dgvDatos);
                dgvDatos.Columns["codigo"].HeaderText = "Código";
                dgvDatos.Columns["nombre"].HeaderText = "Nombre";
                dgvDatos.Columns["descripcion"].HeaderText = "Descripción";
                dgvDatos.Columns["precio"].HeaderText = "Precio";
                dgvDatos.Columns["stock"].HeaderText = "Stock";
                dgvDatos.Columns["categoria"].HeaderText = "Categoría";
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void CargarProducto()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!int.TryParse(txtCodigo.Text, out int codigo))
                {
                    MessageBox.Show("El código debe ser un número entero.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("El precio debe ser un número decimal válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtStock.Text, out int stock))
                {
                    MessageBox.Show("El stock debe ser un número entero.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verifica si el producto ya existe
                var productoExistente = listaProductos.BuscarProducto(codigo);
                if (productoExistente != null)
                {
                    MessageBox.Show("Ya existe un producto con ese código.", "Producto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                string categoria = txtCategoria.Text.Trim();

                listaProductos.CargarProducto(codigo, nombre, descripcion, precio, stock, categoria);
                listaProductos.GuardarDatos(); // Se guarda el dato en la bd.
                listaProductos.CargarGrilla(dgvDatos); // Se muestra la dgv actualizada.
                
                txtCodigo.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtCategoria.Clear();
                txtStock.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarProducto();
            }catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error" + ex);
            }
        }
    }
}
