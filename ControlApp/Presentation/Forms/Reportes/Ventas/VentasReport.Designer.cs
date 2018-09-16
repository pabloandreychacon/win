namespace ControlApp.Presentation.Forms.Reportes.Ventas
{
    partial class VentasReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasReport));
            this.okButton1 = new BaseControls.Derived.OkButton();
            this.SuspendLayout();
            // 
            // okButton1
            // 
            this.okButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton1.Image = ((System.Drawing.Image)(resources.GetObject("okButton1.Image")));
            this.okButton1.Location = new System.Drawing.Point(278, 308);
            this.okButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(94, 55);
            this.okButton1.TabIndex = 1;
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // VentasReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 472);
            this.Controls.Add(this.okButton1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "VentasReport";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.VentasReport_Load);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.okButton1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.Derived.OkButton okButton1;

    }
}