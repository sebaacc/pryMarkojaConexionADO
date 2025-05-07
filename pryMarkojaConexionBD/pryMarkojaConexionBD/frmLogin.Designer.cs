namespace pryMarkojaConexionBD
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblLinkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.lblPreguntaR = new System.Windows.Forms.Label();
            this.lblBienvenidaLogin1 = new System.Windows.Forms.Label();
            this.lblBienvenidaLogin2 = new System.Windows.Forms.Label();
            this.pbLogoABM = new System.Windows.Forms.PictureBox();
            this.tlpCentrador = new System.Windows.Forms.TableLayoutPanel();
            this.panElementos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoABM)).BeginInit();
            this.tlpCentrador.SuspendLayout();
            this.panElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(107, 222);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(267, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(107, 308);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(267, 22);
            this.txtContraseña.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(144, 435);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(188, 39);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(107, 196);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(107, 283);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblLinkRegistrarse
            // 
            this.lblLinkRegistrarse.AutoSize = true;
            this.lblLinkRegistrarse.Location = new System.Drawing.Point(297, 366);
            this.lblLinkRegistrarse.Name = "lblLinkRegistrarse";
            this.lblLinkRegistrarse.Size = new System.Drawing.Size(77, 16);
            this.lblLinkRegistrarse.TabIndex = 5;
            this.lblLinkRegistrarse.TabStop = true;
            this.lblLinkRegistrarse.Text = "Registrarse";
            this.lblLinkRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkRegistrarse_LinkClicked);
            // 
            // lblPreguntaR
            // 
            this.lblPreguntaR.AutoSize = true;
            this.lblPreguntaR.Location = new System.Drawing.Point(104, 366);
            this.lblPreguntaR.Name = "lblPreguntaR";
            this.lblPreguntaR.Size = new System.Drawing.Size(169, 16);
            this.lblPreguntaR.TabIndex = 6;
            this.lblPreguntaR.Text = "¿Todavía no tenés cuenta?";
            // 
            // lblBienvenidaLogin1
            // 
            this.lblBienvenidaLogin1.AutoSize = true;
            this.lblBienvenidaLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidaLogin1.Location = new System.Drawing.Point(102, 104);
            this.lblBienvenidaLogin1.Name = "lblBienvenidaLogin1";
            this.lblBienvenidaLogin1.Size = new System.Drawing.Size(272, 25);
            this.lblBienvenidaLogin1.TabIndex = 7;
            this.lblBienvenidaLogin1.Text = "¡Te estábamos esperando!";
            // 
            // lblBienvenidaLogin2
            // 
            this.lblBienvenidaLogin2.AutoSize = true;
            this.lblBienvenidaLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidaLogin2.Location = new System.Drawing.Point(46, 129);
            this.lblBienvenidaLogin2.Name = "lblBienvenidaLogin2";
            this.lblBienvenidaLogin2.Size = new System.Drawing.Size(385, 25);
            this.lblBienvenidaLogin2.TabIndex = 8;
            this.lblBienvenidaLogin2.Text = "Te damos la bienvenida a ABM Master";
            // 
            // pbLogoABM
            // 
            this.pbLogoABM.Image = global::pryMarkojaConexionBD.Properties.Resources.FreePik_abm;
            this.pbLogoABM.Location = new System.Drawing.Point(196, 32);
            this.pbLogoABM.Name = "pbLogoABM";
            this.pbLogoABM.Size = new System.Drawing.Size(85, 69);
            this.pbLogoABM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoABM.TabIndex = 9;
            this.pbLogoABM.TabStop = false;
            // 
            // tlpCentrador
            // 
            this.tlpCentrador.ColumnCount = 1;
            this.tlpCentrador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentrador.Controls.Add(this.panElementos, 0, 0);
            this.tlpCentrador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCentrador.Location = new System.Drawing.Point(0, 0);
            this.tlpCentrador.Name = "tlpCentrador";
            this.tlpCentrador.RowCount = 1;
            this.tlpCentrador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentrador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCentrador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCentrador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCentrador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCentrador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCentrador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCentrador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCentrador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCentrador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCentrador.Size = new System.Drawing.Size(1127, 621);
            this.tlpCentrador.TabIndex = 10;
            // 
            // panElementos
            // 
            this.panElementos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panElementos.Controls.Add(this.pbLogoABM);
            this.panElementos.Controls.Add(this.btnLogin);
            this.panElementos.Controls.Add(this.lblBienvenidaLogin2);
            this.panElementos.Controls.Add(this.txtUsuario);
            this.panElementos.Controls.Add(this.lblBienvenidaLogin1);
            this.panElementos.Controls.Add(this.txtContraseña);
            this.panElementos.Controls.Add(this.lblPreguntaR);
            this.panElementos.Controls.Add(this.lblUsuario);
            this.panElementos.Controls.Add(this.lblLinkRegistrarse);
            this.panElementos.Controls.Add(this.lblContraseña);
            this.panElementos.Location = new System.Drawing.Point(329, 49);
            this.panElementos.Name = "panElementos";
            this.panElementos.Size = new System.Drawing.Size(469, 522);
            this.panElementos.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 621);
            this.Controls.Add(this.tlpCentrador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login de ABM Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoABM)).EndInit();
            this.tlpCentrador.ResumeLayout(false);
            this.panElementos.ResumeLayout(false);
            this.panElementos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.LinkLabel lblLinkRegistrarse;
        private System.Windows.Forms.Label lblPreguntaR;
        private System.Windows.Forms.Label lblBienvenidaLogin1;
        private System.Windows.Forms.Label lblBienvenidaLogin2;
        private System.Windows.Forms.PictureBox pbLogoABM;
        private System.Windows.Forms.TableLayoutPanel tlpCentrador;
        private System.Windows.Forms.Panel panElementos;
    }
}