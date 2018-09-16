using ControlBusiness.Business;
using System;

namespace ControlBusiness.BusinessHelpers
{
    public class CreditoManager
    {
        int cliente;
        decimal montoMaximoCliente;
        decimal saldoCliente;

        int linea;
        int cuotasLinea;
        decimal tasaLinea;
        int consecutivoLinea;
        int plazoMaximoLinea;
        decimal montoMaximoLinea;

        int frecuencia;
        int diasxyear;
        int diasxperiodo;
        int plazoPago;

        decimal montoCredito;
        decimal tasaFinalPeriodo;
        decimal interesFinalPeriodo;

        int factura;

        public string message= "";

        CreditoB creditB = new CreditoB();

        public CreditoManager(int idCliente, int idLinea, int idFrecuencia, int PlazoPago, 
            decimal montoAplicado, int numeroFactura)
        {
            cliente = idCliente;
            linea = idLinea;
            frecuencia = idFrecuencia;
            plazoPago = PlazoPago;
            montoCredito = montoAplicado;
            factura = numeroFactura;
        }

      

        public bool Crear() 
        { 
            bool creado = true;
            if (!ClienteCredito(cliente))
            {
                message = "Cliente no es Válido";
                creado = false;
                return creado;
            }
            if (!GetLinea(linea)) 
            {
                message = "Linea de credito no fue encontrada";
                creado = false;
                return creado;
            }
            if (!GetFrecuencia()) {
                message = "La frecuencia de pagos no fue encontrada";
                creado = false;
                return creado;
            }
            if (!ValidaNuevo())
            {                
                creado = false;
                return creado;
            }
            /// plan de pagos: a futuro
            /// guarda credito
            if (!GuardaCredito())
            {
                creado = false;
                return creado;
            }
            /// guarda plan pago: hay que crear esta tabla
            /// desembolso credito// tabla de transacciones cctransac, para futuro
            if (!ActualizaConsecutivoLinea()) 
            {
                message = "No fue posible actualizar el consecutivo de la Línea de crédito";
                creado = false;
                return creado;
            }
            return creado;
        }

        private bool GuardaCredito()
        {
            bool isValid = true;
            /// nueva variable credito
            var newCredit = creditB.GetNewCredito();
            try 
	        {	 
                /// flat
                tasaFinalPeriodo = Math.Round((tasaLinea/100/diasxyear)*diasxperiodo,2);
                if (tasaFinalPeriodo<=0 ) tasaFinalPeriodo = 0;
                interesFinalPeriodo = Math.Round(montoCredito * tasaFinalPeriodo * (diasxyear/diasxperiodo),2);
                
		        newCredit.IdCliente = cliente;
                newCredit.IdLinea = linea;
                newCredit.Descripcion = "Credito desde facturacion";
                newCredit.Tasa = tasaLinea; /// ok
                if (tasaFinalPeriodo<=0) 
                {
                    newCredit.Cuota = Math.Round(montoCredito / plazoPago, 2) ;
                }
                else
	            {
                    /// #4:flat en creditos::planpagos:getcuota y getplazo
                    newCredit.Cuota = Math.Round((montoCredito / plazoPago) + interesFinalPeriodo, 2);
                }
                newCredit.Plazo = plazoPago;
                newCredit.MontoInicial = montoCredito;
                newCredit.SaldoActual = montoCredito;
                newCredit.FechaCreacion = DateTime.Now;
                newCredit.FechaInicio = DateTime.Now;
                newCredit.FechaFinal = DateTime.Now.AddDays(diasxperiodo*plazoPago); /// planpago:getfechafina
                newCredit.FechaProximoPago = DateTime.Now.AddDays(diasxperiodo*1); /// debe ser la fecha final del primer plan de pago
                newCredit.FechaUltimoPago = null;
                newCredit.FechaUltimoAbono = null;
                newCredit.IdUsuario = BaseHelpers.Helpers.Tools.UserCredentials.UserId;
                newCredit.Consecutivo = consecutivoLinea;
                newCredit.Referencia = factura;
                newCredit.Estado = "Normal";
                var saved = creditB.SaveNewCredito(newCredit);
                if (saved<=0) isValid = false;
                    return isValid;
	        }
	        catch (Exception ex)
	        {
                message = ex.Message;
                return false;
	        }
        }
        
        private bool ActualizaConsecutivoLinea()
        {
            bool actualizo = false;
            if (creditB.UpdateConsecutivoLineaById(linea) > 0) actualizo = true;
            return actualizo;
        }

        private bool ValidaNuevo()
        {
            bool isValid = true;
            var diasCred = diasxperiodo * plazoPago;
            if (plazoMaximoLinea > 0 && plazoMaximoLinea > diasCred) {
                isValid = false;
                message = "El plazo en dias del credito es mayor al plazo maximo en dias establecido en la linea de credito";
                return isValid;
            }
            if (montoMaximoCliente > 0 && (montoCredito + saldoCliente) > montoMaximoCliente)
            {
                isValid = false;
                message = "El monto maximo de los créditos del cliente no debe exceder " + 
                    montoMaximoCliente.ToString();
                return isValid;
            }
            if (montoMaximoLinea > 0 && (montoCredito + saldoCliente) > montoMaximoLinea)
            {
                isValid = false;
                message = "El monto de los créditos del cliente: " + (montoCredito + saldoCliente).ToString() +
                    " excede el monto maximo de la linea de credito: " + montoMaximoLinea.ToString() +
                    " El monto maximo para el credito es de " + (montoMaximoLinea - saldoCliente).ToString();                    
                return isValid;
            }
            return isValid;
        }

        private bool GetFrecuencia()
        {
            bool found = true;
            var curFrec = creditB.GetFrecuenciaById(frecuencia);
            if (curFrec != null)
            {
                diasxperiodo = curFrec.DiasPorPeriodo;
                diasxyear = curFrec.DiasPorYear;
                found = true;
            }
            else
            {
                found = false;
            }
            return found;
        }

        private bool GetLinea(int linea)
        {
            bool found = true;
            var curLinea = creditB.GetLineaById(linea);
            if (curLinea != null)
            {
                cuotasLinea = curLinea.Cuotas;
                tasaLinea = curLinea.Tasa;
                consecutivoLinea = curLinea.Consecutivo;
                plazoMaximoLinea = curLinea.PlazoMaximo;
                montoMaximoLinea = curLinea.MontoMaximo;
                if (curLinea.Refunde) 
                { 
                    /// a futuro :D
                }
                found = true;
            }
            else
            {
                found = false;
            }
            return found;
        }

        private bool ClienteCredito(int cliente)
        {
            bool isCredit = true;
            var curCLiente = creditB.GetClienteById(cliente);
            if (curCLiente != null)
            {
                montoMaximoCliente = curCLiente.MontoMaximo;
                saldoCliente = DataAccess.GetSaldoCliente(cliente);
                if (curCLiente.Contado) isCredit = false;
            }
            return isCredit;
        }
    }
}
