namespace ControlApp.Presentation.Forms.Mantenimientos.Ventas
{
    partial class ParametrosVentas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label consecutivoGlobalFacturasLabel;
            System.Windows.Forms.Label idParametroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametrosVentas));
            this.parametrosVentaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.parametrosVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.parametrosVentaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.consecutivoGlobalFacturasTextBox = new System.Windows.Forms.TextBox();
            this.idParametroTextBox = new System.Windows.Forms.TextBox();
            consecutivoGlobalFacturasLabel = new System.Windows.Forms.Label();
            idParametroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosVentaBindingNavigator)).BeginInit();
            this.parametrosVentaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.TabIndex = 3;
            // 
            // consecutivoGlobalFacturasLabel
            // 
            consecutivoGlobalFacturasLabel.AutoSize = true;
            consecutivoGlobalFacturasLabel.Location = new System.Drawing.Point(99, 96);
            consecutivoGlobalFacturasLabel.Name = "consecutivoGlobalFacturasLabel";
            consecutivoGlobalFacturasLabel.Size = new System.Drawing.Size(146, 13);
            consecutivoGlobalFacturasLabel.TabIndex = 4;
            consecutivoGlobalFacturasLabel.Text = "Consecutivo Global Facturas:";
            // 
            // idParametroLabel
            // 
            idParametroLabel.AutoSize = true;
            idParametroLabel.Location = new System.Drawing.Point(279, 31);
            idParametroLabel.Name = "idParametroLabel";
            idParametroLabel.Size = new System.Drawing.Size(70, 13);
            idParametroLabel.TabIndex = 6;
            idParametroLabel.Text = "Id Parametro:";
            idParametroLabel.Visible = false;
            // 
            // parametrosVentaBindingNavigator
            // 
            this.parametrosVentaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.parametrosVentaBindingNavigator.BindingSource = this.parametrosVentaBindingSource;
            this.parametrosVentaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.parametrosVentaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.parametrosVentaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.parametrosVentaBindingNavigatorSaveItem});
            this.parametrosVentaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.parametrosVentaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.parametrosVentaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.parametrosVentaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.parametrosVentaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.parametrosVentaBindingNavigator.Name = "parametrosVentaBindingNavigator";
            this.parametrosVentaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.parametrosVentaBindingNavigator.Size = new System.Drawing.Size(563, 25);
            this.parametrosVentaBindingNavigator.TabIndex = 1;
            this.parametrosVentaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // parametrosVentaBindingSource
            // 
            this.parametrosVentaBindingSource.DataSource = typeof(ControlEntity.ParametrosVenta);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // parametrosVentaBindingNavigatorSaveItem
            // 
            this.parametrosVentaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.parametrosVentaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("parametrosVentaBindingNavigatorSaveItem.Image")));
            this.parametrosVentaBindingNavigatorSaveItem.Name = "parametrosVentaBindingNavigatorSaveItem";
            this.parametrosVentaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.parametrosVentaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.parametrosVentaBindingNavigatorSaveItem.Click += new System.EventHandler(this.parametrosVentaBindingNavigatorSaveItem_Click);
            // 
            // consecutivoGlobalFacturasTextBox
            // 
            this.consecutivoGlobalFacturasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosVentaBindingSource, "ConsecutivoGlobalFacturas", true));
            this.consecutivoGlobalFacturasTextBox.Location = new System.Drawing.Point(251, 93);
            this.consecutivoGlobalFacturasTextBox.Name = "consecutivoGlobalFacturasTextBox";
            this.consecutivoGlobalFacturasTextBox.Size = new System.Drawing.Size(100, 20);
            this.consecutivoGlobalFacturasTextBox.TabIndex = 0;
            // 
            // idParametroTextBox
            // 
            this.idParametroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosVentaBindingSource, "IdParametro", true));
            this.idParametroTextBox.Enabled = false;
            this.idParametroTextBox.Location = new System.Drawing.Point(431, 28);
            this.idParametroTextBox.Name = "idParametroTextBox";
            this.idParametroTextBox.ReadOnly = true;
            this.idParametroTextBox.Size = new System.Drawing.Size(100, 20);
            this.idParametroTextBox.TabIndex = 7;
            this.idParametroTextBox.Visible = false;
            // 
            // ParametrosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 159);
            this.Controls.Add(consecutivoGlobalFacturasLabel);
            this.Controls.Add(this.consecutivoGlobalFacturasTextBox);
            this.Controls.Add(idParametroLabel);
            this.Controls.Add(this.idParametroTextBox);
            this.Controls.Add(this.parametrosVentaBindingNavigator);
            this.Name = "ParametrosVentas";
            this.Text = "ParametrosVentas";
            this.Load += new System.EventHandler(this.ParametrosVentas_Load);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.parametrosVentaBindingNavigator, 0);
            this.Controls.SetChildIndex(this.idParametroTextBox, 0);
            this.Controls.SetChildIndex(idParametroLabel, 0);
            this.Controls.SetChildIndex(this.consecutivoGlobalFacturasTextBox, 0);
            this.Controls.SetChildIndex(consecutivoGlobalFacturasLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.parametrosVentaBindingNavigator)).EndInit();
            this.parametrosVentaBindingNavigator.ResumeLayout(false);
            this.parametrosVentaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosVentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource parametrosVentaBindingSource;
        private System.Windows.Forms.BindingNavigator parametrosVentaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton parametrosVentaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox consecutivoGlobalFacturasTextBox;
        private System.Windows.Forms.TextBox idParametroTextBox;
    }
}