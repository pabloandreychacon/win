using ControlBusiness.Business;
using BaseHelpers.Helpers;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ControlBusiness.BusinessHelpers;
using ControlBusiness.BusinessEntities;
using ControlEntity.DataTransferObjects;
using BaseForms.Forms;

namespace ControlApp.Presentation.Forms.Procesos
{
    public partial class PagosForm : Basic
    {
        decimal total = 0;
        DetallePagos curPagoRepo;
        int curCaja;
        string curCliente;
        VentasB ventB = new VentasB();
        CreditoB creditB = new CreditoB();
        BancosB bankB = new BancosB();
        CommonB commB = new CommonB();

        public PagosForm(decimal pTotal, DetallePagos pPagoRepo, int idCaja, string idCliente)
        {
            InitializeComponent();
            total = pTotal;
            curPagoRepo = pPagoRepo;
            curCaja = idCaja;
            curCliente = idCliente;
        }

        private void PagosForm_Load(object sender, EventArgs e)
        {
            MostrarTotales();
            CargarDetallePagos();
            CargarFormasPago();
            CargarLineas();
            CargarFrecuencias();
            CargarBancos();
            CargarTarjetas();
            SetForm();
        }

        private void SetForm()
        {
            closeButton1.TabStop = true;
            txtEfectivoMontoRecibido.Text = String.Format("{0:N2}", total - curPagoRepo.ComputeTotalValueMontoAplicado());
            txtEfectivoMontoAplicar.Text = String.Format("{0:N2}", total - curPagoRepo.ComputeTotalValueMontoAplicado());
            txtEfectivoMontoRecibido.Focus();
            tabCredito.Enabled = false;
            //cboFormasPago.SelectedItem = cboFormasPago.Items["Efectivo"];
            cboFormasPago.SelectedValue = "Efectivo";
            cboFormasPago.Enabled = (Convert.ToDecimal(txtPorCobrar.Text) > 0);
            saveBtn.Enabled = (Convert.ToDecimal(txtPorCobrar.Text) > 0);
            tabPagosData.Enabled = (Convert.ToDecimal(txtPorCobrar.Text) > 0);
        }

        private void CargarDetallePagos()
        {
            try
            {
                // leer del carrito, si hay datos
                if (curPagoRepo.PagosLines.Count() > 0)
                {
                    //gridDetalle.Rows.Clear();
                    var gridData = from d in curPagoRepo.PagosLines
                                   select new
                                   {
                                       FormaPago = d.FormaPago,
                                       Documento = d.Documento,                                                                              
                                       Recibido = d.MontoPagado,
                                       Aplicado = d.MontoAplicado,
                                       Banco = d.Banco,
                                       Tarjeta = d.Tarjeta,
                                       LineaCredito = d.Linea
                                   };
                    gridPagos.DataSource = gridData.ToList();
                }
                else
                {
                    gridPagos.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void MostrarTotales()
        {
            txtTotalPagar.Text = String.Format("{0}", total);
            txtTotalPagado.Text = String.Format("{0:N2}", curPagoRepo.ComputeTotalValueMontoAplicado());
            txtPorCobrar.Text = String.Format("{0:N2}", total - curPagoRepo.ComputeTotalValueMontoAplicado());
            txtCambio.Text = String.Format("{0:N2}",curPagoRepo.ComputeTotalValueMontoPagado() - 
                curPagoRepo.ComputeTotalValueMontoAplicado());
        }

        private void CargarFrecuencias()
        {
            var frecsList = commB.GetList<ControlEntity.FrecuenciasPago>();
            if (frecsList.Count() > 0)
            {
                cboFrecuencias.DataSource = frecsList;
                cboFrecuencias.DisplayMember = "Descripcion";
                cboFrecuencias.ValueMember = "IdFrecuenciaPago";
            }
            else
            {
                MessageBox.Show("No están definidas las frecuancias de pago para el crédito");
                cboFormasPago.Items.Remove("Credito");
                cboFrecuencias.Enabled = false;
            }
        }

        private void CargarTarjetas()
        {
            var tarjetasList = commB.GetList<ControlEntity.Tarjeta>();
            if (tarjetasList.Count() > 0)
            {
                cboTarjetas.DataSource = tarjetasList;
                cboTarjetas.DisplayMember = "Descripcion";
                cboTarjetas.ValueMember = "IdTarjeta";
            }
            else
            {
                MessageBox.Show("No estan definidas las tajetas en los bancos");
                cboFormasPago.Items.Remove("Tarjeta");
                cboTarjetas.Enabled = false;
            }
        }

        private void CargarBancos()
        {
            var bancosList = commB.GetList<ControlEntity.Banco>();
            if (bancosList.Count() > 0)
            {
                cboBancos.DataSource = bancosList;
                cboBancos.DisplayMember = "Descripcion";
                cboBancos.ValueMember = "IdBanco";
            }
            else
            {
                MessageBox.Show("No estan definidos los bancos");
                cboFormasPago.Items.Remove("Cheque");
                cboBancos.Enabled = false;
            }
        }

        private void CargarLineas()
        {
            var lineasList = creditB.GetLineas();
            if (lineasList.Count > 0)
            {
                cboLineasCredito.DataSource = lineasList;
                cboLineasCredito.DisplayMember = "Descripcion";
                cboLineasCredito.ValueMember = "IdLineaCredito";
            }
            else
            {
                MessageBox.Show("No estan definidas las lineas de credito");
                cboFormasPago.Items.Remove("Credito");
                cboLineasCredito.Enabled = false;
            }
        }

        private void CargarFormasPago()
        {
            var formasList = LocalData.GetPagosCaja(curCaja);

            var cliente = creditB.GetClienteById(Convert.ToInt16(curCliente));
            if (cliente != null)
            {
                if (cliente.Contado) 
                {
                    //var cred = ventB.GetNewPagosCaja();
                    //cred.FormaPago = "Credito";
                    formasList.RemoveAll(f=>f.FormaPago == "Credito");                    
                }
            }
            cboFormasPago.DataSource = formasList;
            cboFormasPago.DisplayMember = "FormaPago";
            cboFormasPago.ValueMember = "FormaPago";           
            //cboFormasPago.SelectedValue = "Efectivo";
        }

        private bool Validado()
        {
            var cred = LocalData.GetNewPagosCaja();
            bool validado = true;
            switch (((VentasDtos.PagosCaja)cboFormasPago.SelectedItem).FormaPago)
            {
                case "Credito":
                    /// verificar cliente credito
                    var cliente = creditB.GetClienteById(Convert.ToInt16(curCliente));
                    if (cliente != null)
                    {
                        if (cliente.Contado)
                        {
                            cboFormasPago.Focus();
                            errorContainer1.errorProvider1.SetError(cboFormasPago, "No se puede vender a crédito a este cliente");
                            validado = false;
                            break;
                        }
                    }
                    /// linea
                    if (string.IsNullOrEmpty(cboLineasCredito.SelectedValue.ToString()))
                    {
                        cboLineasCredito.Focus();
                        errorContainer1.errorProvider1.SetError(cboLineasCredito, "Debe seleccionar una Línea de crédito");                        
                        validado = false;
                        break;
                    }
                    /// frecuencia
                    if (string.IsNullOrEmpty(cboFrecuencias.SelectedValue.ToString()))
                    {
                        cboFrecuencias.Focus();
                        errorContainer1.errorProvider1.SetError(cboFrecuencias, "Debe seleccionar una frecuencia de pago");
                        validado = false;
                        break;
                    }
                    /// plazo  
                    if (string.IsNullOrEmpty(txtCreditoCuotas.Text))
                    {
                        cboFrecuencias.Focus();
                        errorContainer1.errorProvider1.SetError(cboFrecuencias, "Debe seleccionar una frecuencia de pago");
                        validado = false;
                        break;
                    }
                    break;
                case "Efectivo":
                case "Tarjeta":
                case "Cheque":
                    /// si monto recibido menor o igual a cero
                    if (string.IsNullOrEmpty(txtEfectivoMontoRecibido.Text) ||
                        Convert.ToDecimal(txtEfectivoMontoRecibido.Text)==0)
                    {
                        txtEfectivoMontoRecibido.Focus();
                        errorContainer1.errorProvider1.SetError(txtEfectivoMontoRecibido, "Debe digitar un monto Válido");
                        validado = false;
                        break;
                    }
                    /// si monto aplicado menor o igual a cero
                    if (string.IsNullOrEmpty(txtEfectivoMontoAplicar.Text) ||
                        Convert.ToDecimal(txtEfectivoMontoAplicar.Text) == 0)
                    {
                        txtEfectivoMontoAplicar.Focus();
                        errorContainer1.errorProvider1.SetError(txtEfectivoMontoAplicar, "Debe digitar un monto Válido");
                        validado = false;
                        break;
                    }
                    break;
                default:
                    validado = true;
                    break;
            }
            /// duplicados y otros
            switch (((VentasDtos.PagosCaja)cboFormasPago.SelectedItem).FormaPago)
            {
                case "Efectivo":
                    /// solo un pago en efectivo
                    var dupliList = (from p in curPagoRepo.PagosLines
                                     where p.FormaPago == "Efectivo"
                                     select p).Count();
                    if (dupliList > 0)
                    {
                        cboFormasPago.Focus();
                        errorContainer1.errorProvider1.SetError(cboFormasPago, "Solo puede haber un pago en efectivo");
                        validado = false;
                        break;
                    }
                    break;
                case "Tarjeta":
                    /// veficica documento
                    if (string.IsNullOrEmpty(txtTarjetaChequeDocumento.Text))
                    {
                        txtTarjetaChequeDocumento.Focus();
                        errorContainer1.errorProvider1.SetError(txtTarjetaChequeDocumento, "Debe digitar un Número de documento Válido");
                        validado = false;
                        break;
                    }
                    /// banco
                    if (string.IsNullOrEmpty(cboBancos.SelectedValue.ToString()))
                    {
                        cboBancos.Focus();
                        errorContainer1.errorProvider1.SetError(cboBancos, "Debe seleccionar una banco");
                        validado = false;
                        break;
                    }
                    /// tarjeta
                    if (string.IsNullOrEmpty(cboTarjetas.SelectedValue.ToString()))
                    {
                        cboTarjetas.Focus();
                        errorContainer1.errorProvider1.SetError(cboTarjetas, "Debe seleccionar una banco");
                        validado = false;
                        break;
                    }
                    /// solo un pago pr banco y tarjeta y documento
                    var dupliListTarj = (from p in curPagoRepo.PagosLines
                                         where p.FormaPago == "Tarjeta"
                                         && p.Banco == (int)cboBancos.SelectedValue
                                         && p.Tarjeta == (int)cboTarjetas.SelectedValue
                                         && p.Documento == txtTarjetaChequeDocumento.Text
                                         select p).Count();
                    if (dupliListTarj > 0)
                    {
                        txtTarjetaChequeDocumento.Focus();
                        errorContainer1.errorProvider1.SetError(txtTarjetaChequeDocumento, "Ya existe un pago con ese documento y banco y tarjeta");
                        validado = false;
                        break;
                    }
                    break;
                case "Cheque":
                    /// veficica documento
                    if (string.IsNullOrEmpty(txtTarjetaChequeDocumento.Text))
                    {
                        txtTarjetaChequeDocumento.Focus();
                        errorContainer1.errorProvider1.SetError(txtTarjetaChequeDocumento, "Debe digitar un Número de documento Válido");
                        validado = false;
                        break;
                    }
                    /// banco
                    if (string.IsNullOrEmpty(cboBancos.SelectedValue.ToString()))
                    {
                        cboBancos.Focus();
                        errorContainer1.errorProvider1.SetError(cboBancos, "Debe seleccionar una banco");
                        validado = false;
                        break;
                    }
                    /// solo un pago pr banco y documento
                    var dupliListCheq = (from p in curPagoRepo.PagosLines
                                         where p.FormaPago == "Cheque"
                                         && p.Banco == (int)cboBancos.SelectedValue
                                         && p.Documento == txtTarjetaChequeDocumento.Text
                                         select p).Count();
                    if (dupliListCheq > 0)
                    {
                        txtTarjetaChequeDocumento.Focus();
                        errorContainer1.errorProvider1.SetError(txtTarjetaChequeDocumento, "Ya existe un pago con ese documento y banco");
                        validado = false;
                        break;
                    }
                    break;
            }
            return validado;
        }

        private void cboFormasPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabPagosData.Enabled = (Convert.ToDecimal(txtPorCobrar.Text) > 0);
            saveBtn.Enabled = (Convert.ToDecimal(txtPorCobrar.Text) > 0);
            if (Convert.ToDecimal(txtPorCobrar.Text) > 0) 
            {
                try
                {
                    tabPagosData.Enabled = true;
                    tabEfectivo.Enabled =
                        (((VentasDtos.PagosCaja)cboFormasPago.SelectedItem).FormaPago ==
                        "Efectivo");
                    tabCredito.Enabled =
                        (((VentasDtos.PagosCaja)cboFormasPago.SelectedItem).FormaPago ==
                        "Credito");
                    switch (((VentasDtos.PagosCaja)cboFormasPago.SelectedItem).FormaPago)
                    {
                        case "Efectivo":
                        case "Tarjeta":
                        case "Cheque":
                            tabEfectivo.Enabled = true;
                            tabPagosData.SelectTab(tabEfectivo);
                            txtTarjetaChequeDocumento.Text = "";
                            txtEfectivoMontoRecibido.Text = String.Format("{0:N2}", total - curPagoRepo.ComputeTotalValueMontoAplicado());
                            txtEfectivoMontoAplicar.Text = String.Format("{0:N2}", total - curPagoRepo.ComputeTotalValueMontoAplicado());
                            tabEfectivo.Focus();
                            txtEfectivoMontoRecibido.Focus();
                            break;
                        case "Credito":
                            tabCredito.Enabled = true;
                            tabPagosData.SelectTab(tabCredito);
                            txtCreditoMontoAplicar.Text = String.Format("{0:N2}", total - curPagoRepo.ComputeTotalValueMontoAplicado());
                            txtCreditoCuotas.Text = "1";
                            txtCreditoSaldo.Text = DataAccess.GetSaldoCliente(Convert.ToInt16(curCliente)).ToString();
                            tabCredito.Focus();
                            cboLineasCredito.Focus();
                            break;
                    }
                    switch (((VentasDtos.PagosCaja)cboFormasPago.SelectedItem).FormaPago)
                    {
                        case "Efectivo":
                            cboTarjetas.Enabled = false;
                            cboBancos.Enabled = false;
                            txtTarjetaChequeDocumento.Enabled = false;
                            break;
                        case "Tarjeta":
                            cboTarjetas.Enabled = true;
                            cboBancos.Enabled = true;
                            txtTarjetaChequeDocumento.Enabled = true;
                            break;
                        case "Cheque":
                            cboTarjetas.Enabled = false;
                            cboBancos.Enabled = true;
                            txtTarjetaChequeDocumento.Enabled = true;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    cboFormasPago.Focus();
                }                
            }
        }

        private void txtEfectivoMontoRecibido_Validating(object sender, CancelEventArgs e)
        {
            bool validated = true;
            if (BaseHelpers.Helpers.Tools.NumericValidators.IsPositiveNumeric(txtEfectivoMontoRecibido.Text))
            {
                if (Convert.ToDecimal(txtEfectivoMontoAplicar.Text) == 0m ||
                    Convert.ToDecimal(txtEfectivoMontoAplicar.Text) >
                    Convert.ToDecimal(txtEfectivoMontoRecibido.Text))
                {
                    txtEfectivoMontoAplicar.Text =
                        (Convert.ToDecimal(txtEfectivoMontoRecibido.Text) > 
                        Convert.ToDecimal(txtPorCobrar.Text))
                        ? txtPorCobrar.Text
                        : String.Format("{0:N2}", txtEfectivoMontoRecibido.Text);
                }
                else
                {
                    txtEfectivoMontoAplicar.Text =
                        (Convert.ToDecimal(txtEfectivoMontoRecibido.Text) > 
                        Convert.ToDecimal(txtPorCobrar.Text))
                        ? txtPorCobrar.Text
                        : String.Format("{0:N2}", txtEfectivoMontoRecibido.Text);
                }
            }
            else
            {
                validated = false;
            }
            if (!validated)
            {
                e.Cancel = true;
                errorContainer1.errorProvider1.SetError(txtEfectivoMontoRecibido, "Monto recibido incorrecto");
                txtEfectivoMontoRecibido.Select(0, txtEfectivoMontoRecibido.Text.Length);
                txtEfectivoMontoRecibido.Focus();
            }            
        }

        private void txtEfectivoMontoRecibido_Validated(object sender, EventArgs e)
        {
            errorContainer1.errorProvider1.Clear();
        }

        private void txtEfectivoMontoAplicar_Validating(object sender, CancelEventArgs e)
        {
            bool validated = true;
            string message = "";
            if (BaseHelpers.Helpers.Tools.NumericValidators.IsPositiveNumeric(txtEfectivoMontoAplicar.Text))
            {
                if (Convert.ToDecimal(txtEfectivoMontoAplicar.Text) > 
                    Convert.ToDecimal(txtPorCobrar.Text))
                {
                    message = "El monto a aplicar no puede ser mayor al monto por cobrar";
                    validated = false;

                    txtEfectivoMontoAplicar.Text = (Convert.ToDecimal(txtEfectivoMontoRecibido.Text) <
                        Convert.ToDecimal(txtPorCobrar.Text))
                        ? String.Format("{0:N2}", Convert.ToDecimal(txtEfectivoMontoRecibido.Text))
                        : String.Format("{0:N2}", Convert.ToDecimal(txtPorCobrar.Text));
                }
                if (Convert.ToDecimal(txtEfectivoMontoAplicar.Text) >
                    Convert.ToDecimal(txtEfectivoMontoRecibido.Text))
                {
                    message = "El monto a aplicar no debe ser mayor al recibido";
                    validated = false;
                    txtEfectivoMontoAplicar.Text = String.Format("{0:N2}", Convert.ToDecimal(txtEfectivoMontoRecibido.Text));
                }
            }
            else
            {
                message = "El monto es incorrecto";
                validated = false;
            }
            if (!validated)
            {
                e.Cancel = true;
                txtEfectivoMontoAplicar.Select(0, txtEfectivoMontoAplicar.Text.Length);
                txtEfectivoMontoAplicar.Focus();
                errorContainer1.errorProvider1.SetError(txtEfectivoMontoAplicar, message);
            }   
        }

        private void txtCreditoMontoAplicar_Validating(object sender, CancelEventArgs e)
        {
            bool validated = true;
            string message = "";
            if (BaseHelpers.Helpers.Tools.NumericValidators.IsPositiveNumeric(txtCreditoMontoAplicar.Text))
            {
                if (Convert.ToDecimal(txtCreditoMontoAplicar.Text) > 
                    Convert.ToDecimal(txtPorCobrar.Text))
                {
                    message = "El monto a aplicar excede el saldo por cobrar en esta factura.";
                    validated = false;
                    txtCreditoMontoAplicar.Text = string.Format("{0:N2}", 
                        Convert.ToDecimal(txtPorCobrar.Text));
                }
                if (Convert.ToDecimal(txtCreditoMontoAplicar.Text) == 0)
                {
                    message = "El monto a aplicar no puede ser cero.";
                    validated = false;
                    txtCreditoMontoAplicar.Text = String.Format("{0:N2}", txtPorCobrar.Text);
                }
            }
            else
	        {
                validated = false;
                message = "El monto es incorrecto";
            }
            if (!validated)
            {
                e.Cancel = true;
                txtCreditoMontoAplicar.Select(0, txtCreditoMontoAplicar.Text.Length);
                txtCreditoMontoAplicar.Focus();
                errorContainer1.errorProvider1.SetError(txtCreditoMontoAplicar, message);
            }
        }

        private void txtCreditoCuotas_Validating(object sender, CancelEventArgs e)
        {
            bool validated = true;
            string message = "";
            if (BaseHelpers.Helpers.Tools.NumericValidators.IsPositiveNumeric(txtCreditoCuotas.Text))
            {
                if (Convert.ToDecimal(txtCreditoCuotas.Text) <= 0)
                {
                    message = "Las cuotas no pueder ser menores  o iguales a cero.";
                    validated = false;
                    txtCreditoCuotas.Text = string.Format("{0:N2}", 1);
                }
            }
            else
            {
                validated = false;
                message = "El número  de cuotas es incorrecto";
            }
            if (!validated)
            {
                e.Cancel = true;
                txtCreditoCuotas.Select(0, txtCreditoCuotas.Text.Length);
                txtCreditoCuotas.Focus();
                errorContainer1.errorProvider1.SetError(txtCreditoCuotas, message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validado())
                {
                    string fp = ((VentasDtos.PagosCaja)cboFormasPago.SelectedItem).FormaPago;
                    string doc = txtTarjetaChequeDocumento.Text;
                    int bco = (int)cboBancos.SelectedValue;
                    if (fp.Contains("Efectivo") || fp.Contains("Credito")) bco = 0;
                    int tar = (int)cboTarjetas.SelectedValue;
                    if (fp.Contains("Efectivo") || fp.Contains("Credito")
                         || fp.Contains("Cheque")) tar = 0;
                    decimal tot = Convert.ToDecimal(txtTotalPagar.Text);
                    decimal rec = Convert.ToDecimal(txtEfectivoMontoRecibido.Text);
                    decimal apl = Convert.ToDecimal(txtEfectivoMontoAplicar.Text);
                    decimal cam = Convert.ToDecimal(txtCambio.Text);
                    int lin = (int)cboLineasCredito.SelectedValue;
                    if (fp.Contains("Efectivo") || fp.Contains("Tarjeta")
                         || fp.Contains("Cheque")) lin = 0;
                    int fre = (int)cboFrecuencias.SelectedValue;
                    if (fp.Contains("Efectivo") || fp.Contains("Tarjeta")
                         || fp.Contains("Cheque")) fre = 0;
                    int cuo = (int)cboLineasCredito.SelectedValue;
                    if (fp.Contains("Efectivo") || fp.Contains("Tarjeta")
                         || fp.Contains("Cheque")) cuo = 0;

                    curPagoRepo.AddItem(fp, doc, bco, tar, tot, rec, apl, cam, lin, fre, cuo);
                    MostrarTotales();
                    CargarDetallePagos();
                    SetForm();
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                cboFormasPago.Focus();
            }      
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridPagos.CurrentRow != null)
                {
                    var curFormaPago = gridPagos.CurrentRow.Cells["FormaPago"].Value;
                    var selectedLine = (from p in curPagoRepo.PagosLines
                                        where p.FormaPago == curFormaPago.ToString()
                                        select p).FirstOrDefault();
                    if (selectedLine != null)
                    {
                        DialogResult _Resp = new DialogResult();
                        _Resp = MessageBox.Show("¿Desea borra el pago seleccionado?",
                            "Pagos", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (_Resp == DialogResult.Yes)
                        {
                            curPagoRepo.RemoveLine(selectedLine.FormaPago);
                            /// borrar pago seleccionado
                            CargarDetallePagos();
                            MostrarTotales();
                            SetForm();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                cboFormasPago.Focus();
            }
                
        }
    }
}
