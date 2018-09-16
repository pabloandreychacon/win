namespace ControlApp.Presentation.Forms.Procesos
{
    partial class AjusteInventarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjusteInventarioForm));
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.gridDetalle = new System.Windows.Forms.DataGridView();
            this.okButton1 = new BaseControls.Derived.OkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new BaseControls.Derived.TextBasic();
            this.btnBuscaProducto = new System.Windows.Forms.Button();
            this.rdoEntrada = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSalida = new System.Windows.Forms.RadioButton();
            this.txtDescripcion = new BaseControls.Derived.TextBasic();
            this.txtExistencia = new BaseControls.Derived.TextBasic();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new BaseControls.Derived.TextBasic();
            this.txtPrecio = new BaseControls.Derived.TextBasic();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(474, 534);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 40);
            this.closeButton1.TabIndex = 7;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // gridDetalle
            // 
            this.gridDetalle.AllowUserToAddRows = false;
            this.gridDetalle.AllowUserToDeleteRows = false;
            this.gridDetalle.AllowUserToOrderColumns = true;
            this.gridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalle.Enabled = false;
            this.gridDetalle.Location = new System.Drawing.Point(12, 165);
            this.gridDetalle.MultiSelect = false;
            this.gridDetalle.Name = "gridDetalle";
            this.gridDetalle.ReadOnly = true;
            this.gridDetalle.RowTemplate.Height = 24;
            this.gridDetalle.Size = new System.Drawing.Size(930, 340);
            this.gridDetalle.TabIndex = 5;
            // 
            // okButton1
            // 
            this.okButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton1.Image = ((System.Drawing.Image)(resources.GetObject("okButton1.Image")));
            this.okButton1.Location = new System.Drawing.Point(384, 534);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(75, 40);
            this.okButton1.TabIndex = 6;
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Producto:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.FormatoTexto = null;
            this.txtCodigoProducto.Location = new System.Drawing.Point(12, 87);
            this.txtCodigoProducto.MaxLength = 50;
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCodigoProducto.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtCodigoProducto.Size = new System.Drawing.Size(188, 22);
            this.txtCodigoProducto.TabIndex = 1;
            this.txtCodigoProducto.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoProducto_Validating);
            this.txtCodigoProducto.Validated += new System.EventHandler(this.txtCodigoProducto_Validated);
            // 
            // btnBuscaProducto
            // 
            this.btnBuscaProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscaProducto.Location = new System.Drawing.Point(210, 81);
            this.btnBuscaProducto.Name = "btnBuscaProducto";
            this.btnBuscaProducto.Size = new System.Drawing.Size(75, 35);
            this.btnBuscaProducto.TabIndex = 8;
            this.btnBuscaProducto.TabStop = false;
            this.btnBuscaProducto.Text = "F3";
            this.btnBuscaProducto.UseVisualStyleBackColor = true;
            this.btnBuscaProducto.Click += new System.EventHandler(this.btnBuscaProducto_Click);
            // 
            // rdoEntrada
            // 
            this.rdoEntrada.AutoSize = true;
            this.rdoEntrada.Checked = true;
            this.rdoEntrada.Location = new System.Drawing.Point(21, 21);
            this.rdoEntrada.Name = "rdoEntrada";
            this.rdoEntrada.Size = new System.Drawing.Size(79, 21);
            this.rdoEntrada.TabIndex = 0;
            this.rdoEntrada.TabStop = true;
            this.rdoEntrada.Text = "Entrada";
            this.rdoEntrada.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSalida);
            this.groupBox1.Controls.Add(this.rdoEntrada);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajuste";
            // 
            // rdoSalida
            // 
            this.rdoSalida.AutoSize = true;
            this.rdoSalida.Location = new System.Drawing.Point(120, 21);
            this.rdoSalida.Name = "rdoSalida";
            this.rdoSalida.Size = new System.Drawing.Size(68, 21);
            this.rdoSalida.TabIndex = 1;
            this.rdoSalida.Text = "Salida";
            this.rdoSalida.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.FormatoTexto = null;
            this.txtDescripcion.Location = new System.Drawing.Point(300, 88);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDescripcion.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(294, 22);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Enabled = false;
            this.txtExistencia.FormatoTexto = null;
            this.txtExistencia.Location = new System.Drawing.Point(626, 87);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtExistencia.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtExistencia.ReadOnly = true;
            this.txtExistencia.Size = new System.Drawing.Size(164, 22);
            this.txtExistencia.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Existencia:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.FormatoTexto = null;
            this.txtCantidad.Location = new System.Drawing.Point(12, 131);
            this.txtCantidad.MaxLength = 20;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCantidad.RangoSuperior = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TipoTexto = BaseControls.Derived.TextBasic.FormatTypes.Entero;
            this.txtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantidad_Validating);
            this.txtCantidad.Validated += new System.EventHandler(this.txtCodigoProducto_Validated);
            // 
            // txtPrecio
            // 
            this.txtPrecio.FormatoTexto = null;
            this.txtPrecio.Location = new System.Drawing.Point(296, 132);
            this.txtPrecio.MaxLength = 20;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.RangoInferior = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrecio.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtPrecio.Size = new System.Drawing.Size(134, 22);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TipoTexto = BaseControls.Derived.TextBasic.FormatTypes.Numerico;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(638, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Usuario:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Location = new System.Drawing.Point(642, 33);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(132, 22);
            this.txtVendedor.TabIndex = 24;
            this.txtVendedor.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(12, 508);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(930, 23);
            this.lblMensaje.TabIndex = 29;
            // 
            // txtAgregar
            // 
            this.txtAgregar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.txtAgregar.Location = new System.Drawing.Point(451, 126);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(75, 35);
            this.txtAgregar.TabIndex = 4;
            this.txtAgregar.Text = "&Agregar";
            this.txtAgregar.UseVisualStyleBackColor = true;
            this.txtAgregar.Click += new System.EventHandler(this.txtAgregar_Click);
            // 
            // AjusteInventarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(954, 578);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscaProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.gridDetalle);
            this.Controls.Add(this.closeButton1);
            this.KeyPreview = true;
            this.Name = "AjusteInventarioForm";
            this.Text = "Ajuste Inventario";
            this.Load += new System.EventHandler(this.AjusteInventarioForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AjusteInventarioForm_KeyDown);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.gridDetalle, 0);
            this.Controls.SetChildIndex(this.okButton1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigoProducto, 0);
            this.Controls.SetChildIndex(this.btnBuscaProducto, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.txtExistencia, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtVendedor, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            this.Controls.SetChildIndex(this.txtAgregar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.CloseButton closeButton1;
        private System.Windows.Forms.DataGridView gridDetalle;
        private BaseControls.Derived.OkButton okButton1;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.TextBasic txtCodigoProducto;
        private System.Windows.Forms.Button btnBuscaProducto;
        private System.Windows.Forms.RadioButton rdoEntrada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSalida;
        private BaseControls.Derived.TextBasic txtDescripcion;
        private BaseControls.Derived.TextBasic txtExistencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BaseControls.Derived.TextBasic txtCantidad;
        private BaseControls.Derived.TextBasic txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button txtAgregar;
    }
}