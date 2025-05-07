using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace pryMarkojaConexionBD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private int intentos = 3;
        private const string cadenaConexion = "Server=localhost;Database=Tienda;Trusted_Connection=True;";

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            if (ValidarCredenciales(usuario, contraseña))
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                intentos--;
                if (intentos > 0)
                {
                    MessageBox.Show($"Credenciales incorrectas. Te quedan {intentos} intento(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Demasiados intentos fallidos. La aplicación se cerrará.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private bool ValidarCredenciales(string usuario, string contraseña)
        {
            string hash = ObtenerSHA256(contraseña);

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @usuario AND ContraseñaHash = @hash";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@hash", hash);

                        int resultado = (int)comando.ExecuteScalar();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el usuario: " + ex.Message);
                return false;
            }
        }
        private string ObtenerSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                    builder.Append(b.ToString("x2")); // convierte a hexadecimal

                return builder.ToString();
            }
        }

        private void lblLinkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistroUsuario registro = new frmRegistroUsuario();
            registro.ShowDialog();
        }
    }
}
