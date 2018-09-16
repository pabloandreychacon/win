namespace ControlApp.Presentation.Forms.Procesos
{
    partial class NotaDebitoCreditoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaDebitoCreditoForm));
            this.label8 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoAjuste = new BaseControls.Derived.TextBasic();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExistencia = new BaseControls.Derived.TextBasic();
            this.txtDescripcion = new BaseControls.Derived.TextBasic();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCredito = new System.Windows.Forms.RadioButton();
            this.rdoDebito = new System.Windows.Forms.RadioButton();
            this.btnBuscaProducto = new System.Windows.Forms.Button();
            this.txtCodigoProducto = new BaseControls.Derived.TextBasic();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new BaseControls.Derived.TextBasic();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCosto = new BaseControls.Derived.TextBasic();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.okButton1 = new BaseControls.Derived.OkButton();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorContainer1
            // 
            this.errorContainer1.Location = new System.Drawing.Point(-2, 212);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Usuario:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Location = new System.Drawing.Point(625, 30);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(164, 22);
            this.txtVendedor.TabIndex = 39;
            this.txtVendedor.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Monto Ajuste:";
            // 
            // txtMontoAjuste
            // 
            this.txtMontoAjuste.FormatoTexto = null;
            this.txtMontoAjuste.Location = new System.Drawing.Point(12, 178);
            this.txtMontoAjuste.MaxLength = 20;
            this.txtMontoAjuste.Name = "txtMontoAjuste";
            this.txtMontoAjuste.RangoInferior = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMontoAjuste.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtMontoAjuste.Size = new System.Drawing.Size(187, 22);
            this.txtMontoAjuste.TabIndex = 3;
            this.txtMontoAjuste.TipoTexto = BaseControls.Derived.TextBasic.FormatTypes.Numerico;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Existencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Descripcion:";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Enabled = false;
            this.txtExistencia.FormatoTexto = null;
            this.txtExistencia.Location = new System.Drawing.Point(625, 84);
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
            this.txtExistencia.TabIndex = 34;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.FormatoTexto = null;
            this.txtDescripcion.Location = new System.Drawing.Point(299, 85);
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
            this.txtDescripcion.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCredito);
            this.groupBox1.Controls.Add(this.rdoDebito);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajuste";
            // 
            // rdoCredito
            // 
            this.rdoCredito.AutoSize = true;
            this.rdoCredito.Location = new System.Drawing.Point(120, 21);
            this.rdoCredito.Name = "rdoCredito";
            this.rdoCredito.Size = new System.Drawing.Size(74, 21);
            this.rdoCredito.TabIndex = 1;
            this.rdoCredito.Text = "Credito";
            this.rdoCredito.UseVisualStyleBackColor = true;
            // 
            // rdoDebito
            // 
            this.rdoDebito.AutoSize = true;
            this.rdoDebito.Checked = true;
            this.rdoDebito.Location = new System.Drawing.Point(21, 21);
            this.rdoDebito.Name = "rdoDebito";
            this.rdoDebito.Size = new System.Drawing.Size(70, 21);
            this.rdoDebito.TabIndex = 0;
            this.rdoDebito.TabStop = true;
            this.rdoDebito.Text = "Debito";
            this.rdoDebito.UseVisualStyleBackColor = true;
            // 
            // btnBuscaProducto
            // 
            this.btnBuscaProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscaProducto.Location = new System.Drawing.Point(209, 78);
            this.btnBuscaProducto.Name = "btnBuscaProducto";
            this.btnBuscaProducto.Size = new System.Drawing.Size(75, 35);
            this.btnBuscaProducto.TabIndex = 2;
            this.btnBuscaProducto.TabStop = false;
            this.btnBuscaProducto.Text = "F3";
            this.btnBuscaProducto.UseVisualStyleBackColor = true;
            this.btnBuscaProducto.Click += new System.EventHandler(this.btnBuscaProducto_Click);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.FormatoTexto = null;
            this.txtCodigoProducto.Location = new System.Drawing.Point(11, 84);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Precio:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Enabled = false;
            this.txtPrecioUnitario.FormatoTexto = null;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(12, 133);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPrecioUnitario.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(187, 22);
            this.txtPrecioUnitario.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Costo:";
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.FormatoTexto = null;
            this.txtCosto.Location = new System.Drawing.Point(209, 133);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCosto.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(187, 22);
            this.txtCosto.TabIndex = 43;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(11, 212);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(790, 23);
            this.lblMensaje.TabIndex = 47;
            // 
            // okButton1
            // 
            this.okButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton1.Image = ((System.Drawing.Image)(resources.GetObject("okButton1.Image")));
            this.okButton1.Location = new System.Drawing.Point(326, 238);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(68, 40);
            this.okButton1.TabIndex = 4;
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(416, 238);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(68, 40);
            this.closeButton1.TabIndex = 5;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // NotaDebitoCreditoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(807, 283);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMontoAjuste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscaProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "NotaDebitoCreditoForm";
            this.Text = "Nota Debito/Credito Inventario";
            this.Load += new System.EventHandler(this.NotaDebitoCreditoForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotaDebitoCreditoForm_KeyDown);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigoProducto, 0);
            this.Controls.SetChildIndex(this.btnBuscaProducto, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.txtExistencia, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtMontoAjuste, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtVendedor, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.txtPrecioUnitario, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtCosto, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.okButton1, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label4;
        private BaseControls.Derived.TextBasic txtMontoAjuste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private BaseControls.Derived.TextBasic txtExistencia;
        private BaseControls.Derived.TextBasic txtDescripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCredito;
        private System.Windows.Forms.RadioButton rdoDebito;
        private System.Windows.Forms.Button btnBuscaProducto;
        private BaseControls.Derived.TextBasic txtCodigoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private BaseControls.Derived.TextBasic txtPrecioUnitario;
        private System.Windows.Forms.Label label5;
        private BaseControls.Derived.TextBasic txtCosto;
        private System.Windows.Forms.Label lblMensaje;
        private BaseControls.Derived.OkButton okButton1;
        private BaseControls.Derived.CloseButton closeButton1;

    }
}