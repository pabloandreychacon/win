using ControlBusiness.Business;
using BaseForms.Forms;
using BaseHelpers.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlApp.Presentation.Forms.Mantenimientos.Credito
{
    public partial class FrecuenciasPago : Maintenance
    {
        CreditoB creditB = new CreditoB();
        CommonB commB = new CommonB();

        public FrecuenciasPago()
        {
            InitializeComponent();
        }

        private void FrecuenciasPago_Load(object sender, EventArgs e)
        {
            try
            {
                var linesList = commB.GetBindList<ControlEntity.FrecuenciasPago>();//.ToList();

                frecuenciasPagoesBindingSource.DataSource = linesList;
                frecuenciasPagoesBindingNavigator.BindingSource = frecuenciasPagoesBindingSource;

                //if (linesList.Count > 0)
                //{
                //    GeneralDataAccess.searchClientesList = GeneralDataAccess.SetClienteSearchList(linesList.ToList()); // prepara busqueda
                //}
                //else
                //{
                btnFind.Enabled = false;
                //}
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void frecuenciasPagoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            frecuenciasPagoesBindingSource.EndEdit();

            var selectedFrec = commB.SetEntity<ControlEntity.FrecuenciasPago>(frecuenciasPagoesBindingSource.Current);
            if (selectedFrec != null) commB.UpdateEntity<ControlEntity.FrecuenciasPago>(selectedFrec);
            frecuenciasPagoesBindingSource.ResetBindings(true);
        }

        public override bool ValidateFields()
        {
            return Validator(descripcionTextBox, ValidationTypes.Text,
                "Debe digitar una descripción válida.");
        }
    }
}
