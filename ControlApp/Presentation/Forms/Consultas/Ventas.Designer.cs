namespace ControlApp.Presentation.Forms.Consultas
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.lstVentas = new System.Windows.Forms.ListView();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.SuspendLayout();
            // 
            // lstVentas
            // 
            this.lstVentas.GridLines = true;
            this.lstVentas.Location = new System.Drawing.Point(0, 88);
            this.lstVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(821, 590);
            this.lstVentas.TabIndex = 1;
            this.lstVentas.UseCompatibleStateImageBehavior = false;
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(676, 26);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 40);
            this.closeButton1.TabIndex = 2;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(823, 679);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.lstVentas);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.lstVentas, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstVentas;
        private BaseControls.Derived.CloseButton closeButton1;
    }
}