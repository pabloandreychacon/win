namespace ControlApp.Presentation.Forms.Mantenimientos.Inventario
{
    partial class UnidadesMedidaForm
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idUnidadMedidaLabel;
            System.Windows.Forms.Label nombreCortoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnidadesMedidaForm));
            this.unidadesMedidaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.unidadesMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.unidadesMedidaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idUnidadMedidaTextBox = new System.Windows.Forms.TextBox();
            this.nombreCortoTextBox = new System.Windows.Forms.TextBox();
            descripcionLabel = new System.Windows.Forms.Label();
            idUnidadMedidaLabel = new System.Windows.Forms.Label();
            nombreCortoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesMedidaBindingNavigator)).BeginInit();
            this.unidadesMedidaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesMedidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.TabIndex = 4;
            // 
            // btnFind
            // 
            this.btnFind.TabIndex = 3;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(59, 92);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripcion:";
            // 
            // idUnidadMedidaLabel
            // 
            idUnidadMedidaLabel.AutoSize = true;
            idUnidadMedidaLabel.Location = new System.Drawing.Point(59, 66);
            idUnidadMedidaLabel.Name = "idUnidadMedidaLabel";
            idUnidadMedidaLabel.Size = new System.Drawing.Size(94, 13);
            idUnidadMedidaLabel.TabIndex = 4;
            idUnidadMedidaLabel.Text = "Id Unidad Medida:";
            // 
            // nombreCortoLabel
            // 
            nombreCortoLabel.AutoSize = true;
            nombreCortoLabel.Location = new System.Drawing.Point(59, 118);
            nombreCortoLabel.Name = "nombreCortoLabel";
            nombreCortoLabel.Size = new System.Drawing.Size(75, 13);
            nombreCortoLabel.TabIndex = 6;
            nombreCortoLabel.Text = "Nombre Corto:";
            // 
            // unidadesMedidaBindingNavigator
            // 
            this.unidadesMedidaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.unidadesMedidaBindingNavigator.BindingSource = this.unidadesMedidaBindingSource;
            this.unidadesMedidaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.unidadesMedidaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.unidadesMedidaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.unidadesMedidaBindingNavigatorSaveItem});
            this.unidadesMedidaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.unidadesMedidaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.unidadesMedidaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.unidadesMedidaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.unidadesMedidaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.unidadesMedidaBindingNavigator.Name = "unidadesMedidaBindingNavigator";
            this.unidadesMedidaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.unidadesMedidaBindingNavigator.Size = new System.Drawing.Size(558, 25);
            this.unidadesMedidaBindingNavigator.TabIndex = 2;
            this.unidadesMedidaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // unidadesMedidaBindingSource
            // 
            this.unidadesMedidaBindingSource.DataSource = typeof(ControlEntity.UnidadesMedida);
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
            // unidadesMedidaBindingNavigatorSaveItem
            // 
            this.unidadesMedidaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unidadesMedidaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("unidadesMedidaBindingNavigatorSaveItem.Image")));
            this.unidadesMedidaBindingNavigatorSaveItem.Name = "unidadesMedidaBindingNavigatorSaveItem";
            this.unidadesMedidaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.unidadesMedidaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.unidadesMedidaBindingNavigatorSaveItem.Click += new System.EventHandler(this.unidadesMedidaBindingNavigatorSaveItem_Click);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadesMedidaBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(159, 89);
            this.descripcionTextBox.MaxLength = 50;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(170, 20);
            this.descripcionTextBox.TabIndex = 0;
            // 
            // idUnidadMedidaTextBox
            // 
            this.idUnidadMedidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadesMedidaBindingSource, "IdUnidadMedida", true));
            this.idUnidadMedidaTextBox.Enabled = false;
            this.idUnidadMedidaTextBox.Location = new System.Drawing.Point(159, 63);
            this.idUnidadMedidaTextBox.Name = "idUnidadMedidaTextBox";
            this.idUnidadMedidaTextBox.ReadOnly = true;
            this.idUnidadMedidaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idUnidadMedidaTextBox.TabIndex = 5;
            // 
            // nombreCortoTextBox
            // 
            this.nombreCortoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadesMedidaBindingSource, "NombreCorto", true));
            this.nombreCortoTextBox.Location = new System.Drawing.Point(159, 115);
            this.nombreCortoTextBox.MaxLength = 50;
            this.nombreCortoTextBox.Name = "nombreCortoTextBox";
            this.nombreCortoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreCortoTextBox.TabIndex = 1;
            // 
            // UnidadesMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 171);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(idUnidadMedidaLabel);
            this.Controls.Add(this.idUnidadMedidaTextBox);
            this.Controls.Add(nombreCortoLabel);
            this.Controls.Add(this.nombreCortoTextBox);
            this.Controls.Add(this.unidadesMedidaBindingNavigator);
            this.Name = "UnidadesMedida";
            this.Text = "UnidadesMedida";
            this.Load += new System.EventHandler(this.UnidadesMedida_Load);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.unidadesMedidaBindingNavigator, 0);
            this.Controls.SetChildIndex(this.nombreCortoTextBox, 0);
            this.Controls.SetChildIndex(nombreCortoLabel, 0);
            this.Controls.SetChildIndex(this.idUnidadMedidaTextBox, 0);
            this.Controls.SetChildIndex(idUnidadMedidaLabel, 0);
            this.Controls.SetChildIndex(this.descripcionTextBox, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.unidadesMedidaBindingNavigator)).EndInit();
            this.unidadesMedidaBindingNavigator.ResumeLayout(false);
            this.unidadesMedidaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesMedidaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource unidadesMedidaBindingSource;
        private System.Windows.Forms.BindingNavigator unidadesMedidaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton unidadesMedidaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox idUnidadMedidaTextBox;
        private System.Windows.Forms.TextBox nombreCortoTextBox;
    }
}