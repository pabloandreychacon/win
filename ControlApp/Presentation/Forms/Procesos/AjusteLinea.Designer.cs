namespace ControlApp.Presentation.Forms.Procesos
{
    partial class AjusteLinea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjusteLinea));
            this.okButton1 = new BaseControls.Derived.OkButton();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.deleteBtn = new BaseControls.Derived.OkButton();
            this.txtProducto = new BaseControls.Derived.TextBasic();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new BaseControls.Derived.TextBasic();
            this.txtMontoDescuento = new BaseControls.Derived.TextBasic();
            this.txtPorcentajeDescuento = new BaseControls.Derived.TextBasic();
            this.SuspendLayout();
            // 
            // okButton1
            // 
            this.okButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton1.Image = ((System.Drawing.Image)(resources.GetObject("okButton1.Image")));
            this.okButton1.Location = new System.Drawing.Point(226, 140);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(75, 35);
            this.okButton1.TabIndex = 3;
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(388, 140);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 35);
            this.closeButton1.TabIndex = 5;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(307, 140);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 35);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.FormatoTexto = null;
            this.txtProducto.Location = new System.Drawing.Point(42, 68);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtProducto.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(185, 31);
            this.txtProducto.TabIndex = 5;
            this.txtProducto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "% desc.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Monto decuento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.FormatoTexto = null;
            this.txtCantidad.Location = new System.Drawing.Point(233, 68);
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
            this.txtCantidad.Size = new System.Drawing.Size(100, 31);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TipoTexto = BaseControls.Derived.TextBasic.FormatTypes.Numerico;
            // 
            // txtMontoDescuento
            // 
            this.txtMontoDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoDescuento.FormatoTexto = null;
            this.txtMontoDescuento.Location = new System.Drawing.Point(339, 68);
            this.txtMontoDescuento.Name = "txtMontoDescuento";
            this.txtMontoDescuento.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMontoDescuento.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtMontoDescuento.Size = new System.Drawing.Size(200, 31);
            this.txtMontoDescuento.TabIndex = 1;
            this.txtMontoDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoDescuento.TipoTexto = BaseControls.Derived.TextBasic.FormatTypes.Numerico;
            this.txtMontoDescuento.Leave += new System.EventHandler(this.txtMontoDescuento_Leave);
            // 
            // txtPorcentajeDescuento
            // 
            this.txtPorcentajeDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeDescuento.FormatoTexto = null;
            this.txtPorcentajeDescuento.Location = new System.Drawing.Point(545, 68);
            this.txtPorcentajeDescuento.Name = "txtPorcentajeDescuento";
            this.txtPorcentajeDescuento.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPorcentajeDescuento.RangoSuperior = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtPorcentajeDescuento.Size = new System.Drawing.Size(103, 31);
            this.txtPorcentajeDescuento.TabIndex = 2;
            this.txtPorcentajeDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentajeDescuento.TipoTexto = BaseControls.Derived.TextBasic.FormatTypes.Numerico;
            this.txtPorcentajeDescuento.Leave += new System.EventHandler(this.txtPorcentajeDescuento_Leave);
            // 
            // AjusteLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(660, 201);
            this.Controls.Add(this.txtPorcentajeDescuento);
            this.Controls.Add(this.txtMontoDescuento);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.okButton1);
            this.Name = "AjusteLinea";
            this.Text = "AjusteLinea";
            this.Load += new System.EventHandler(this.AjusteLinea_Load);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.okButton1, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.deleteBtn, 0);
            this.Controls.SetChildIndex(this.txtProducto, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.txtMontoDescuento, 0);
            this.Controls.SetChildIndex(this.txtPorcentajeDescuento, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.OkButton okButton1;
        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.OkButton deleteBtn;
        private BaseControls.Derived.TextBasic txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private BaseControls.Derived.TextBasic txtCantidad;
        private BaseControls.Derived.TextBasic txtMontoDescuento;
        private BaseControls.Derived.TextBasic txtPorcentajeDescuento;
    }
}