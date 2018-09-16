using ControlBusiness.Business;
using BaseForms.Forms;
using BaseHelpers.Helpers;
using ControlEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlApp.Presentation.Forms.Mantenimientos.Ventas
{
    public partial class ParametrosVentas : Maintenance
    {
        VentasB ventB = new VentasB();
        CommonB commB = new CommonB();
        public ParametrosVentas()
        {
            InitializeComponent();
        }

        private void ParametrosVentas_Load(object sender, EventArgs e)
        {
            try
            {
                var catListBind = commB.GetBindList<ParametrosVenta>();
                parametrosVentaBindingSource.DataSource = catListBind;
                parametrosVentaBindingNavigator.BindingSource = parametrosVentaBindingSource;
                //    if (prodListBind.Count > 0)
                //    {
                //        prodBl.searchList = GeneralDataAccess.SetProdSearchList(prodListBind.ToList()); // prepara busqueda
                //    }
                //    else
                //    {
                btnFind.Enabled = false;
                //    }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void parametrosVentaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            parametrosVentaBindingSource.EndEdit();
            var selectedParam = commB.SetEntity<ParametrosVenta>(parametrosVentaBindingSource.Current);
            if (selectedParam != null) commB.UpdateEntity<ParametrosVenta>(selectedParam);
            parametrosVentaBindingSource.ResetBindings(true);
        }

        public override bool ValidateFields()
        {
            return Validator(consecutivoGlobalFacturasTextBox, ValidationTypes.Text,
                "Debe digitar consecutivo válido.");
        }
    }
}
