using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMarkojaConexionBD
{
    public class clsListaProductos
    {
        public BindingList<clsProducto> productos = new BindingList<clsProducto>();
        private List<clsProducto> productosAgregados = new List<clsProducto>();//productos nuevos que debeerán agregarse a la BD
        private List<clsProducto> productosModificados = new List<clsProducto>(); // productos que fueron modificados
        private List<int> codigosEliminados = new List<int>(); //productos que fueron eliminados
        //todos estos cambios impactan en la bd una vez se ejecute guardarDatos()
        public void CargarProducto(int codigo, string nombre, string descripcion, decimal precio, int stock, string categoria)
        {
            clsProducto nuevo = new clsProducto(codigo, nombre, descripcion, precio, stock, categoria);
            productos.Add(nuevo);
            productosAgregados.Add(nuevo);
        }
        public void ModificarProducto(clsProducto productoModificado)
        {
            int index = productos.ToList().FindIndex(p => p.codigo == productoModificado.codigo);
            if (index != -1)
            {
                productos[index] = productoModificado;

                if (!productosAgregados.Exists(p => p.codigo == productoModificado.codigo)
                    && !productosModificados.Exists(p => p.codigo == productoModificado.codigo))
                {
                    productosModificados.Add(productoModificado);
                }
            }
        }

        public void EliminarProducto(int codigo)
        {
            clsProducto prod = productos.FirstOrDefault(p => p.codigo == codigo);
            if (prod != null)
                productos.Remove(prod);

            if (productosAgregados.Any(p => p.codigo == codigo))
            {
                productosAgregados.RemoveAll(p => p.codigo == codigo);
            }
            else
            {
                codigosEliminados.Add(codigo);
            }
        }

        public void GuardarDatos()
        {
            clsBDConexion conexion = new clsBDConexion();

            foreach (var producto in productosAgregados)
                conexion.AgregarProducto(producto);

            foreach (var producto in productosModificados)
                conexion.ActualizarProducto(producto);

            foreach (var codigo in codigosEliminados)
                conexion.EliminarProducto(codigo);

            productosAgregados.Clear();
            productosModificados.Clear();
            codigosEliminados.Clear();

            MessageBox.Show("✅ Cambios guardados correctamente en la base de datos.");
        }

        public clsProducto BuscarProducto(int codigo)
        {
            return productos.FirstOrDefault(p => p.codigo == codigo);
        }

        public void CargarGrilla(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = productos;
        }
    }
}
