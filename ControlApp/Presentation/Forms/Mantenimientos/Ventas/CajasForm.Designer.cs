namespace ControlApp.Presentation.Forms.Mantenimientos
{
    partial class CajasForm
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
            System.Windows.Forms.Label consecutivoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idCajaLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajasForm));
            this.cajaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.cajaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.consecutivoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.disponibleCheckBox = new System.Windows.Forms.CheckBox();
            this.idCajaTextBox = new System.Windows.Forms.TextBox();
            this.usaConsecutivoGlobalCheckBox = new System.Windows.Forms.CheckBox();
            this.cboUsuarios = new BaseControls.Derived.ComboBasic();
            this.gridFormasPago = new System.Windows.Forms.DataGridView();
            this.btnAddFormaPago = new System.Windows.Forms.Button();
            this.btnDeleteFormaPago = new System.Windows.Forms.Button();
            this.guardadoAutomaticoCheckBox = new System.Windows.Forms.CheckBox();
            consecutivoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            idCajaLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cajaBindingNavigator)).BeginInit();
            this.cajaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormasPago)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.TabIndex = 11;
            // 
            // btnFind
            // 
            this.btnFind.TabIndex = 10;
            // 
            // consecutivoLabel
            // 
            consecutivoLabel.AutoSize = true;
            consecutivoLabel.Location = new System.Drawing.Point(78, 160);
            consecutivoLabel.Name = "consecutivoLabel";
            consecutivoLabel.Size = new System.Drawing.Size(69, 13);
            consecutivoLabel.TabIndex = 4;
            consecutivoLabel.Text = "Consecutivo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(78, 74);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "Descripcion:";
            // 
            // idCajaLabel
            // 
            idCajaLabel.AutoSize = true;
            idCajaLabel.Enabled = false;
            idCajaLabel.Location = new System.Drawing.Point(78, 31);
            idCajaLabel.Name = "idCajaLabel";
            idCajaLabel.Size = new System.Drawing.Size(43, 13);
            idCajaLabel.TabIndex = 10;
            idCajaLabel.Text = "Id Caja:";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(78, 134);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(46, 13);
            idUsuarioLabel.TabIndex = 12;
            idUsuarioLabel.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(81, 217);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 13);
            label1.TabIndex = 17;
            label1.Text = "Formas de pago:";
            // 
            // cajaBindingNavigator
            // 
            this.cajaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cajaBindingNavigator.BindingSource = this.cajaBindingSource;
            this.cajaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cajaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cajaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cajaBindingNavigatorSaveItem});
            this.cajaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cajaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cajaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cajaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cajaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cajaBindingNavigator.Name = "cajaBindingNavigator";
            this.cajaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cajaBindingNavigator.Size = new System.Drawing.Size(585, 25);
            this.cajaBindingNavigator.TabIndex = 9;
            this.cajaBindingNavigator.Text = "bindingNavigator1";
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
            // cajaBindingSource
            // 
            //this.cajaBindingSource.DataSource = typeof(ControlEntity.Caja);
            this.cajaBindingSource.PositionChanged += new System.EventHandler(this.cajaBindingSource_PositionChanged);
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
            // cajaBindingNavigatorSaveItem
            // 
            this.cajaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cajaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cajaBindingNavigatorSaveItem.Image")));
            this.cajaBindingNavigatorSaveItem.Name = "cajaBindingNavigatorSaveItem";
            this.cajaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cajaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.cajaBindingNavigatorSaveItem.Click += new System.EventHandler(this.cajaBindingNavigatorSaveItem_Click);
            // 
            // consecutivoTextBox
            // 
            this.consecutivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cajaBindingSource, "Consecutivo", true));
            this.consecutivoTextBox.Location = new System.Drawing.Point(208, 157);
            this.consecutivoTextBox.Name = "consecutivoTextBox";
            this.consecutivoTextBox.Size = new System.Drawing.Size(104, 20);
            this.consecutivoTextBox.TabIndex = 3;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cajaBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(208, 71);
            this.descripcionTextBox.MaxLength = 50;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(242, 20);
            this.descripcionTextBox.TabIndex = 0;
            // 
            // disponibleCheckBox
            // 
            this.disponibleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cajaBindingSource, "Disponible", true));
            this.disponibleCheckBox.Location = new System.Drawing.Point(208, 101);
            this.disponibleCheckBox.Name = "disponibleCheckBox";
            this.disponibleCheckBox.Size = new System.Drawing.Size(104, 24);
            this.disponibleCheckBox.TabIndex = 1;
            this.disponibleCheckBox.Text = "Disponible";
            this.disponibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // idCajaTextBox
            // 
            this.idCajaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cajaBindingSource, "IdCaja", true));
            this.idCajaTextBox.Enabled = false;
            this.idCajaTextBox.Location = new System.Drawing.Point(208, 28);
            this.idCajaTextBox.Name = "idCajaTextBox";
            this.idCajaTextBox.ReadOnly = true;
            this.idCajaTextBox.Size = new System.Drawing.Size(104, 20);
            this.idCajaTextBox.TabIndex = 11;
            // 
            // usaConsecutivoGlobalCheckBox
            // 
            this.usaConsecutivoGlobalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cajaBindingSource, "UsaConsecutivoGlobal", true));
            this.usaConsecutivoGlobalCheckBox.Location = new System.Drawing.Point(327, 155);
            this.usaConsecutivoGlobalCheckBox.Name = "usaConsecutivoGlobalCheckBox";
            this.usaConsecutivoGlobalCheckBox.Size = new System.Drawing.Size(166, 24);
            this.usaConsecutivoGlobalCheckBox.TabIndex = 4;
            this.usaConsecutivoGlobalCheckBox.Text = "Usa Consecutivo Global";
            this.usaConsecutivoGlobalCheckBox.UseVisualStyleBackColor = true;
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(208, 128);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cboUsuarios.TabIndex = 2;
            // 
            // gridFormasPago
            // 
            this.gridFormasPago.AllowUserToAddRows = false;
            this.gridFormasPago.AllowUserToDeleteRows = false;
            this.gridFormasPago.AllowUserToOrderColumns = true;
            this.gridFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFormasPago.Location = new System.Drawing.Point(84, 233);
            this.gridFormasPago.Name = "gridFormasPago";
            this.gridFormasPago.ReadOnly = true;
            this.gridFormasPago.RowHeadersVisible = false;
            this.gridFormasPago.Size = new System.Drawing.Size(290, 150);
            this.gridFormasPago.TabIndex = 6;
            this.gridFormasPago.TabStop = false;
            // 
            // btnAddFormaPago
            // 
            this.btnAddFormaPago.Location = new System.Drawing.Point(84, 389);
            this.btnAddFormaPago.Name = "btnAddFormaPago";
            this.btnAddFormaPago.Size = new System.Drawing.Size(142, 39);
            this.btnAddFormaPago.TabIndex = 7;
            this.btnAddFormaPago.Text = "Agregar forma de pago...";
            this.btnAddFormaPago.UseVisualStyleBackColor = true;
            this.btnAddFormaPago.Click += new System.EventHandler(this.btnAddFormaPago_Click);
            // 
            // btnDeleteFormaPago
            // 
            this.btnDeleteFormaPago.Location = new System.Drawing.Point(232, 389);
            this.btnDeleteFormaPago.Name = "btnDeleteFormaPago";
            this.btnDeleteFormaPago.Size = new System.Drawing.Size(142, 39);
            this.btnDeleteFormaPago.TabIndex = 8;
            this.btnDeleteFormaPago.Text = "Borrar forma de pago...";
            this.btnDeleteFormaPago.UseVisualStyleBackColor = true;
            this.btnDeleteFormaPago.Click += new System.EventHandler(this.btnDeleteFormaPago_Click);
            // 
            // guardadoAutomaticoCheckBox
            // 
            this.guardadoAutomaticoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cajaBindingSource, "GuardadoAutomatico", true));
            this.guardadoAutomaticoCheckBox.Location = new System.Drawing.Point(327, 185);
            this.guardadoAutomaticoCheckBox.Name = "guardadoAutomaticoCheckBox";
            this.guardadoAutomaticoCheckBox.Size = new System.Drawing.Size(163, 24);
            this.guardadoAutomaticoCheckBox.TabIndex = 5;
            this.guardadoAutomaticoCheckBox.Text = "Guardado Automatico";
            this.guardadoAutomaticoCheckBox.UseVisualStyleBackColor = true;
            // 
            // Cajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 448);
            this.Controls.Add(this.guardadoAutomaticoCheckBox);
            this.Controls.Add(this.btnDeleteFormaPago);
            this.Controls.Add(this.btnAddFormaPago);
            this.Controls.Add(this.gridFormasPago);
            this.Controls.Add(label1);
            this.Controls.Add(this.cboUsuarios);
            this.Controls.Add(consecutivoLabel);
            this.Controls.Add(this.consecutivoTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.disponibleCheckBox);
            this.Controls.Add(idCajaLabel);
            this.Controls.Add(this.idCajaTextBox);
            this.Controls.Add(idUsuarioLabel);
            this.Controls.Add(this.usaConsecutivoGlobalCheckBox);
            this.Controls.Add(this.cajaBindingNavigator);
            this.Name = "Cajas";
            this.Text = "Cajas";
            this.Load += new System.EventHandler(this.Cajas_Load);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.cajaBindingNavigator, 0);
            this.Controls.SetChildIndex(this.usaConsecutivoGlobalCheckBox, 0);
            this.Controls.SetChildIndex(idUsuarioLabel, 0);
            this.Controls.SetChildIndex(this.idCajaTextBox, 0);
            this.Controls.SetChildIndex(idCajaLabel, 0);
            this.Controls.SetChildIndex(this.disponibleCheckBox, 0);
            this.Controls.SetChildIndex(this.descripcionTextBox, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            this.Controls.SetChildIndex(this.consecutivoTextBox, 0);
            this.Controls.SetChildIndex(consecutivoLabel, 0);
            this.Controls.SetChildIndex(this.cboUsuarios, 0);
            this.Controls.SetChildIndex(label1, 0);
            this.Controls.SetChildIndex(this.gridFormasPago, 0);
            this.Controls.SetChildIndex(this.btnAddFormaPago, 0);
            this.Controls.SetChildIndex(this.btnDeleteFormaPago, 0);
            this.Controls.SetChildIndex(this.guardadoAutomaticoCheckBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cajaBindingNavigator)).EndInit();
            this.cajaBindingNavigator.ResumeLayout(false);
            this.cajaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormasPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cajaBindingSource;
        private System.Windows.Forms.BindingNavigator cajaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cajaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox consecutivoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.CheckBox disponibleCheckBox;
        private System.Windows.Forms.TextBox idCajaTextBox;
        private System.Windows.Forms.CheckBox usaConsecutivoGlobalCheckBox;
        private BaseControls.Derived.ComboBasic cboUsuarios;
        private System.Windows.Forms.DataGridView gridFormasPago;
        private System.Windows.Forms.Button btnAddFormaPago;
        private System.Windows.Forms.Button btnDeleteFormaPago;
        private System.Windows.Forms.CheckBox guardadoAutomaticoCheckBox;

    }
}