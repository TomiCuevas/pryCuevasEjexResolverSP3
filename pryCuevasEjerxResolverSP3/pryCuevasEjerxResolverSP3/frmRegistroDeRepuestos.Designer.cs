namespace pryCuevasEjerxResolverSP3
{
    partial class frmRegistroDeRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroDeRepuestos));
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNroRepuesto = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNroRepuesto = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.Consulta = new System.Windows.Forms.ListBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.cmbMarcaConsulta = new System.Windows.Forms.ComboBox();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.grpRegistro.SuspendLayout();
            this.grpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistro
            // 
            this.grpRegistro.BackColor = System.Drawing.Color.Transparent;
            this.grpRegistro.Controls.Add(this.btnCancelar);
            this.grpRegistro.Controls.Add(this.btnRegistrar);
            this.grpRegistro.Controls.Add(this.cmbOrigen);
            this.grpRegistro.Controls.Add(this.lblPrecio);
            this.grpRegistro.Controls.Add(this.lblDescripcion);
            this.grpRegistro.Controls.Add(this.lblNroRepuesto);
            this.grpRegistro.Controls.Add(this.lblOrigen);
            this.grpRegistro.Controls.Add(this.lblMarca);
            this.grpRegistro.Controls.Add(this.txtPrecio);
            this.grpRegistro.Controls.Add(this.txtDescripcion);
            this.grpRegistro.Controls.Add(this.txtNroRepuesto);
            this.grpRegistro.Controls.Add(this.cmbMarca);
            this.grpRegistro.ForeColor = System.Drawing.SystemColors.Control;
            this.grpRegistro.Location = new System.Drawing.Point(76, 32);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(666, 239);
            this.grpRegistro.TabIndex = 15;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "REGISTRO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(487, 189);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 31);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.Location = new System.Drawing.Point(362, 190);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.Enabled = false;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Items.AddRange(new object[] {
            "Nacional",
            "Importado"});
            this.cmbOrigen.Location = new System.Drawing.Point(159, 88);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(100, 24);
            this.cmbOrigen.TabIndex = 11;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Location = new System.Drawing.Point(325, 121);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescripcion.Location = new System.Drawing.Point(325, 66);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNroRepuesto
            // 
            this.lblNroRepuesto.AutoSize = true;
            this.lblNroRepuesto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNroRepuesto.Location = new System.Drawing.Point(34, 153);
            this.lblNroRepuesto.Name = "lblNroRepuesto";
            this.lblNroRepuesto.Size = new System.Drawing.Size(83, 16);
            this.lblNroRepuesto.TabIndex = 8;
            this.lblNroRepuesto.Text = "N° Repuesto";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrigen.Location = new System.Drawing.Point(33, 88);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(47, 16);
            this.lblOrigen.TabIndex = 7;
            this.lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarca.Location = new System.Drawing.Point(33, 28);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 16);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(434, 118);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(434, 64);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtNroRepuesto
            // 
            this.txtNroRepuesto.Enabled = false;
            this.txtNroRepuesto.Location = new System.Drawing.Point(159, 147);
            this.txtNroRepuesto.MaxLength = 6;
            this.txtNroRepuesto.Name = "txtNroRepuesto";
            this.txtNroRepuesto.Size = new System.Drawing.Size(100, 22);
            this.txtNroRepuesto.TabIndex = 3;
            this.txtNroRepuesto.TextChanged += new System.EventHandler(this.txtNroRepuesto_TextChanged);
            this.txtNroRepuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroRepuesto_KeyPress);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.cmbMarca.Location = new System.Drawing.Point(159, 38);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(100, 24);
            this.cmbMarca.TabIndex = 0;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // grpConsulta
            // 
            this.grpConsulta.BackColor = System.Drawing.Color.Transparent;
            this.grpConsulta.Controls.Add(this.Consulta);
            this.grpConsulta.Controls.Add(this.btnConsultar);
            this.grpConsulta.Controls.Add(this.optImportado);
            this.grpConsulta.Controls.Add(this.cmbMarcaConsulta);
            this.grpConsulta.Controls.Add(this.optNacional);
            this.grpConsulta.Controls.Add(this.lblMarca2);
            this.grpConsulta.ForeColor = System.Drawing.SystemColors.Control;
            this.grpConsulta.Location = new System.Drawing.Point(76, 304);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(666, 310);
            this.grpConsulta.TabIndex = 27;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "CONSULTA";
            // 
            // Consulta
            // 
            this.Consulta.Enabled = false;
            this.Consulta.FormattingEnabled = true;
            this.Consulta.ItemHeight = 16;
            this.Consulta.Location = new System.Drawing.Point(215, 34);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(426, 196);
            this.Consulta.TabIndex = 21;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Enabled = false;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultar.Location = new System.Drawing.Point(399, 245);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(82, 35);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.ForeColor = System.Drawing.SystemColors.Control;
            this.optImportado.Location = new System.Drawing.Point(55, 156);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(89, 20);
            this.optImportado.TabIndex = 23;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // cmbMarcaConsulta
            // 
            this.cmbMarcaConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaConsulta.FormattingEnabled = true;
            this.cmbMarcaConsulta.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.cmbMarcaConsulta.Location = new System.Drawing.Point(55, 91);
            this.cmbMarcaConsulta.Name = "cmbMarcaConsulta";
            this.cmbMarcaConsulta.Size = new System.Drawing.Size(121, 24);
            this.cmbMarcaConsulta.TabIndex = 24;
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.ForeColor = System.Drawing.SystemColors.Control;
            this.optNacional.Location = new System.Drawing.Point(55, 128);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(82, 20);
            this.optNacional.TabIndex = 22;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarca2.Location = new System.Drawing.Point(52, 60);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(45, 16);
            this.lblMarca2.TabIndex = 25;
            this.lblMarca2.Text = "Marca";
            // 
            // frmRegistroDeRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryCuevasEjerxResolverSP3.Properties.Resources.imagen_sp3;
            this.ClientSize = new System.Drawing.Size(814, 644);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroDeRepuestos";
            this.Text = "REGISTRO Y CONSULTA";
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNroRepuesto;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNroRepuesto;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.ListBox Consulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.ComboBox cmbMarcaConsulta;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.Label lblMarca2;
    }
}

