namespace ControlApp.Presentation.Forms.Mantenimientos
{
    partial class ProductosForm
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label productoIdLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label precioUnitarioLabel;
            System.Windows.Forms.Label precioVentaLabel;
            System.Windows.Forms.Label minimoLabel;
            System.Windows.Forms.Label impuestosLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label unidadesMedidaLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label utilidadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosForm));
            this.cboProveedores = new System.Windows.Forms.ComboBox();
            this.gridExistencias = new System.Windows.Forms.DataGridView();
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.productoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.productoIdTextBox = new System.Windows.Forms.TextBox();
            this.precioUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.precioVentaTextBox = new System.Windows.Forms.TextBox();
            this.minimoTextBox = new System.Windows.Forms.TextBox();
            this.impuestosTextBox = new System.Windows.Forms.TextBox();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.verificaDisponibleCheckBox = new System.Windows.Forms.CheckBox();
            this.cboUnidadesMedidas = new System.Windows.Forms.ComboBox();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.utilidadTextBox = new System.Windows.Forms.TextBox();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            productoIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            precioUnitarioLabel = new System.Windows.Forms.Label();
            precioVentaLabel = new System.Windows.Forms.Label();
            minimoLabel = new System.Windows.Forms.Label();
            impuestosLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            unidadesMedidaLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            utilidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridExistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.TabIndex = 14;
            // 
            // btnFind
            // 
            this.btnFind.TabIndex = 13;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(32, 85);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 7;
            codigoLabel.Text = "Código:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(32, 111);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 9;
            descripcionLabel.Text = "Descripción:";
            // 
            // productoIdLabel
            // 
            productoIdLabel.AutoSize = true;
            productoIdLabel.Location = new System.Drawing.Point(32, 56);
            productoIdLabel.Name = "productoIdLabel";
            productoIdLabel.Size = new System.Drawing.Size(65, 13);
            productoIdLabel.TabIndex = 0;
            productoIdLabel.Text = "Producto Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 168);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 13;
            label1.Text = "Proveedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(106, 196);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 0;
            label2.Text = "Existencias:";
            // 
            // precioUnitarioLabel
            // 
            precioUnitarioLabel.AutoSize = true;
            precioUnitarioLabel.Location = new System.Drawing.Point(392, 100);
            precioUnitarioLabel.Name = "precioUnitarioLabel";
            precioUnitarioLabel.Size = new System.Drawing.Size(79, 13);
            precioUnitarioLabel.TabIndex = 14;
            precioUnitarioLabel.Text = "Precio Unitario:";
            // 
            // precioVentaLabel
            // 
            precioVentaLabel.AutoSize = true;
            precioVentaLabel.Location = new System.Drawing.Point(392, 126);
            precioVentaLabel.Name = "precioVentaLabel";
            precioVentaLabel.Size = new System.Drawing.Size(71, 13);
            precioVentaLabel.TabIndex = 16;
            precioVentaLabel.Text = "Precio Venta:";
            // 
            // minimoLabel
            // 
            minimoLabel.AutoSize = true;
            minimoLabel.Location = new System.Drawing.Point(392, 228);
            minimoLabel.Name = "minimoLabel";
            minimoLabel.Size = new System.Drawing.Size(45, 13);
            minimoLabel.TabIndex = 18;
            minimoLabel.Text = "Mínimo:";
            // 
            // impuestosLabel
            // 
            impuestosLabel.AutoSize = true;
            impuestosLabel.Location = new System.Drawing.Point(391, 273);
            impuestosLabel.Name = "impuestosLabel";
            impuestosLabel.Size = new System.Drawing.Size(58, 13);
            impuestosLabel.TabIndex = 20;
            impuestosLabel.Text = "Impuestos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(392, 163);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 13);
            label3.TabIndex = 23;
            label3.Text = "Categoría:";
            // 
            // unidadesMedidaLabel
            // 
            unidadesMedidaLabel.AutoSize = true;
            unidadesMedidaLabel.Location = new System.Drawing.Point(392, 199);
            unidadesMedidaLabel.Name = "unidadesMedidaLabel";
            unidadesMedidaLabel.Size = new System.Drawing.Size(93, 13);
            unidadesMedidaLabel.TabIndex = 25;
            unidadesMedidaLabel.Text = "Unidades Medida:";
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.Location = new System.Drawing.Point(392, 250);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(62, 13);
            descuentoLabel.TabIndex = 27;
            descuentoLabel.Text = "Descuento:";
            // 
            // utilidadLabel
            // 
            utilidadLabel.AutoSize = true;
            utilidadLabel.Location = new System.Drawing.Point(392, 74);
            utilidadLabel.Name = "utilidadLabel";
            utilidadLabel.Size = new System.Drawing.Size(45, 13);
            utilidadLabel.TabIndex = 29;
            utilidadLabel.Text = "Utilidad:";
            // 
            // cboProveedores
            // 
            this.cboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedores.FormattingEnabled = true;
            this.cboProveedores.Location = new System.Drawing.Point(109, 160);
            this.cboProveedores.Name = "cboProveedores";
            this.cboProveedores.Size = new System.Drawing.Size(261, 21);
            this.cboProveedores.TabIndex = 2;
            // 
            // gridExistencias
            // 
            this.gridExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExistencias.Location = new System.Drawing.Point(109, 225);
            this.gridExistencias.Name = "gridExistencias";
            this.gridExistencias.Size = new System.Drawing.Size(261, 122);
            this.gridExistencias.TabIndex = 3;
            this.gridExistencias.TabStop = false;
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productoBindingNavigator.BindingSource = this.productoBindingSource;
            this.productoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productoBindingNavigatorSaveItem});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productoBindingNavigator.Size = new System.Drawing.Size(724, 25);
            this.productoBindingNavigator.TabIndex = 12;
            this.productoBindingNavigator.Text = "bindingNavigator1";
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
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(ControlEntity.Producto);
            this.productoBindingSource.PositionChanged += new System.EventHandler(this.productoBindingSource_PositionChanged);
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
            // productoBindingNavigatorSaveItem
            // 
            this.productoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productoBindingNavigatorSaveItem.Image")));
            this.productoBindingNavigatorSaveItem.Name = "productoBindingNavigatorSaveItem";
            this.productoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.productoBindingNavigatorSaveItem.Click += new System.EventHandler(this.productoBindingNavigatorSaveItem_Click);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(109, 82);
            this.codigoTextBox.MaxLength = 50;
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(261, 20);
            this.codigoTextBox.TabIndex = 0;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(109, 108);
            this.descripcionTextBox.MaxLength = 100;
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(261, 46);
            this.descripcionTextBox.TabIndex = 1;
            // 
            // productoIdTextBox
            // 
            this.productoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "IdProducto", true));
            this.productoIdTextBox.Location = new System.Drawing.Point(109, 56);
            this.productoIdTextBox.Name = "productoIdTextBox";
            this.productoIdTextBox.ReadOnly = true;
            this.productoIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.productoIdTextBox.TabIndex = 12;
            this.productoIdTextBox.TabStop = false;
            // 
            // precioUnitarioTextBox
            // 
            this.precioUnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "PrecioUnitario", true));
            this.precioUnitarioTextBox.Location = new System.Drawing.Point(491, 97);
            this.precioUnitarioTextBox.Name = "precioUnitarioTextBox";
            this.precioUnitarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioUnitarioTextBox.TabIndex = 5;
            // 
            // precioVentaTextBox
            // 
            this.precioVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "PrecioVenta", true));
            this.precioVentaTextBox.Location = new System.Drawing.Point(491, 123);
            this.precioVentaTextBox.Name = "precioVentaTextBox";
            this.precioVentaTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioVentaTextBox.TabIndex = 6;
            this.precioVentaTextBox.Leave += new System.EventHandler(this.precioVentaTextBox_Leave);
            // 
            // minimoTextBox
            // 
            this.minimoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Minimo", true));
            this.minimoTextBox.Location = new System.Drawing.Point(491, 225);
            this.minimoTextBox.Name = "minimoTextBox";
            this.minimoTextBox.Size = new System.Drawing.Size(100, 20);
            this.minimoTextBox.TabIndex = 9;
            // 
            // impuestosTextBox
            // 
            this.impuestosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Impuestos", true));
            this.impuestosTextBox.Location = new System.Drawing.Point(491, 270);
            this.impuestosTextBox.Name = "impuestosTextBox";
            this.impuestosTextBox.Size = new System.Drawing.Size(60, 20);
            this.impuestosTextBox.TabIndex = 11;
            // 
            // cboCategorias
            // 
            this.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(491, 160);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(155, 21);
            this.cboCategorias.TabIndex = 7;
            // 
            // verificaDisponibleCheckBox
            // 
            this.verificaDisponibleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productoBindingSource, "VerificaDisponible", true));
            this.verificaDisponibleCheckBox.Location = new System.Drawing.Point(395, 298);
            this.verificaDisponibleCheckBox.Name = "verificaDisponibleCheckBox";
            this.verificaDisponibleCheckBox.Size = new System.Drawing.Size(123, 24);
            this.verificaDisponibleCheckBox.TabIndex = 11;
            this.verificaDisponibleCheckBox.Text = "Verifica Disponible";
            this.verificaDisponibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // cboUnidadesMedidas
            // 
            this.cboUnidadesMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadesMedidas.FormattingEnabled = true;
            this.cboUnidadesMedidas.Location = new System.Drawing.Point(491, 191);
            this.cboUnidadesMedidas.Name = "cboUnidadesMedidas";
            this.cboUnidadesMedidas.Size = new System.Drawing.Size(155, 21);
            this.cboUnidadesMedidas.TabIndex = 8;
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Descuento", true));
            this.descuentoTextBox.Location = new System.Drawing.Point(491, 247);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(60, 20);
            this.descuentoTextBox.TabIndex = 10;
            // 
            // utilidadTextBox
            // 
            this.utilidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Utilidad", true));
            this.utilidadTextBox.Location = new System.Drawing.Point(491, 71);
            this.utilidadTextBox.Name = "utilidadTextBox";
            this.utilidadTextBox.Size = new System.Drawing.Size(60, 20);
            this.utilidadTextBox.TabIndex = 4;
            this.utilidadTextBox.Leave += new System.EventHandler(this.utilidadTextBox_Leave);
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 395);
            this.Controls.Add(utilidadLabel);
            this.Controls.Add(this.utilidadTextBox);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(this.descuentoTextBox);
            this.Controls.Add(this.cboUnidadesMedidas);
            this.Controls.Add(unidadesMedidaLabel);
            this.Controls.Add(this.verificaDisponibleCheckBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.cboCategorias);
            this.Controls.Add(impuestosLabel);
            this.Controls.Add(this.impuestosTextBox);
            this.Controls.Add(minimoLabel);
            this.Controls.Add(this.minimoTextBox);
            this.Controls.Add(precioVentaLabel);
            this.Controls.Add(this.precioVentaTextBox);
            this.Controls.Add(precioUnitarioLabel);
            this.Controls.Add(this.precioUnitarioTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(productoIdLabel);
            this.Controls.Add(this.productoIdTextBox);
            this.Controls.Add(this.productoBindingNavigator);
            this.Controls.Add(this.gridExistencias);
            this.Controls.Add(this.cboProveedores);
            this.Name = "ProductosForm";
            this.OrderKeys = "Codigo, Descripcion";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            this.Controls.SetChildIndex(this.cboProveedores, 0);
            this.Controls.SetChildIndex(this.gridExistencias, 0);
            this.Controls.SetChildIndex(this.productoBindingNavigator, 0);
            this.Controls.SetChildIndex(this.productoIdTextBox, 0);
            this.Controls.SetChildIndex(productoIdLabel, 0);
            this.Controls.SetChildIndex(this.descripcionTextBox, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            this.Controls.SetChildIndex(this.codigoTextBox, 0);
            this.Controls.SetChildIndex(codigoLabel, 0);
            this.Controls.SetChildIndex(label1, 0);
            this.Controls.SetChildIndex(label2, 0);
            this.Controls.SetChildIndex(this.precioUnitarioTextBox, 0);
            this.Controls.SetChildIndex(precioUnitarioLabel, 0);
            this.Controls.SetChildIndex(this.precioVentaTextBox, 0);
            this.Controls.SetChildIndex(precioVentaLabel, 0);
            this.Controls.SetChildIndex(this.minimoTextBox, 0);
            this.Controls.SetChildIndex(minimoLabel, 0);
            this.Controls.SetChildIndex(this.impuestosTextBox, 0);
            this.Controls.SetChildIndex(impuestosLabel, 0);
            this.Controls.SetChildIndex(this.cboCategorias, 0);
            this.Controls.SetChildIndex(label3, 0);
            this.Controls.SetChildIndex(this.verificaDisponibleCheckBox, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(unidadesMedidaLabel, 0);
            this.Controls.SetChildIndex(this.cboUnidadesMedidas, 0);
            this.Controls.SetChildIndex(this.descuentoTextBox, 0);
            this.Controls.SetChildIndex(descuentoLabel, 0);
            this.Controls.SetChildIndex(this.utilidadTextBox, 0);
            this.Controls.SetChildIndex(utilidadLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridExistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProveedores;
        private System.Windows.Forms.DataGridView gridExistencias;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox productoIdTextBox;
        private System.Windows.Forms.TextBox precioUnitarioTextBox;
        private System.Windows.Forms.TextBox precioVentaTextBox;
        private System.Windows.Forms.TextBox minimoTextBox;
        private System.Windows.Forms.TextBox impuestosTextBox;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.CheckBox verificaDisponibleCheckBox;
        private System.Windows.Forms.ComboBox cboUnidadesMedidas;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.TextBox utilidadTextBox;
    }
}