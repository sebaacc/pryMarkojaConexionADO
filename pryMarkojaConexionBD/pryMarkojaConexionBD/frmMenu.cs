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

        clsListaProductos listaProductos = new clsListaProductos();
        List<string> categorias = new List<string>() {
            "Alimentos",
            "Electrónicos",
            "Bazar/Librería",
            "Limpieza",
            "Perfumes",
            "Indumentaria",
            "Hogar",
            "Juguetería",
            "Automotor"
        };
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
                dgvDatos.ReadOnly = true;
                foreach (string categoria in categorias)
                {
                    cmbCategoria.Items.Add(categoria);
                }
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
                string.IsNullOrWhiteSpace(cmbCategoria.Text) ||
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
                clsProducto productoExistente = listaProductos.BuscarProducto(codigo);
                if (productoExistente != null)
                {
                    MessageBox.Show("Ya existe un producto con ese código.", "Producto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                string categoria = cmbCategoria.Text.Trim();

                listaProductos.CargarProducto(codigo, nombre, descripcion, precio, stock, categoria);
                listaProductos.GuardarDatos(); // Se guarda el dato en la bd.
                listaProductos.CargarGrilla(dgvDatos); // Se muestra la dgv actualizada.

                FormatearCampos();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error" + ex);
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvDatos.SelectedRows[0];

                if (filaSeleccionada.Cells.Count > 0)
                {
                    if (filaSeleccionada.Cells[0].Value != null)
                    {
                        txtCodigo.Text = filaSeleccionada.Cells[0].Value.ToString();
                    }
                    else
                    {
                        txtCodigo.Text = "";
                    }

                    if (filaSeleccionada.Cells[1].Value != null)
                    {
                        txtNombre.Text = filaSeleccionada.Cells[1].Value.ToString();
                    }
                    else
                    {
                        txtNombre.Text = "";
                    }
                    if (filaSeleccionada.Cells[2].Value != null)
                    {
                        txtDescripcion.Text = filaSeleccionada.Cells[2].Value.ToString();
                    }
                    else
                    {
                        txtDescripcion.Text = "";
                    }
                    if (filaSeleccionada.Cells[3].Value != null)
                    {
                        txtPrecio.Text = filaSeleccionada.Cells[3].Value.ToString();
                    }
                    else
                    {
                        txtPrecio.Text = "";
                    }
                    if (filaSeleccionada.Cells[4].Value != null)
                    {
                        txtStock.Text = filaSeleccionada.Cells[4].Value.ToString();
                    }
                    else
                    {
                        txtStock.Text = "";
                    }
                    if (filaSeleccionada.Cells[5].Value != null)
                    {
                        string categoriaSeleccionada = filaSeleccionada.Cells[5].Value.ToString();
                        if (cmbCategoria.Items.Contains(categoriaSeleccionada))
                        {
                            cmbCategoria.SelectedItem = categoriaSeleccionada;
                        }
                        else
                        {
                            cmbCategoria.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        cmbCategoria.SelectedIndex = -1;
                    }

                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Selecciona un producto para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCodigo.Text, out int codigo) ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio) ||
                !int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Código, precio o stock con formato incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string categoria = cmbCategoria.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsProducto productoModificado = new clsProducto(codigo, nombre, descripcion, precio, stock, categoria);
            listaProductos.ModificarProducto(productoModificado);
            listaProductos.GuardarDatos();
            listaProductos.CargarGrilla(dgvDatos);

            MessageBox.Show("Producto modificado correctamente.", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormatearCampos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || !int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Selecciona un producto válido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                listaProductos.EliminarProducto(codigo);
                listaProductos.GuardarDatos();
                listaProductos.CargarGrilla(dgvDatos);

                MessageBox.Show("Producto eliminado correctamente.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigo.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                cmbCategoria.SelectedIndex = -1;
                txtStock.Clear();
            }
        }
        private void FormatearCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtStock.Clear();
        }
    }
}
