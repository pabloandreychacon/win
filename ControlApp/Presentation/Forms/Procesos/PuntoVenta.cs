using BaseHelpers.Helpers;
using ControlBusiness.Business;
using ControlBusiness.BusinessEntities;
using ControlEntity.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BaseForms.Forms;
using ControlBusiness.BusinessHelpers;

/// /// monedas solo hay una moneda por ahora, si es otra diferente a la local
/// entonces de existir el tipo de cambio para eldia de hoy
/// la moneda es una tabla general y la caja debe selecciorarla
/// formatoimpresion,por ahora solo hay uno pero pueden guardarse en una tabla
/// saldocaja esa tabla no existe todavia
/// bodegas todavia no hay inventario por bodega
/// listas de precios todavia no hay listas de precios, pero es buena idea
/// para que el usuario pueda escoger
namespace ControlApp.Presentation.Forms.Procesos
{
    public partial class PuntoVenta : Basic
    {
        /// <summary>
        /// fields
        /// </summary>
        int curCaja = 0;
        int curUser = BaseHelpers.Helpers.Tools.UserCredentials.UserId;
        bool autoSave = false;
        DetalleFactura detailRep = new DetalleFactura();
        DetallePagos pagosRep = new DetallePagos();
        CommonB commB = new CommonB();
        VentasB ventasB = new VentasB();
        InventarioB inventBL = new InventarioB();
        //InventarioB inventTran;
        GeneralB genBL = new GeneralB();
        CreditoB creditB = new CreditoB();

        /// <summary>
        /// properties
        /// </summary>
        public bool UsaConsecutivoGlobal { get; set; }
        public BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes Redondeo { get; set; }

        public PuntoVenta()
        {
            InitializeComponent();
        }

        #region form events
        private void PuntoVenta_Load(object sender, EventArgs e)
        {
            
            if (!CheckCaja())
            {
                DisableButtons();
                return;
            }
            var caja = ventasB.GetCajaById(curCaja);
            if (caja!=null)
            {
                autoSave = caja.GuardadoAutomatico;
            }
            if (!CheckClienteContado())
            {
                DisableButtons();
                return;
            }

            var redondeo = genBL.GetRedondeo();
            switch (redondeo)
            {
                case "Ninguno":
                    this.Redondeo = BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Ninguno;
                    break;
                case "Decimales":
                    this.Redondeo = BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Decimales;
                    break;
                case "Unidades":
                    this.Redondeo = BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Unidades;
                    break;
                default:
                    this.Redondeo = BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Ninguno;
                    break;
            }
            UsaConsecutivoGlobal = ventasB.UsaConsecutivoGlobal(curCaja);
            txtConsecutivo.Text = GetConsecutivo(false);
            txtVendedor.Text = BaseHelpers.Helpers.Tools.UserCredentials.UserName;
            // se ponen los eventos aqui para que solo se valide si todo lo anterior esta correcto
            this.txtCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtCliente_Validating);
            this.txtCliente.Validated += new System.EventHandler(this.txtCliente_Validated);
        }

        private void PuntoVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RealizaVenta();
            }
            if (e.KeyCode == Keys.F3)
            {
                this.btnBuscaProducto.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                this.btnBuscaCliente.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                this.btnPagar.PerformClick();
            }
            if (e.KeyCode == Keys.F6)
            {
                this.btnPrint.PerformClick();
            }
        }        

        private void PuntoVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseResources();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Busca clientes");
            try
            {
                List<CreditoDtos.ClienteListSearch> clientList = creditB.GetClientesSearch();
                if (clientList != null && clientList.Count() > 0)
                {
                    //DataTable searchTable = new DataTable();
                    var searchTable = clientList.AsDataTable(); // transforma en dataTable
                    var searchForm = new Search(searchTable, "Nombre", "Id");
                    searchForm.ShowDialog();
                    this.txtCliente.Text = searchForm.SelectedKey;
                    ValidateCLiente(txtCliente.Text.Trim());
                }
                else
                {
                    MessageBox.Show("No están definidos los clientes");
                    DisableButtons();
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtCodigoProducto.Text = "";
            }
        }    

        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var productsList = inventBL.GetProductoSearch();
                if (productsList != null && productsList.Count() > 0)
                {
                    //DataTable searchTable = new DataTable();
                    var searchTable = productsList.AsDataTable(); // transforma en dataTable
                    var searchForm = new Search(searchTable, "Codigo, Descripcion", "Codigo");
                    searchForm.ShowDialog();

                    this.txtCodigoProducto.Text = searchForm.SelectedKey;

                    this.txtCantidad.Focus(); // hace que se valide el position text
                }
                else
                {
                    MessageBox.Show("No están definidos los productos");
                    DisableButtons();
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtCodigoProducto.Text = "";
            }
        }

        private void txtCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (!ValidateCLiente(this.txtCliente.Text.Trim()))
            {
                e.Cancel = true;
                errorContainer1.errorProvider1.SetError(txtCliente, "Cliente incorrecto");
                txtCliente.Select(0, txtCliente.Text.Length);
                txtCliente.Focus();
            }
        }

        private void txtCliente_Validated(object sender, EventArgs e)
        {
            errorContainer1.errorProvider1.Clear();
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ValidateHeader())
                {
                    if (autoSave)
                    {
                        AddItemToCart(txtCodigoProducto.Text, 
                            Convert.ToDecimal(txtCantidad.Text));
                        txtCodigoProducto.Focus();
                    }
                    else
                    {
                        txtCantidad.Focus();
                    }
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ValidateHeader())
                {
                    AddItemToCart(txtCodigoProducto.Text, 
                        Convert.ToDecimal(txtCantidad.Text));
                    txtCodigoProducto.Focus();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string value = "0";
            if (BaseHelpers.Helpers.Tools.InputDialog.InputBox("Consecutivo", "#Factura:", ref value) == DialogResult.OK)
            {
                //validar input: debe ser numerico
                if (BaseHelpers.Helpers.Tools.NumericValidators.IsPositiveNumeric(value))
                {
                    var intConsecutivo = Convert.ToInt16(value);
                    if (ventasB.GetVentaByConsecutivo(intConsecutivo) != 0)
                    {
                        Tickets.GenerarTicket(ventasB.GetVentaByConsecutivo(intConsecutivo), intConsecutivo);
                    }
                    else
                    {
                        MessageBox.Show("Consecutivo no encontrado. Por favor verifique.");
                    }
                }
                else
                {
                    MessageBox.Show("Consecutivo no válido. Por favor verifique.");
                }
            }
        }

        private void gridDetalle_DoubleClick(object sender, EventArgs e)
        {
            DoAjuste();           
        }

        private void gridDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DoAjuste();
            }
        }
      
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (detailRep.CartLines.Count() > 0)
            {
                lblMensaje.Text = "";
                var total = Convert.ToDecimal(txtGrandTotal.Text);
                var PagosForm = new PagosForm(total, pagosRep, curCaja, txtCliente.Text.Trim());
                PagosForm.ShowDialog();
            }
            else
            {
                lblMensaje.Text = "No hay productos en la factura, por favor agregarlos";
            }
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            //verificar si no hay pagos
            RealizaVenta();
        }

        private void closeButton1_Click(object sender, EventArgs e)
        {
            CloseResources();
        }     

        #endregion form events

        #region mis methods

        private bool CheckClienteContado()
        {
            bool continuar = false;
            try
            {
                var cliente = creditB.GetClienteContado();
                if (cliente != null)
                {
                    txtCliente.Text = cliente.IdCliente.ToString();
                    txtClienteNombre.Text = cliente.Nombre;
                    txtClienteNombre.Enabled = true;
                    txtClienteNombre.ReadOnly = false;
                    txtCodigoProducto.Focus();
                    continuar = true;
                }
                else
                {
                    MessageBox.Show("No hay clientes para vender de contado.");
                    continuar = false;
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            return continuar;
        }

        private bool CheckCaja()
        {
            bool continuar = false;
            try
            {
                var caja = ventasB.GetIdCajaByUser(curUser);
                if (caja != 0)
                {
                    var formasList = LocalData.GetPagosCaja(caja);
                    if (formasList.Count == 0) {
                        MessageBox.Show("No están definidas las formas de pago para la caja # " + caja);
                        continuar = false;
                    }
                    else
                    {
                        curCaja = caja;
                        /// actualiza estado cajas
                        var affectedCajas = ventasB.UpdateStatusCaja(false, curCaja);
                        continuar = true;
                    }
                }
                else
                {
                    MessageBox.Show("La caja no está definida o no esta disponible");
                    continuar = false;
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            return continuar;
        }

        private void DisableButtons()
        {
            foreach (System.Windows.Forms.Control controlItem in Controls)
            {
                if (controlItem is TextBox) controlItem.Enabled = false;
            }
            btnBuscaCliente.Enabled = false;
            btnBuscaProducto.Enabled = false;
            okButton1.Enabled = false;
        }

        private void SetGridHeaders()
        {
            gridDetalle.Columns.Add("Producto", "Codigo");
            gridDetalle.Columns.Add("Descripcion", "Descripcion");
            gridDetalle.Columns.Add("Cant", "Cant");
            gridDetalle.Columns.Add("Prec", "Prec");
            gridDetalle.Columns.Add("Iva", "Iva");
            gridDetalle.Columns.Add("Desc", "Desc");
        }

        private string GetConsecutivo(bool updateConsecutivo)
        {
            var Consecutivo = "";
            if (UsaConsecutivoGlobal)
            {
                // traer el consecutivo global de la tabla de parametros ventas
                var ventasParams = ventasB.GetVentasParams();
                if (ventasParams != null)
                {
                    Consecutivo = ventasParams.ConsecutivoGlobalFacturas.ToString();
                }
                else
                {
                    MessageBox.Show("No está definido el consecutivo global de facturación");
                    DisableButtons();
                }
                if (updateConsecutivo)
                {
                    ventasB.UpdateConsecutivoGlobal();
                }
            }
            else
            {
                // traer el consecutivo de la caja
                var cajaParams = ventasB.GetCajaById(curCaja);
                if (cajaParams != null)
                {
                    Consecutivo = cajaParams.Consecutivo.ToString();
                }
                else
                {
                    MessageBox.Show("No esta definido el consecutivo de facturas en cajas");
                    DisableButtons();
                }
                if (updateConsecutivo)
                {
                    cajaParams.Consecutivo += 1;
                    commB.UpdateEntity<ControlEntity.Caja>(cajaParams);
                    // actualizar consecutivo tabla cajas
                }
            }
            return Consecutivo;
        }

        private void DisplayCartData()
        {
            lblMensaje.Text = "";
            decimal totalImpuestos = 0M;
            decimal totalFinal = 0M;
            decimal totaSub = 0M;
            decimal totalDescuentos = 0M;
            try
            {
                // leer del carrito, si hay datos
                if (detailRep.CartLines.Count() > 0)
                {
                    //gridDetalle.Rows.Clear();
                    var gridData = from d in detailRep.CartLines
                                   select new
                                   {
                                       Descripcion = d.Producto.Descripcion.PadRight(30, ' '),
                                       Cant = d.Cantidad,                                                                                                                     
                                       Prec = d.Producto.PrecioVenta,
                                       Iva = Math.Round(d.Cantidad * 
                                            (d.Producto.PrecioVenta * d.Producto.Impuestos / 100),2),
                                       Desc = d.MontoDescuento,
                                       Codigo = d.Producto.Codigo
                                   };
                    gridDetalle.DataSource = gridData.ToList();
                    foreach (var item in detailRep.CartLines)
                    {
                        totaSub += item.Cantidad * item.Producto.PrecioVenta;
                        totalImpuestos += item.Cantidad * 
                            (item.Producto.PrecioVenta * item.Producto.Impuestos / 100);
                        totalDescuentos += item.MontoDescuento;
                        totalFinal += (item.Cantidad * item.Producto.PrecioVenta) + 
                            (item.Cantidad * (item.Producto.PrecioVenta * item.Producto.Impuestos / 100)) - 
                            (item.MontoDescuento);
                    }
                }
                else
                {
                    gridDetalle.DataSource = null;
                }
                txtGrandTotal.Text = String.Format("{0}", BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(totalFinal, this.Redondeo));
                txtTotalImpuestos.Text = String.Format("{0}", BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(totalImpuestos, this.Redondeo));
                txtSubTotal.Text = String.Format("{0}", BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(totaSub, this.Redondeo));
                txtTotalDescuento.Text = String.Format("{0}", BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(totalDescuentos, this.Redondeo));
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void SetForm()
        {
            detailRep.Clear();
            pagosRep.Clear();
            gridDetalle.DataSource = null;
            if (!CheckClienteContado())
            {
                DisableButtons();
            }
            txtConsecutivo.Text = GetConsecutivo(false);
            txtSubTotal.Text = "0";
            txtTotalDescuento.Text = "0";
            txtTotalImpuestos.Text = "0";
            txtGrandTotal.Text = "0";
            lblMensaje.Text = "";
        }

        private void CloseResources()
        {
            if (curCaja != 0) ventasB.UpdateStatusCaja(true, curCaja);
        }

        private void AddItemToCart(string codigo, decimal cantidad)
        {
            var curProd = inventBL.GetProductoByCode(codigo);
            if (curProd != null)
            {
                decimal? precioVenta = curProd.PrecioVenta;
                try
                {
                    if (precioVenta == 0.0M)
                    {
                        lblMensaje.Text =
                            "El producto no tiene precio de venta!!!";
                    }
                    else
                    {
                        if (curProd.VerificaDisponible)
                        {
                            var existencia = inventBL.GetExistenciaByIdProducto(curProd.IdProducto);
                            if (existencia != null)
                            {
                                var yaSolicitado = detailRep.CartLines.Where(p => p.Producto.IdProducto == curProd.IdProducto).Sum(c => c.Cantidad);
                                if (existencia.Cantidad >= (cantidad + yaSolicitado))
                                {
                                    detailRep.AddItem(curProd, cantidad, Math.Round(cantidad *
                                        (curProd.PrecioVenta * curProd.Descuento / 100), 2));
                                }
                                else
                                {
                                    MessageBox.Show("No hay suficiente cantidad de producto en existencias!!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado en existencias!!!");
                            }
                        }
                        else
                        {
                            detailRep.AddItem(curProd, cantidad, Math.Round(cantidad *
                                (curProd.PrecioVenta * curProd.Descuento / 100), 2));
                        }
                        txtCodigoProducto.SelectAll();
                        txtCantidad.Text = "1";
                        txtCodigoProducto.Focus();
                        DisplayCartData();
                    }
                }
                catch (Exception ex)
                {
                    ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void RealizaVenta()
        {
            if (ValidateFields())
            {
                if (detailRep.CartLines.Count() != 0)
                {
                    if (pagosRep.PagosLines.Count() != 0)
                    {
                        if (pagosRep.ComputeTotalValueMontoAplicado() == Convert.ToDecimal(txtGrandTotal.Text.Trim()))
                        {
                            int consecutivo = SaveVenta();
                            if (consecutivo != 0)
                            {
                                PrintCurrentTicket(consecutivo);
                                SetForm();
                            }
                        }
                        else
                        {
                            //lblMensaje.Text = "Los pagos no corresponde con el total de la factura.";
                            btnPagar.PerformClick();
                            RealizaVenta();
                        }
                    }
                    else
                    {
                        btnPagar.PerformClick();
                        if (pagosRep.PagosLines.Count() != 0)
                        {
                            if (pagosRep.ComputeTotalValueMontoAplicado() == Convert.ToDecimal(txtGrandTotal.Text.Trim()))
                            {
                                RealizaVenta();
                            }
                        }
                        //lblMensaje.Text = "No se ha realizado el pago de la factura.";
                    }
                }
                else
                {
                    lblMensaje.Text = "No hay detalle de factura.";
                }
            }
        }

        private bool ValidateFields()
        {
            var continuar = true;
            /// hay cliente valido?
            if (!ValidateCLiente(txtCliente.Text.Trim())) continuar = false;
            return continuar;
        }

        private int SaveVenta()
        {
            var continuar = true;
            var consecutivo = 0;
            commB.BeginTran();
            try
            {
                var venta = new ControlEntity.Venta();
                venta.Estado = Enum.GetName(typeof(BaseHelpers.Helpers.Tools.EstatusDocumentosEnum.EstatusDocumentosTypes), 2);
                venta.Consecutivo = Convert.ToInt16(GetConsecutivo(true));
                consecutivo = venta.Consecutivo;
                venta.Fecha = DateTime.Now;
                venta.IdCaja = curCaja;
                venta.IdCliente = Convert.ToInt32(txtCliente.Text);
                venta.IdUsuario = curUser;
                // los textos de totales ya tienen el redondeo aplicado
                // por eso esta bien que los guarde desde ahi
                venta.TotalDescuentos = Convert.ToDecimal(string.IsNullOrEmpty(this.txtTotalDescuento.Text) ? "0" : this.txtTotalDescuento.Text);
                venta.TotalImpuestos = Convert.ToDecimal(string.IsNullOrEmpty(this.txtTotalImpuestos.Text) ? "0" : this.txtTotalImpuestos.Text);
                venta.TotalVenta = Convert.ToDecimal(this.txtGrandTotal.Text);
                // guarda detalle
                foreach (var item in detailRep.CartLines)
                {
                    var ventaDetalle = new ControlEntity.DetalleVenta();
                    ventaDetalle.Cantidad = item.Cantidad;
                    ventaDetalle.Descuento = item.MontoDescuento;
                    ventaDetalle.IdProducto = item.Producto.IdProducto;
                    ventaDetalle.Precio = item.Producto.PrecioVenta;
                    ventaDetalle.Impuestos = item.Cantidad *
                                            (item.Producto.PrecioVenta * item.Producto.Descuento / 100);
                    commB.AddEntity<ControlEntity.DetalleVenta>(ventaDetalle);
                    if (item.Producto.VerificaDisponible)
                    {
                        var existencia = inventBL.GetExistenciaByIdProducto(item.Producto.IdProducto);
                        if (existencia != null)
                        {
                            if (existencia.Cantidad >= item.Cantidad)
                            {
                                /// actualizar costo: get costo
                                existencia.Cantidad -= item.Cantidad;
                                //inventBL.UpdateExistenciaVentas(existencia, item.Cantidad); da error de que no ha insertado encabezado de factura
                            }
                            else
                            {
                                commB.Reload(existencia);
                                lblMensaje.Text = "El producto " + item.Producto.Descripcion +
                                    " no posee suficientes existencias para cumplir con la cantidad solicitada, por favor disminuya la cantidad solicitada";
                                continuar = false;
                                break;
                            }
                        }
                    }
                    /// insertar movimiento de inventario
                }
                commB.CreateEntity<ControlEntity.Venta>(venta);
                if (continuar)
                {
                    /// salvar pagos
                    foreach (var pago in pagosRep.PagosLines)
                    {
                        switch (pago.FormaPago)
                        {
                            case "Efectivo":
                                /// actualiza saldo caja efectivo
                                if (ventasB.UpdateSaldoCaja(curCaja, pago.MontoAplicado, 0) <= 0)
                                {
                                    continuar = false;
                                    break;
                                }
                                /// actualiza efectivo si recibido > aplicado
                                var cambio = pago.MontoPagado - pago.MontoAplicado;
                                if (pago.MontoPagado > pago.MontoAplicado)
                                {
                                    if (ventasB.UpdateSaldoCaja(curCaja, -(cambio), 0) <= 0)
                                    {
                                        continuar = false;
                                    }
                                }
                                break;
                            case "Tarjeta":
                            case "Cheque":
                                /// actualiza saldo caja documentos
                                if (ventasB.UpdateSaldoCaja(curCaja, 0, pago.MontoAplicado) <= 0)
                                {
                                    continuar = false;
                                }
                                /// actualiza efectivo si recibido > aplicado
                                var cambioDocumentos = pago.MontoPagado - pago.MontoAplicado;
                                if (pago.MontoPagado > pago.MontoAplicado)
                                {
                                    if (ventasB.UpdateSaldoCaja(curCaja, -(cambioDocumentos), 0) <= 0)
                                    {
                                        continuar = false;
                                    }
                                }
                                break;
                            case "Credito":
                                if (!ActualizaCxc(pago, consecutivo)) continuar = false;
                                break;
                            default:
                                break;
                        }
                        /// inserta en pagos documentos: hay que hacer la tabla                                
                        var newPago = new ControlEntity.Pago();
                        newPago.IdBanco = pago.Banco;
                        newPago.Estado = "Normal";
                        newPago.IdCaja = curCaja;
                        newPago.ConsecutivoVentas = consecutivo;
                        newPago.FormaPago = pago.FormaPago;
                        newPago.IdLinea = pago.Linea;
                        newPago.IdTarjeta = pago.Tarjeta;
                        newPago.MontoAplicado = pago.MontoAplicado;
                        newPago.MontoRecibido = pago.MontoPagado;
                        newPago.NumeroChequeTarjeta = pago.Documento;
                        /// save
                        ventasB.SavePago(newPago);
                    }
                }
                if (!continuar)
                {
                    commB.Rollback();
                    return 0;
                }
                commB.Commit();
                return (venta.Consecutivo);
            }
            catch (Exception ex)
            {
                commB.Rollback();
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return (0);
            }
        }   

        private bool ActualizaCxc(PagosLine line, int consecutivo)
        {
            bool credit = true;
            CreditoManager cred = new CreditoManager(Convert.ToInt16(txtCliente.Text.Trim()), 
                line.Linea, line.Frecuencias, line.Cuotas, line.MontoAplicado, 
                consecutivo);
            if (!cred.Crear()) 
            {
                MessageBox.Show(cred.message, "Credito", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                credit = false;
            }
            return credit;
        }

        private bool ValidateHeader()
        {
            lblMensaje.Text = "";
            var validated = false;
            try
            {
                if (!(string.IsNullOrEmpty(txtCodigoProducto.Text)) ||
                    (string.IsNullOrEmpty(txtCantidad.Text)))
                {
                    var curProd = inventBL.GetProductoByCode(txtCodigoProducto.Text.Trim());
                    if (BaseHelpers.Helpers.Tools.NumericValidators.IsPositiveNumeric(txtCantidad.Text))
                    {
                        var numericQuantity = Convert.ToDecimal(txtCantidad.Text.Trim());
                        if (curProd != null && numericQuantity > 0)
                        {
                            validated = true;
                        }
                        else
                        {
                            lblMensaje.Text = "Debe introducir una " +
                        "clave de producto y/o una cantidad válidos";
                            validated = true;
                        }
                    }
                    else
                    {
                        lblMensaje.Text = "La cantidad es incorrecta";
                        validated = false;
                    }
                }
                else
                {
                    lblMensaje.Text = "Debe introducir una " +
                        "clave de producto y/o una cantidad";
                    validated = false;
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            return validated;
        }

        private void DoAjuste()
        {
            try
            {
                if (gridDetalle.CurrentRow != null)
                {
                    var curCode = gridDetalle.CurrentRow.Cells["Codigo"].Value;
                    var selectedLine = (from p in detailRep.CartLines
                                        where p.Producto.Codigo == curCode.ToString()
                                        select p).FirstOrDefault();
                    if (selectedLine != null)
                    {
                        var ajusteForm = new AjusteLinea(selectedLine);
                        ajusteForm.ShowDialog();
                        var selectedProduct = (from p in detailRep.CartLines
                                               where p.Producto.Codigo == curCode.ToString()
                                               select p.Producto).FirstOrDefault();
                        if (ajusteForm.BorrarLinea)
                        {
                            /// delete from cart
                            detailRep.RemoveLine(selectedProduct);
                        }
                        /// no hay q actualizar el line porque ya lo hice en e form de ajuste
                        //else
                        //{
                        //    /// update cantidad y monto de descuento
                        //    var cantidadFinal = 0m;
                        //    //if (ajusteForm.cartLine.Cantidad < selectedLine.Cantidad)
                        //    //{
                        //    //    cantidadFinal = selectedLine.Cantidad - (selectedLine.Cantidad - ajusteForm.cartLine.Cantidad);
                        //    //}
                        //    //if (ajusteForm.cartLine.Cantidad > selectedLine.Cantidad) 
                        //    //{
                        //    //    cantidadFinal = selectedLine.Cantidad + (ajusteForm.cartLine.Cantidad - selectedLine.Cantidad);
                        //    //}
                        //    cartBL.AddItem(selectedProduct, cantidadFinal,
                        //        ajusteForm.cartLine.MontoDescuento);
                        //}
                        DisplayCartData();

                        this.txtCantidad.Focus(); // hace que se valide el position text
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private bool ValidateCLiente(string idCLiente)
        {
            if (!BaseHelpers.Helpers.Tools.NumericValidators.IsPositiveNumeric(idCLiente.Trim())) return false;
            var curCLiente = creditB.GetClienteById(Convert.ToInt16(idCLiente.Trim()));
            if (curCLiente != null)
            {
                txtClienteNombre.Enabled = curCLiente.Contado;
                txtClienteNombre.ReadOnly = !curCLiente.Contado;
                txtClienteNombre.Text = curCLiente.Nombre;

                if (curCLiente.Contado)
                {
                    this.txtClienteNombre.Focus();
                }
                else
                {
                    txtCodigoProducto.Focus();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PrintCurrentTicket(int consecutivo)
        {
            DialogResult _Resp = new DialogResult();
            _Resp = MessageBox.Show("¿Desea imprimir el comprobante?",
                "Comprobante", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (_Resp == DialogResult.Yes)
            {
                //Imprmmir el ticket
                Tickets.GenerarTicket(ventasB.GetVentaByConsecutivo(consecutivo), consecutivo, false);
                //this.Close();
            }
            else
            {
                //this.Close();
            }
        }

        #endregion mis methods            

    }
}
