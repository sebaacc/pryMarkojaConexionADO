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

        public clsProducto(int cod, string nom, string desc, decimal prec, int stk, string cat)
        {
            this.codigo = cod;
            this.nombre = nom;
            this.descripcion = desc;
            this.precio = prec;
            this.stock = stk;
            this.categoria = cat;
        }
    }
}
