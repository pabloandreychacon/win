namespace ControlApp.Presentation.Forms.Consultas
{
    partial class ExistenciasConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExistenciasConsulta));
            this.gridExistencias = new System.Windows.Forms.DataGridView();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridExistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // gridExistencias
            // 
            this.gridExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExistencias.Location = new System.Drawing.Point(0, 94);
            this.gridExistencias.Margin = new System.Windows.Forms.Padding(4);
            this.gridExistencias.Name = "gridExistencias";
            this.gridExistencias.Size = new System.Drawing.Size(724, 417);
            this.gridExistencias.TabIndex = 2;
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(588, 36);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 40);
            this.closeButton1.TabIndex = 3;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // ExistenciasConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(724, 513);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.gridExistencias);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ExistenciasConsulta";
            this.Text = "ExistenciasForm";
            this.Load += new System.EventHandler(this.ExistenciasForm_Load);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.gridExistencias, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridExistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridExistencias;
        private BaseControls.Derived.CloseButton closeButton1;
    }
}