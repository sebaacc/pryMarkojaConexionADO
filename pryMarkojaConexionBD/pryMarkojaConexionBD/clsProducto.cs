﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMarkojaConexionBD
{
    internal class clsProducto
    {
        public int codigo {get;set;}
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        public string Categoria { get; set; }

    }
}
