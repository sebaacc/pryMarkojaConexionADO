﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMarkojaConexionBD
{
    public class clsProducto
    {
        public int codigo {get;set;}
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public string categoria { get; set; }
    }
}
