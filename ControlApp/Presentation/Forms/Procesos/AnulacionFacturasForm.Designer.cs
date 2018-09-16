namespace ControlApp.Presentation.Forms.Procesos
{
    partial class AnulacionFacturasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnulacionFacturasForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBasic1 = new BaseControls.Derived.TextBasic();
            this.textBasic2 = new BaseControls.Derived.TextBasic();
            this.okButton1 = new BaseControls.Derived.OkButton();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.okButton2 = new BaseControls.Derived.OkButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBasic3 = new BaseControls.Derived.TextBasic();
            this.label5 = new System.Windows.Forms.Label();
            this.textBasic5 = new BaseControls.Derived.TextBasic();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtTotalDescuento = new System.Windows.Forms.TextBox();
            this.txtTotalImpuestos = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "#Factura:";
            // 
            // textBasic1
            // 
            this.textBasic1.FormatoTexto = null;
            this.textBasic1.Location = new System.Drawing.Point(241, 33);
            this.textBasic1.Name = "textBasic1";
            this.textBasic1.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBasic1.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.textBasic1.ReadOnly = true;
            this.textBasic1.Size = new System.Drawing.Size(125, 22);
            this.textBasic1.TabIndex = 2;
            this.textBasic1.TabStop = false;
            // 
            // textBasic2
            // 
            this.textBasic2.FormatoTexto = null;
            this.textBasic2.Location = new System.Drawing.Point(24, 33);
            this.textBasic2.Name = "textBasic2";
            this.textBasic2.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBasic2.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.textBasic2.Size = new System.Drawing.Size(159, 22);
            this.textBasic2.TabIndex = 0;
            // 
            // okButton1
            // 
            this.okButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton1.Image = ((System.Drawing.Image)(resources.GetObject("okButton1.Image")));
            this.okButton1.Location = new System.Drawing.Point(338, 396);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(75, 40);
            this.okButton1.TabIndex = 2;
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(419, 396);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 40);
            this.closeButton1.TabIndex = 3;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // okButton2
            // 
            this.okButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton2.Image = ((System.Drawing.Image)(resources.GetObject("okButton2.Image")));
            this.okButton2.Location = new System.Drawing.Point(189, 29);
            this.okButton2.Name = "okButton2";
            this.okButton2.Size = new System.Drawing.Size(46, 31);
            this.okButton2.TabIndex = 1;
            this.okButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 228);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cliente:";
            // 
            // textBasic3
            // 
            this.textBasic3.FormatoTexto = null;
            this.textBasic3.Location = new System.Drawing.Point(381, 33);
            this.textBasic3.Name = "textBasic3";
            this.textBasic3.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBasic3.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.textBasic3.ReadOnly = true;
            this.textBasic3.Size = new System.Drawing.Size(261, 22);
            this.textBasic3.TabIndex = 9;
            this.textBasic3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estado:";
            // 
            // textBasic5
            // 
            this.textBasic5.FormatoTexto = null;
            this.textBasic5.Location = new System.Drawing.Point(657, 33);
            this.textBasic5.Name = "textBasic5";
            this.textBasic5.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBasic5.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.textBasic5.ReadOnly = true;
            this.textBasic5.Size = new System.Drawing.Size(125, 22);
            this.textBasic5.TabIndex = 13;
            this.textBasic5.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 337);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Sub-total:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubTotal.Location = new System.Drawing.Point(137, 361);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(132, 22);
            this.txtSubTotal.TabIndex = 34;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 337);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Descuento:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Impuestos:";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrandTotal.Location = new System.Drawing.Point(561, 361);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(132, 22);
            this.txtGrandTotal.TabIndex = 30;
            this.txtGrandTotal.TabStop = false;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalDescuento
            // 
            this.txtTotalDescuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalDescuento.Location = new System.Drawing.Point(419, 361);
            this.txtTotalDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDescuento.Name = "txtTotalDescuento";
            this.txtTotalDescuento.ReadOnly = true;
            this.txtTotalDescuento.Size = new System.Drawing.Size(132, 22);
            this.txtTotalDescuento.TabIndex = 29;
            this.txtTotalDescuento.TabStop = false;
            this.txtTotalDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalImpuestos
            // 
            this.txtTotalImpuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalImpuestos.Location = new System.Drawing.Point(278, 361);
            this.txtTotalImpuestos.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalImpuestos.Name = "txtTotalImpuestos";
            this.txtTotalImpuestos.ReadOnly = true;
            this.txtTotalImpuestos.Size = new System.Drawing.Size(132, 22);
            this.txtTotalImpuestos.TabIndex = 28;
            this.txtTotalImpuestos.TabStop = false;
            this.txtTotalImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(23, 315);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(758, 23);
            this.lblMensaje.TabIndex = 36;
            // 
            // AnulacionFacturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(805, 448);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.txtTotalDescuento);
            this.Controls.Add(this.txtTotalImpuestos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBasic5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBasic3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.okButton2);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.textBasic2);
            this.Controls.Add(this.textBasic1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "AnulacionFacturasForm";
            this.Text = "Anular Factura";
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBasic1, 0);
            this.Controls.SetChildIndex(this.textBasic2, 0);
            this.Controls.SetChildIndex(this.okButton1, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.okButton2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBasic3, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBasic5, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtTotalImpuestos, 0);
            this.Controls.SetChildIndex(this.txtTotalDescuento, 0);
            this.Controls.SetChildIndex(this.txtGrandTotal, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtSubTotal, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.TextBasic textBasic1;
        private BaseControls.Derived.TextBasic textBasic2;
        private BaseControls.Derived.OkButton okButton1;
        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.OkButton okButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BaseControls.Derived.TextBasic textBasic3;
        private System.Windows.Forms.Label label5;
        private BaseControls.Derived.TextBasic textBasic5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtTotalDescuento;
        private System.Windows.Forms.TextBox txtTotalImpuestos;
        private System.Windows.Forms.Label lblMensaje;
    }
}