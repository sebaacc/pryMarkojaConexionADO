namespace pryMarkojaConexionBD
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.gbModificarYEliminar = new System.Windows.Forms.GroupBox();
            this.pbLogoABM = new System.Windows.Forms.PictureBox();
            this.tlpCentrador = new System.Windows.Forms.TableLayoutPanel();
            this.panElementos = new System.Windows.Forms.Panel();
            this.lblInstruccion2 = new System.Windows.Forms.Label();
            this.lblInstruccion3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gbProducto.SuspendLayout();
            this.gbModificarYEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoABM)).BeginInit();
            this.tlpCentrador.SuspendLayout();
            this.panElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(59, 152);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 24);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(217, 165);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 36;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(217, 180);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(128, 20);
            this.txtStock.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(31, 163);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 34;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(217, 93);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 32;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(217, 109);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(128, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 92);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 30;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(30, 109);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(128, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(31, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 28;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(217, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Salmon;
            this.btnEliminar.Location = new System.Drawing.Point(217, 152);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 24);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(470, 84);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(758, 495);
            this.dgvDatos.TabIndex = 24;
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(217, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCargar.Location = new System.Drawing.Point(136, 233);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(99, 24);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(58, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(364, 24);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "¡Te damos la bienvenida ABM Master!";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Salmon;
            this.btnSalir.Location = new System.Drawing.Point(1252, 642);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(71, 24);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(31, 179);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(128, 21);
            this.cmbCategoria.TabIndex = 43;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(31, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(128, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.txtStock);
            this.gbProducto.Controls.Add(this.cmbCategoria);
            this.gbProducto.Controls.Add(this.txtNombre);
            this.gbProducto.Controls.Add(this.lblNombre);
            this.gbProducto.Controls.Add(this.txtCodigo);
            this.gbProducto.Controls.Add(this.lblCodigo);
            this.gbProducto.Controls.Add(this.txtDescripcion);
            this.gbProducto.Controls.Add(this.lblDescripcion);
            this.gbProducto.Controls.Add(this.txtPrecio);
            this.gbProducto.Controls.Add(this.btnCargar);
            this.gbProducto.Controls.Add(this.lblStock);
            this.gbProducto.Controls.Add(this.lblPrecio);
            this.gbProducto.Controls.Add(this.lblCategoria);
            this.gbProducto.Location = new System.Drawing.Point(62, 84);
            this.gbProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbProducto.Size = new System.Drawing.Size(378, 282);
            this.gbProducto.TabIndex = 44;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Cargar Producto";
            // 
            // gbModificarYEliminar
            // 
            this.gbModificarYEliminar.Controls.Add(this.lblInstruccion3);
            this.gbModificarYEliminar.Controls.Add(this.lblInstruccion2);
            this.gbModificarYEliminar.Controls.Add(this.btnModificar);
            this.gbModificarYEliminar.Controls.Add(this.btnEliminar);
            this.gbModificarYEliminar.Location = new System.Drawing.Point(62, 371);
            this.gbModificarYEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbModificarYEliminar.Name = "gbModificarYEliminar";
            this.gbModificarYEliminar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbModificarYEliminar.Size = new System.Drawing.Size(378, 208);
            this.gbModificarYEliminar.TabIndex = 45;
            this.gbModificarYEliminar.TabStop = false;
            this.gbModificarYEliminar.Text = "Cambiar o Eliminar producto";
            // 
            // pbLogoABM
            // 
            this.pbLogoABM.Image = global::pryMarkojaConexionBD.Properties.Resources.FreePik_abm;
            this.pbLogoABM.Location = new System.Drawing.Point(1259, 13);
            this.pbLogoABM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogoABM.Name = "pbLogoABM";
            this.pbLogoABM.Size = new System.Drawing.Size(64, 56);
            this.pbLogoABM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoABM.TabIndex = 46;
            this.pbLogoABM.TabStop = false;
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
            this.tlpCentrador.Size = new System.Drawing.Size(1370, 683);
            this.tlpCentrador.TabIndex = 47;
            // 
            // panElementos
            // 
            this.panElementos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panElementos.Controls.Add(this.lblTitulo);
            this.panElementos.Controls.Add(this.pbLogoABM);
            this.panElementos.Controls.Add(this.dgvDatos);
            this.panElementos.Controls.Add(this.gbModificarYEliminar);
            this.panElementos.Controls.Add(this.btnSalir);
            this.panElementos.Controls.Add(this.gbProducto);
            this.panElementos.Location = new System.Drawing.Point(14, 2);
            this.panElementos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panElementos.Name = "panElementos";
            this.panElementos.Size = new System.Drawing.Size(1342, 679);
            this.panElementos.TabIndex = 48;
            // 
            // lblInstruccion2
            // 
            this.lblInstruccion2.AutoSize = true;
            this.lblInstruccion2.Location = new System.Drawing.Point(27, 46);
            this.lblInstruccion2.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblInstruccion2.Name = "lblInstruccion2";
            this.lblInstruccion2.Size = new System.Drawing.Size(339, 26);
            this.lblInstruccion2.TabIndex = 12;
            this.lblInstruccion2.Text = "Para Borrar: Ingrese el código del producto arriba, y luego presione en \"Eliminar" +
    "\".";
            // 
            // lblInstruccion3
            // 
            this.lblInstruccion3.AutoSize = true;
            this.lblInstruccion3.Location = new System.Drawing.Point(27, 98);
            this.lblInstruccion3.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblInstruccion3.Name = "lblInstruccion3";
            this.lblInstruccion3.Size = new System.Drawing.Size(330, 26);
            this.lblInstruccion3.TabIndex = 13;
            this.lblInstruccion3.Text = "Para Modificar: Seleccione producto de la grilla. No debe cambiar el código sino " +
    "no se modificará. Luego presione en \"Modificar\".";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 683);
            this.Controls.Add(this.tlpCentrador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "ABM Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.gbModificarYEliminar.ResumeLayout(false);
            this.gbModificarYEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoABM)).EndInit();
            this.tlpCentrador.ResumeLayout(false);
            this.panElementos.ResumeLayout(false);
            this.panElementos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.GroupBox gbModificarYEliminar;
        private System.Windows.Forms.PictureBox pbLogoABM;
        private System.Windows.Forms.TableLayoutPanel tlpCentrador;
        private System.Windows.Forms.Panel panElementos;
        private System.Windows.Forms.Label lblInstruccion2;
        private System.Windows.Forms.Label lblInstruccion3;
    }
}

