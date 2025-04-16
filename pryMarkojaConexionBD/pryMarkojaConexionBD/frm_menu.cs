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
        private void frm_menu_Load(object sender, EventArgs e)
        {
            try
            {
                cls_bd_conexion.probar_conexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            cls_bd_conexion.buscar_producto();
        }
    }
}
