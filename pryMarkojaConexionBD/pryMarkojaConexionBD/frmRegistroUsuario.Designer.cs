namespace pryMarkojaConexionBD
{
    partial class frmRegistroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroUsuario));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblRegistroInvitacion = new System.Windows.Forms.Label();
            this.tlpCentrador = new System.Windows.Forms.TableLayoutPanel();
            this.panElementos = new System.Windows.Forms.Panel();
            this.tlpCentrador.SuspendLayout();
            this.panElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(95, 94);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(95, 116);
            this.txtNuevoUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(216, 20);
            this.txtNuevoUsuario.TabIndex = 1;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(95, 191);
            this.txtNuevaContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PasswordChar = '*';
            this.txtNuevaContraseña.Size = new System.Drawing.Size(216, 20);
            this.txtNuevaContraseña.TabIndex = 3;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(95, 168);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(132, 239);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(141, 32);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrarme";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblRegistroInvitacion
            // 
            this.lblRegistroInvitacion.AutoSize = true;
            this.lblRegistroInvitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroInvitacion.Location = new System.Drawing.Point(41, 29);
            this.lblRegistroInvitacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistroInvitacion.Name = "lblRegistroInvitacion";
            this.lblRegistroInvitacion.Size = new System.Drawing.Size(372, 20);
            this.lblRegistroInvitacion.TabIndex = 5;
            this.lblRegistroInvitacion.Text = "Registrate para poder acceder a ABM Master";
            // 
            // tlpCentrador
            // 
            this.tlpCentrador.ColumnCount = 1;
            this.tlpCentrador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentrador.Controls.Add(this.panElementos, 0, 0);
            this.tlpCentrador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCentrador.Location = new System.Drawing.Point(0, 0);
            this.tlpCentrador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpCentrador.Name = "tlpCentrador";
            this.tlpCentrador.RowCount = 1;
            this.tlpCentrador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentrador.Size = new System.Drawing.Size(656, 366);
            this.tlpCentrador.TabIndex = 6;
            // 
            // panElementos
            // 
            this.panElementos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panElementos.Controls.Add(this.lblRegistroInvitacion);
            this.panElementos.Controls.Add(this.btnRegistrar);
            this.panElementos.Controls.Add(this.lblUsuario);
            this.panElementos.Controls.Add(this.txtNuevaContraseña);
            this.panElementos.Controls.Add(this.txtNuevoUsuario);
            this.panElementos.Controls.Add(this.lblContraseña);
            this.panElementos.Location = new System.Drawing.Point(122, 39);
            this.panElementos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panElementos.Name = "panElementos";
            this.panElementos.Size = new System.Drawing.Size(412, 288);
            this.panElementos.TabIndex = 8;
            // 
            // frmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 366);
            this.Controls.Add(this.tlpCentrador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistroUsuario";
            this.Load += new System.EventHandler(this.frmRegistroUsuario_Load);
            this.tlpCentrador.ResumeLayout(false);
            this.panElementos.ResumeLayout(false);
            this.panElementos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblRegistroInvitacion;
        private System.Windows.Forms.TableLayoutPanel tlpCentrador;
        private System.Windows.Forms.Panel panElementos;
    }
}