using BaseHelpers.Helpers;
using BaseForms.Forms;
using ControlBusiness.Business;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlBusiness.BusinessHelpers;
using ControlEntity;

namespace ControlApp.Presentation.Forms.Mantenimientos
{
    public partial class CajasForm : Maintenance
    {
        VentasB ventB = new VentasB();
        GeneralB userB = new GeneralB();
        CommonB commB = new CommonB();
        public CajasForm()
        {
            InitializeComponent();
            var type = ventB.GetCajaTypeForBinding();
            cajaBindingSource.DataSource = type;
        }

        private void Cajas_Load(object sender, EventArgs e)
        {
            //var userB = new GeneralB(ventB.dbCtx);
            try
            {
                var cajListBind = commB.GetBindList<ControlEntity.Caja>();//.ToList();
                cajaBindingSource.DataSource = cajListBind;
                cajaBindingNavigator.BindingSource = cajaBindingSource;
            //    if (prodListBind.Count > 0)
            //    {
            //        prodBl.searchList = GeneralDataAccess.SetProdSearchList(prodListBind.ToList()); // prepara busqueda
            //    }
            //    else
            //    {
                    btnFind.Enabled = false;
            //    }
                var userList = commB.GetList<Usuario>();
                cboUsuarios.DataSource = userList;
                cboUsuarios.DisplayMember = "Nombre";
                cboUsuarios.ValueMember = "IdUsuario";
                cboUsuarios.DataBindings.Add("SelectedValue", cajaBindingSource, "IdUsuario", true);    
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void cajaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            cajaBindingSource.EndEdit();
            var selectedCaja = commB.SetEntity<ControlEntity.Caja>(cajaBindingSource.Current);
            try
            {
                if (selectedCaja != null) commB.UpdateEntity<ControlEntity.Caja>(selectedCaja);
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
            cajaBindingSource.ResetBindings(true); 
        }

        public override bool ValidateFields()
        {
            return Validator(descripcionTextBox, ValidationTypes.Text, "Debe digitar una descripción válida.") 
                && Validator(cboUsuarios, ValidationTypes.Text, "Debe seleccionar un usuario");
        }

        private void btnAddFormaPago_Click(object sender, EventArgs e)
        {
            var selectedCaja = commB.SetEntity<ControlEntity.Caja>(cajaBindingSource.Current);
            var formasPagoDisp = LocalData.GetFormasPagoDisponibles(selectedCaja.IdCaja);
            if (formasPagoDisp != null && formasPagoDisp.Count > 0)
            {
                var searchTable = formasPagoDisp.AsDataTable(); // transforma en dataTable
                var searchForm = new Choose(searchTable, "FormaPago", true);
                searchForm.ShowDialog();
                if (!string.IsNullOrEmpty(searchForm.StringSelectedKey))
                {
                    var curKey = searchForm.StringSelectedKey.ToString().Trim();
                    //if (curKey!=null)
                    ventB.InsertPagoCaja(curKey, Convert.ToInt16(idCajaTextBox.Text));
                }
                GetFormasPago();              
            }
            else
            {
                MessageBox.Show("No hay formas de pago sin asignar para la caja seleccionada");
            }
        }        

        private void btnDeleteFormaPago_Click(object sender, EventArgs e)
        {
            if (gridFormasPago.CurrentRow == null) return;
            var selectedKey = (string)gridFormasPago.CurrentRow.Cells["FormaPago"].Value;
            var idCaja = Convert.ToInt16(idCajaTextBox.Text);
            if (!string.IsNullOrEmpty(selectedKey) && idCaja != 0) ventB.DeleteFormaPago(selectedKey, idCaja);
            GetFormasPago();
        }

        private void cajaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            GetFormasPago();
        }

        private void GetFormasPago()
        {
            var selectedCaja = commB.SetEntity<ControlEntity.Caja>(cajaBindingSource.Current);
            var pagosCaja = LocalData.GetPagosCaja(selectedCaja.IdCaja);
            gridFormasPago.DataSource = pagosCaja;
        }
    }
}
