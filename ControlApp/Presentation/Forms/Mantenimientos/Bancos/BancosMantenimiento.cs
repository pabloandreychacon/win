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

namespace ControlApp.Presentation.Forms.Mantenimientos.Bancos
{
    public partial class BancosMantenimiento : Maintenance
    {
        BancosB bankB = new BancosB();
        CommonB commB = new CommonB();

        public BancosMantenimiento()
        {
            InitializeComponent();
            var tarj = bankB.GetBancoTypeForBinding();
            bancosBindingSource.DataSource = tarj;
        }

        private void BancosMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                var linesList = commB.GetBindList<ControlEntity.Banco>();//.ToList();

                bancosBindingSource.DataSource = linesList;
                bancosBindingNavigator.BindingSource = bancosBindingSource;

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

        private void bancosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            bancosBindingSource.EndEdit();

            var selectedBanco = commB.SetEntity<ControlEntity.Banco>(bancosBindingSource.Current);
            if (selectedBanco != null) commB.UpdateEntity<ControlEntity.Banco>(selectedBanco);
            bancosBindingSource.ResetBindings(true);
        }

        public override bool ValidateFields()
        {
            return Validator(descripcionTextBox, ValidationTypes.Text,
                "Debe digitar una descripción válida.");
        }
    }
}
