using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMarkojaConexionBD
{
    internal class clsListaProductos
    {
        public List<clsProducto> productos = new List<clsProducto>();

        public void cargarProducto(int codigo, string nombre, string descripcion, decimal precio, int stock, string categoria)
        {
            clsProducto aux = new clsProducto();
            aux.codigo = codigo;
            aux.nombre = nombre;
            aux.descripcion = descripcion;
            aux.precio = precio;
            aux.stock = stock;
            aux.categoria = categoria;
        }

    }
}
