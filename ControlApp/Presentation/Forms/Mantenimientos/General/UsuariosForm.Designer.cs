﻿namespace ControlApp.Presentation.Forms.Mantenimientos
{
    partial class UsuariosForm
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
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.usuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.usuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.administradorCheckBox = new System.Windows.Forms.CheckBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.mantenimientosCheckBox = new System.Windows.Forms.CheckBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.otrosCheckBox = new System.Windows.Forms.CheckBox();
            this.procesosCheckBox = new System.Windows.Forms.CheckBox();
            this.reportesCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.consultasCheckBox = new System.Windows.Forms.CheckBox();
            claveLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).BeginInit();
            this.usuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.TabIndex = 7;
            // 
            // btnFind
            // 
            this.btnFind.TabIndex = 6;
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(48, 127);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(37, 13);
            claveLabel.TabIndex = 6;
            claveLabel.Text = "Clave:";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(48, 75);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(58, 13);
            idUsuarioLabel.TabIndex = 8;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(48, 101);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre:";
            // 
            // usuarioBindingNavigator
            // 
            this.usuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuarioBindingNavigator.BindingSource = this.usuarioBindingSource;
            this.usuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.usuarioBindingNavigatorSaveItem});
            this.usuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuarioBindingNavigator.Name = "usuarioBindingNavigator";
            this.usuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuarioBindingNavigator.Size = new System.Drawing.Size(553, 25);
            this.usuarioBindingNavigator.TabIndex = 5;
            this.usuarioBindingNavigator.Text = "bindingNavigator1";
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
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(ControlEntity.Usuario);
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
            // usuarioBindingNavigatorSaveItem
            // 
            this.usuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioBindingNavigatorSaveItem.Image")));
            this.usuarioBindingNavigatorSaveItem.Name = "usuarioBindingNavigatorSaveItem";
            this.usuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usuarioBindingNavigatorSaveItem.Text = "Guardar datos";
            this.usuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuarioBindingNavigatorSaveItem_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(295, 164);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 3;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // administradorCheckBox
            // 
            this.administradorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Administrador", true));
            this.administradorCheckBox.Location = new System.Drawing.Point(295, 194);
            this.administradorCheckBox.Name = "administradorCheckBox";
            this.administradorCheckBox.Size = new System.Drawing.Size(104, 24);
            this.administradorCheckBox.TabIndex = 4;
            this.administradorCheckBox.Text = "Administrador";
            this.administradorCheckBox.UseVisualStyleBackColor = true;
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(138, 124);
            this.claveTextBox.MaxLength = 50;
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(104, 20);
            this.claveTextBox.TabIndex = 1;
            this.claveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.claveTextBox_KeyPress);
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Enabled = false;
            this.idUsuarioTextBox.Location = new System.Drawing.Point(138, 72);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.ReadOnly = true;
            this.idUsuarioTextBox.Size = new System.Drawing.Size(104, 20);
            this.idUsuarioTextBox.TabIndex = 5;
            // 
            // mantenimientosCheckBox
            // 
            this.mantenimientosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Mantenimientos", true));
            this.mantenimientosCheckBox.Location = new System.Drawing.Point(19, 24);
            this.mantenimientosCheckBox.Name = "mantenimientosCheckBox";
            this.mantenimientosCheckBox.Size = new System.Drawing.Size(104, 24);
            this.mantenimientosCheckBox.TabIndex = 0;
            this.mantenimientosCheckBox.Text = "Mantenimientos";
            this.mantenimientosCheckBox.UseVisualStyleBackColor = true;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(138, 98);
            this.nombreTextBox.MaxLength = 50;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(278, 20);
            this.nombreTextBox.TabIndex = 0;
            // 
            // otrosCheckBox
            // 
            this.otrosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Otros", true));
            this.otrosCheckBox.Location = new System.Drawing.Point(19, 51);
            this.otrosCheckBox.Name = "otrosCheckBox";
            this.otrosCheckBox.Size = new System.Drawing.Size(104, 24);
            this.otrosCheckBox.TabIndex = 1;
            this.otrosCheckBox.Text = "Otros";
            this.otrosCheckBox.UseVisualStyleBackColor = true;
            // 
            // procesosCheckBox
            // 
            this.procesosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Procesos", true));
            this.procesosCheckBox.Location = new System.Drawing.Point(19, 78);
            this.procesosCheckBox.Name = "procesosCheckBox";
            this.procesosCheckBox.Size = new System.Drawing.Size(104, 24);
            this.procesosCheckBox.TabIndex = 2;
            this.procesosCheckBox.Text = "Procesos";
            this.procesosCheckBox.UseVisualStyleBackColor = true;
            // 
            // reportesCheckBox
            // 
            this.reportesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Reportes", true));
            this.reportesCheckBox.Location = new System.Drawing.Point(19, 105);
            this.reportesCheckBox.Name = "reportesCheckBox";
            this.reportesCheckBox.Size = new System.Drawing.Size(104, 24);
            this.reportesCheckBox.TabIndex = 3;
            this.reportesCheckBox.Text = "Reportes";
            this.reportesCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.consultasCheckBox);
            this.groupBox1.Controls.Add(this.mantenimientosCheckBox);
            this.groupBox1.Controls.Add(this.otrosCheckBox);
            this.groupBox1.Controls.Add(this.procesosCheckBox);
            this.groupBox1.Controls.Add(this.reportesCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(50, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // consultasCheckBox
            // 
            this.consultasCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Consultas", true));
            this.consultasCheckBox.Location = new System.Drawing.Point(19, 132);
            this.consultasCheckBox.Name = "consultasCheckBox";
            this.consultasCheckBox.Size = new System.Drawing.Size(104, 24);
            this.consultasCheckBox.TabIndex = 4;
            this.consultasCheckBox.Text = "Consultas";
            this.consultasCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.administradorCheckBox);
            this.Controls.Add(claveLabel);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(idUsuarioLabel);
            this.Controls.Add(this.idUsuarioTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.usuarioBindingNavigator);
            this.Name = "UsuariosForm";
            this.OrderKeys = "Nombre";
            this.Text = "UsuariosForm";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.usuarioBindingNavigator, 0);
            this.Controls.SetChildIndex(this.nombreTextBox, 0);
            this.Controls.SetChildIndex(nombreLabel, 0);
            this.Controls.SetChildIndex(this.idUsuarioTextBox, 0);
            this.Controls.SetChildIndex(idUsuarioLabel, 0);
            this.Controls.SetChildIndex(this.claveTextBox, 0);
            this.Controls.SetChildIndex(claveLabel, 0);
            this.Controls.SetChildIndex(this.administradorCheckBox, 0);
            this.Controls.SetChildIndex(this.activoCheckBox, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).EndInit();
            this.usuarioBindingNavigator.ResumeLayout(false);
            this.usuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingNavigator usuarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton usuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.CheckBox administradorCheckBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.CheckBox mantenimientosCheckBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.CheckBox otrosCheckBox;
        private System.Windows.Forms.CheckBox procesosCheckBox;
        private System.Windows.Forms.CheckBox reportesCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox consultasCheckBox;
    }
}