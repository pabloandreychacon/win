namespace ControlApp.Presentation.Forms.Mantenimientos.General
{
    partial class ParametrosGenerales
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
            System.Windows.Forms.Label idParametroLabel;
            System.Windows.Forms.Label redondeoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametrosGenerales));
            this.parametrosGeneralBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.parametrosGeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.parametrosGeneralBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idParametroTextBox = new System.Windows.Forms.TextBox();
            this.redondeoComboBox = new System.Windows.Forms.ComboBox();
            idParametroLabel = new System.Windows.Forms.Label();
            redondeoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosGeneralBindingNavigator)).BeginInit();
            this.parametrosGeneralBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosGeneralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.TabIndex = 3;
            // 
            // idParametroLabel
            // 
            idParametroLabel.AutoSize = true;
            idParametroLabel.Location = new System.Drawing.Point(264, 31);
            idParametroLabel.Name = "idParametroLabel";
            idParametroLabel.Size = new System.Drawing.Size(70, 13);
            idParametroLabel.TabIndex = 4;
            idParametroLabel.Text = "Id Parametro:";
            idParametroLabel.Visible = false;
            // 
            // redondeoLabel1
            // 
            redondeoLabel1.AutoSize = true;
            redondeoLabel1.Location = new System.Drawing.Point(132, 66);
            redondeoLabel1.Name = "redondeoLabel1";
            redondeoLabel1.Size = new System.Drawing.Size(60, 13);
            redondeoLabel1.TabIndex = 9;
            redondeoLabel1.Text = "Redondeo:";
            // 
            // parametrosGeneralBindingNavigator
            // 
            this.parametrosGeneralBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.parametrosGeneralBindingNavigator.BindingSource = this.parametrosGeneralBindingSource;
            this.parametrosGeneralBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.parametrosGeneralBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.parametrosGeneralBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.parametrosGeneralBindingNavigatorSaveItem});
            this.parametrosGeneralBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.parametrosGeneralBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.parametrosGeneralBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.parametrosGeneralBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.parametrosGeneralBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.parametrosGeneralBindingNavigator.Name = "parametrosGeneralBindingNavigator";
            this.parametrosGeneralBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.parametrosGeneralBindingNavigator.Size = new System.Drawing.Size(574, 25);
            this.parametrosGeneralBindingNavigator.TabIndex = 1;
            this.parametrosGeneralBindingNavigator.Text = "bindingNavigator1";
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
            // parametrosGeneralBindingSource
            // 
            this.parametrosGeneralBindingSource.DataSource = typeof(ControlEntity.ParametrosGeneral);
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
            // parametrosGeneralBindingNavigatorSaveItem
            // 
            this.parametrosGeneralBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.parametrosGeneralBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("parametrosGeneralBindingNavigatorSaveItem.Image")));
            this.parametrosGeneralBindingNavigatorSaveItem.Name = "parametrosGeneralBindingNavigatorSaveItem";
            this.parametrosGeneralBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.parametrosGeneralBindingNavigatorSaveItem.Text = "Guardar datos";
            this.parametrosGeneralBindingNavigatorSaveItem.Click += new System.EventHandler(this.parametrosGeneralBindingNavigatorSaveItem_Click);
            // 
            // idParametroTextBox
            // 
            this.idParametroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "IdParametro", true));
            this.idParametroTextBox.Enabled = false;
            this.idParametroTextBox.Location = new System.Drawing.Point(340, 28);
            this.idParametroTextBox.Name = "idParametroTextBox";
            this.idParametroTextBox.ReadOnly = true;
            this.idParametroTextBox.Size = new System.Drawing.Size(121, 20);
            this.idParametroTextBox.TabIndex = 5;
            this.idParametroTextBox.Visible = false;
            // 
            // redondeoComboBox
            // 
            this.redondeoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.redondeoComboBox.FormattingEnabled = true;
            this.redondeoComboBox.Location = new System.Drawing.Point(208, 63);
            this.redondeoComboBox.Name = "redondeoComboBox";
            this.redondeoComboBox.Size = new System.Drawing.Size(121, 21);
            this.redondeoComboBox.TabIndex = 0;
            // 
            // ParametrosGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 212);
            this.Controls.Add(redondeoLabel1);
            this.Controls.Add(this.redondeoComboBox);
            this.Controls.Add(idParametroLabel);
            this.Controls.Add(this.idParametroTextBox);
            this.Controls.Add(this.parametrosGeneralBindingNavigator);
            this.Name = "ParametrosGenerales";
            this.Text = "ParametrosGenerales";
            this.Load += new System.EventHandler(this.ParametrosGenerales_Load);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.parametrosGeneralBindingNavigator, 0);
            this.Controls.SetChildIndex(this.idParametroTextBox, 0);
            this.Controls.SetChildIndex(idParametroLabel, 0);
            this.Controls.SetChildIndex(this.redondeoComboBox, 0);
            this.Controls.SetChildIndex(redondeoLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.parametrosGeneralBindingNavigator)).EndInit();
            this.parametrosGeneralBindingNavigator.ResumeLayout(false);
            this.parametrosGeneralBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosGeneralBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource parametrosGeneralBindingSource;
        private System.Windows.Forms.BindingNavigator parametrosGeneralBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton parametrosGeneralBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idParametroTextBox;
        private System.Windows.Forms.ComboBox redondeoComboBox;
    }
}