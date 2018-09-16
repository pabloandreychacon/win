namespace ControlApp.Presentation.Forms.Procesos
{
    partial class PagosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagosForm));
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.txtTotalPagar = new BaseControls.Derived.TextBasic();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEfectivoMontoRecibido = new BaseControls.Derived.TextBasic();
            this.gridPagos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPagosData = new System.Windows.Forms.TabControl();
            this.tabEfectivo = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTarjetas = new BaseControls.Derived.ComboBasic();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTarjetaChequeDocumento = new BaseControls.Derived.TextBasic();
            this.cboBancos = new BaseControls.Derived.ComboBasic();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEfectivoMontoAplicar = new BaseControls.Derived.TextBasic();
            this.tabCredito = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCreditoSaldo = new BaseControls.Derived.TextBasic();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCreditoMontoAplicar = new BaseControls.Derived.TextBasic();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCreditoCuotas = new BaseControls.Derived.TextBasic();
            this.cboFrecuencias = new BaseControls.Derived.ComboBasic();
            this.label12 = new System.Windows.Forms.Label();
            this.cboLineasCredito = new BaseControls.Derived.ComboBasic();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFormasPago = new BaseControls.Derived.ComboBasic();
            this.txtTotalPagado = new BaseControls.Derived.TextBasic();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPorCobrar = new BaseControls.Derived.TextBasic();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCambio = new BaseControls.Derived.TextBasic();
            this.label9 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagos)).BeginInit();
            this.tabPagosData.SuspendLayout();
            this.tabEfectivo.SuspendLayout();
            this.tabCredito.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorContainer1
            // 
            this.errorContainer1.Location = new System.Drawing.Point(2, 102);
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(310, 418);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 32);
            this.closeButton1.TabIndex = 2;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalPagar.FormatoTexto = null;
            this.txtTotalPagar.Location = new System.Drawing.Point(200, 30);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTotalPagar.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtTotalPagar.Size = new System.Drawing.Size(127, 29);
            this.txtTotalPagar.TabIndex = 14;
            this.txtTotalPagar.TabStop = false;
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total a pagar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Forma Pago:";
            // 
            // txtEfectivoMontoRecibido
            // 
            this.txtEfectivoMontoRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivoMontoRecibido.FormatoTexto = null;
            this.txtEfectivoMontoRecibido.Location = new System.Drawing.Point(15, 36);
            this.txtEfectivoMontoRecibido.Name = "txtEfectivoMontoRecibido";
            this.txtEfectivoMontoRecibido.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtEfectivoMontoRecibido.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtEfectivoMontoRecibido.Size = new System.Drawing.Size(174, 29);
            this.txtEfectivoMontoRecibido.TabIndex = 0;
            this.txtEfectivoMontoRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEfectivoMontoRecibido.Validating += new System.ComponentModel.CancelEventHandler(this.txtEfectivoMontoRecibido_Validating);
            this.txtEfectivoMontoRecibido.Validated += new System.EventHandler(this.txtEfectivoMontoRecibido_Validated);
            // 
            // gridPagos
            // 
            this.gridPagos.AllowUserToAddRows = false;
            this.gridPagos.AllowUserToDeleteRows = false;
            this.gridPagos.AllowUserToOrderColumns = true;
            this.gridPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPagos.Location = new System.Drawing.Point(12, 257);
            this.gridPagos.MultiSelect = false;
            this.gridPagos.Name = "gridPagos";
            this.gridPagos.ReadOnly = true;
            this.gridPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPagos.Size = new System.Drawing.Size(673, 148);
            this.gridPagos.TabIndex = 22;
            this.gridPagos.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Pagado:";
            // 
            // tabPagosData
            // 
            this.tabPagosData.Controls.Add(this.tabEfectivo);
            this.tabPagosData.Controls.Add(this.tabCredito);
            this.tabPagosData.Location = new System.Drawing.Point(12, 65);
            this.tabPagosData.Name = "tabPagosData";
            this.tabPagosData.SelectedIndex = 0;
            this.tabPagosData.Size = new System.Drawing.Size(673, 162);
            this.tabPagosData.TabIndex = 0;
            this.tabPagosData.TabStop = false;
            // 
            // tabEfectivo
            // 
            this.tabEfectivo.Controls.Add(this.label7);
            this.tabEfectivo.Controls.Add(this.cboTarjetas);
            this.tabEfectivo.Controls.Add(this.label16);
            this.tabEfectivo.Controls.Add(this.label17);
            this.tabEfectivo.Controls.Add(this.txtTarjetaChequeDocumento);
            this.tabEfectivo.Controls.Add(this.cboBancos);
            this.tabEfectivo.Controls.Add(this.label11);
            this.tabEfectivo.Controls.Add(this.label10);
            this.tabEfectivo.Controls.Add(this.txtEfectivoMontoAplicar);
            this.tabEfectivo.Controls.Add(this.txtEfectivoMontoRecibido);
            this.tabEfectivo.Location = new System.Drawing.Point(4, 22);
            this.tabEfectivo.Name = "tabEfectivo";
            this.tabEfectivo.Padding = new System.Windows.Forms.Padding(3);
            this.tabEfectivo.Size = new System.Drawing.Size(665, 136);
            this.tabEfectivo.TabIndex = 0;
            this.tabEfectivo.Text = "Efectivo";
            this.tabEfectivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 58;
            this.label7.Text = "Tarjeta:";
            // 
            // cboTarjetas
            // 
            this.cboTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTarjetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTarjetas.FormattingEnabled = true;
            this.cboTarjetas.Location = new System.Drawing.Point(375, 54);
            this.cboTarjetas.Name = "cboTarjetas";
            this.cboTarjetas.Size = new System.Drawing.Size(270, 32);
            this.cboTarjetas.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(217, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 24);
            this.label16.TabIndex = 57;
            this.label16.Text = "Banco:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(217, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 24);
            this.label17.TabIndex = 56;
            this.label17.Text = "Nº Documento:";
            // 
            // txtTarjetaChequeDocumento
            // 
            this.txtTarjetaChequeDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjetaChequeDocumento.FormatoTexto = null;
            this.txtTarjetaChequeDocumento.Location = new System.Drawing.Point(375, 94);
            this.txtTarjetaChequeDocumento.MaxLength = 50;
            this.txtTarjetaChequeDocumento.Name = "txtTarjetaChequeDocumento";
            this.txtTarjetaChequeDocumento.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTarjetaChequeDocumento.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtTarjetaChequeDocumento.Size = new System.Drawing.Size(270, 29);
            this.txtTarjetaChequeDocumento.TabIndex = 4;
            // 
            // cboBancos
            // 
            this.cboBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBancos.FormattingEnabled = true;
            this.cboBancos.Location = new System.Drawing.Point(375, 14);
            this.cboBancos.Name = "cboBancos";
            this.cboBancos.Size = new System.Drawing.Size(270, 32);
            this.cboBancos.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "Aplicar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 24);
            this.label10.TabIndex = 32;
            this.label10.Text = "Monto Recibido:";
            // 
            // txtEfectivoMontoAplicar
            // 
            this.txtEfectivoMontoAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivoMontoAplicar.FormatoTexto = null;
            this.txtEfectivoMontoAplicar.Location = new System.Drawing.Point(15, 95);
            this.txtEfectivoMontoAplicar.Name = "txtEfectivoMontoAplicar";
            this.txtEfectivoMontoAplicar.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtEfectivoMontoAplicar.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtEfectivoMontoAplicar.Size = new System.Drawing.Size(174, 29);
            this.txtEfectivoMontoAplicar.TabIndex = 1;
            this.txtEfectivoMontoAplicar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEfectivoMontoAplicar.Validating += new System.ComponentModel.CancelEventHandler(this.txtEfectivoMontoAplicar_Validating);
            this.txtEfectivoMontoAplicar.Validated += new System.EventHandler(this.txtEfectivoMontoRecibido_Validated);
            // 
            // tabCredito
            // 
            this.tabCredito.Controls.Add(this.label15);
            this.tabCredito.Controls.Add(this.txtCreditoSaldo);
            this.tabCredito.Controls.Add(this.label14);
            this.tabCredito.Controls.Add(this.txtCreditoMontoAplicar);
            this.tabCredito.Controls.Add(this.label13);
            this.tabCredito.Controls.Add(this.txtCreditoCuotas);
            this.tabCredito.Controls.Add(this.cboFrecuencias);
            this.tabCredito.Controls.Add(this.label12);
            this.tabCredito.Controls.Add(this.cboLineasCredito);
            this.tabCredito.Controls.Add(this.label6);
            this.tabCredito.Location = new System.Drawing.Point(4, 22);
            this.tabCredito.Name = "tabCredito";
            this.tabCredito.Padding = new System.Windows.Forms.Padding(3);
            this.tabCredito.Size = new System.Drawing.Size(665, 136);
            this.tabCredito.TabIndex = 1;
            this.tabCredito.Text = "Credito";
            this.tabCredito.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(228, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 18);
            this.label15.TabIndex = 40;
            this.label15.Text = "Saldo actual:";
            // 
            // txtCreditoSaldo
            // 
            this.txtCreditoSaldo.Enabled = false;
            this.txtCreditoSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditoSaldo.FormatoTexto = null;
            this.txtCreditoSaldo.Location = new System.Drawing.Point(351, 35);
            this.txtCreditoSaldo.Name = "txtCreditoSaldo";
            this.txtCreditoSaldo.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCreditoSaldo.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtCreditoSaldo.ReadOnly = true;
            this.txtCreditoSaldo.Size = new System.Drawing.Size(131, 24);
            this.txtCreditoSaldo.TabIndex = 39;
            this.txtCreditoSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(228, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 18);
            this.label14.TabIndex = 38;
            this.label14.Text = "Aplicar:";
            // 
            // txtCreditoMontoAplicar
            // 
            this.txtCreditoMontoAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditoMontoAplicar.FormatoTexto = null;
            this.txtCreditoMontoAplicar.Location = new System.Drawing.Point(351, 95);
            this.txtCreditoMontoAplicar.Name = "txtCreditoMontoAplicar";
            this.txtCreditoMontoAplicar.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCreditoMontoAplicar.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtCreditoMontoAplicar.Size = new System.Drawing.Size(131, 24);
            this.txtCreditoMontoAplicar.TabIndex = 3;
            this.txtCreditoMontoAplicar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCreditoMontoAplicar.Validating += new System.ComponentModel.CancelEventHandler(this.txtCreditoMontoAplicar_Validating);
            this.txtCreditoMontoAplicar.Validated += new System.EventHandler(this.txtEfectivoMontoRecibido_Validated);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(228, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 18);
            this.label13.TabIndex = 36;
            this.label13.Text = "Cuotas:";
            // 
            // txtCreditoCuotas
            // 
            this.txtCreditoCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditoCuotas.FormatoTexto = null;
            this.txtCreditoCuotas.Location = new System.Drawing.Point(351, 64);
            this.txtCreditoCuotas.Name = "txtCreditoCuotas";
            this.txtCreditoCuotas.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCreditoCuotas.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtCreditoCuotas.Size = new System.Drawing.Size(131, 24);
            this.txtCreditoCuotas.TabIndex = 2;
            this.txtCreditoCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCreditoCuotas.Validating += new System.ComponentModel.CancelEventHandler(this.txtCreditoCuotas_Validating);
            this.txtCreditoCuotas.Validated += new System.EventHandler(this.txtEfectivoMontoRecibido_Validated);
            // 
            // cboFrecuencias
            // 
            this.cboFrecuencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrecuencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFrecuencias.FormattingEnabled = true;
            this.cboFrecuencias.Location = new System.Drawing.Point(26, 94);
            this.cboFrecuencias.Name = "cboFrecuencias";
            this.cboFrecuencias.Size = new System.Drawing.Size(172, 26);
            this.cboFrecuencias.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "Frecuencia:";
            // 
            // cboLineasCredito
            // 
            this.cboLineasCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineasCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLineasCredito.FormattingEnabled = true;
            this.cboLineasCredito.Location = new System.Drawing.Point(26, 36);
            this.cboLineasCredito.Name = "cboLineasCredito";
            this.cboLineasCredito.Size = new System.Drawing.Size(172, 26);
            this.cboLineasCredito.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Línea de crédito:";
            // 
            // cboFormasPago
            // 
            this.cboFormasPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormasPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormasPago.FormattingEnabled = true;
            this.cboFormasPago.Location = new System.Drawing.Point(16, 29);
            this.cboFormasPago.Name = "cboFormasPago";
            this.cboFormasPago.Size = new System.Drawing.Size(150, 26);
            this.cboFormasPago.TabIndex = 4;
            this.cboFormasPago.SelectedIndexChanged += new System.EventHandler(this.cboFormasPago_SelectedIndexChanged);
            // 
            // txtTotalPagado
            // 
            this.txtTotalPagado.Enabled = false;
            this.txtTotalPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagado.FormatoTexto = null;
            this.txtTotalPagado.Location = new System.Drawing.Point(333, 30);
            this.txtTotalPagado.Name = "txtTotalPagado";
            this.txtTotalPagado.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTotalPagado.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtTotalPagado.ReadOnly = true;
            this.txtTotalPagado.Size = new System.Drawing.Size(112, 29);
            this.txtTotalPagado.TabIndex = 26;
            this.txtTotalPagado.TabStop = false;
            this.txtTotalPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total Pagado:";
            // 
            // txtPorCobrar
            // 
            this.txtPorCobrar.Enabled = false;
            this.txtPorCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorCobrar.FormatoTexto = null;
            this.txtPorCobrar.Location = new System.Drawing.Point(451, 30);
            this.txtPorCobrar.Name = "txtPorCobrar";
            this.txtPorCobrar.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPorCobrar.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtPorCobrar.ReadOnly = true;
            this.txtPorCobrar.Size = new System.Drawing.Size(113, 29);
            this.txtPorCobrar.TabIndex = 28;
            this.txtPorCobrar.TabStop = false;
            this.txtPorCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Por cobrar:";
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.FormatoTexto = null;
            this.txtCambio.Location = new System.Drawing.Point(570, 30);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCambio.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(111, 29);
            this.txtCambio.TabIndex = 30;
            this.txtCambio.TabStop = false;
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(567, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Cambio:";
            // 
            // saveBtn
            // 
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(229, 418);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 32);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Image = ((System.Drawing.Image)(resources.GetObject("delBtn.Image")));
            this.delBtn.Location = new System.Drawing.Point(391, 418);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 32);
            this.delBtn.TabIndex = 3;
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // PagosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(697, 462);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPorCobrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalPagado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabPagosData);
            this.Controls.Add(this.cboFormasPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridPagos);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton1);
            this.Name = "PagosForm";
            this.Text = "PagosForm";
            this.Load += new System.EventHandler(this.PagosForm_Load);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtTotalPagar, 0);
            this.Controls.SetChildIndex(this.gridPagos, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cboFormasPago, 0);
            this.Controls.SetChildIndex(this.tabPagosData, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtTotalPagado, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPorCobrar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtCambio, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.saveBtn, 0);
            this.Controls.SetChildIndex(this.delBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridPagos)).EndInit();
            this.tabPagosData.ResumeLayout(false);
            this.tabEfectivo.ResumeLayout(false);
            this.tabEfectivo.PerformLayout();
            this.tabCredito.ResumeLayout(false);
            this.tabCredito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.TextBasic txtTotalPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.TextBasic txtEfectivoMontoRecibido;
        private System.Windows.Forms.DataGridView gridPagos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabPagosData;
        private System.Windows.Forms.TabPage tabEfectivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private BaseControls.Derived.TextBasic txtEfectivoMontoAplicar;
        private System.Windows.Forms.TabPage tabCredito;
        private System.Windows.Forms.Label label6;
        private BaseControls.Derived.ComboBasic cboFormasPago;
        private BaseControls.Derived.TextBasic txtTotalPagado;
        private System.Windows.Forms.Label label2;
        private BaseControls.Derived.TextBasic txtPorCobrar;
        private System.Windows.Forms.Label label3;
        private BaseControls.Derived.TextBasic txtCambio;
        private System.Windows.Forms.Label label9;
        private BaseControls.Derived.ComboBasic cboFrecuencias;
        private System.Windows.Forms.Label label12;
        private BaseControls.Derived.ComboBasic cboLineasCredito;
        private System.Windows.Forms.Label label15;
        private BaseControls.Derived.TextBasic txtCreditoSaldo;
        private System.Windows.Forms.Label label14;
        private BaseControls.Derived.TextBasic txtCreditoMontoAplicar;
        private System.Windows.Forms.Label label13;
        private BaseControls.Derived.TextBasic txtCreditoCuotas;
        private System.Windows.Forms.Label label7;
        private BaseControls.Derived.ComboBasic cboTarjetas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private BaseControls.Derived.TextBasic txtTarjetaChequeDocumento;
        private BaseControls.Derived.ComboBasic cboBancos;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button delBtn;
    }
}