using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMarkojaConexionBD
{
    internal class clsListaProductos
    {
        public List<clsProducto> productos = new List<clsProducto>();

        public void CargarProducto(int codigo, string nombre, string descripcion, decimal precio, int stock, string categoria)
        {
            clsProducto aux = new clsProducto();
            aux.codigo = codigo;
            aux.nombre = nombre;
            aux.descripcion = descripcion;
            aux.precio = precio;
            aux.stock = stock;
            aux.categoria = categoria;
            productos.Add(aux);
        }
        public void CargarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.DataSource = productos;
        }
    }
}
