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
    public partial class LineasCredito : Maintenance
    {
        CreditoB creditB = new CreditoB();
        public LineasCredito()
        {
            InitializeComponent();
        }

        private void LineasCredito_Load(object sender, EventArgs e)
        {
            try
            {
                var linesList = creditB.GetBindLineas();//.ToList();

                lineasCreditoesBindingSource.DataSource = linesList;
                lineasCreditoesBindingNavigator.BindingSource = lineasCreditoesBindingSource;

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

        private void lineasCreditoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            lineasCreditoesBindingSource.EndEdit();

            var selectedLinea = creditB.SetLinea(lineasCreditoesBindingSource.Current);
            if (selectedLinea != null) creditB.UpdateLinea(selectedLinea);
            lineasCreditoesBindingSource.ResetBindings(true); 
        }

        public override bool ValidateFields()
        {
            return Validator(descripcionTextBox, ValidationTypes.Text,
                "Debe digitar una descripción válida.") && 
                Validator(plazoTextBox, ValidationTypes.Text,
                "Debe seleccionar un plazo.") &&
                Validator(tasaTextBox, ValidationTypes.Text,
                "Debe seleccionar una tasa de interes.") &&
                Validator(cuotasTextBox, ValidationTypes.Text,
                "Debe seleccionar una cantidad de cuotas.");
        }
    }
}
