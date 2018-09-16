using BaseHelpers.Helpers;
using ControlBusiness.Business;
using System;
using System.Windows.Forms;
using BaseForms.Forms;
using ControlEntity;

namespace ControlApp.Presentation.Forms.Mantenimientos.Bancos
{
    public partial class TarjetasMant : Maintenance
    {
        BancosB bankB = new BancosB();
        CommonB commB = new CommonB();

        public TarjetasMant()
        {
            InitializeComponent();
            var type = bankB.GetTarjetaTypeForBinding();
            tarjetasBindingSource.DataSource = type;
        }

        private void TarjetasMant_Load(object sender, EventArgs e)
        {            
            try
            {
                var linesList = commB.GetBindList<ControlEntity.Tarjeta>();//.ToList();

                tarjetasBindingSource.DataSource = linesList;
                tarjetasBindingNavigator.BindingSource = tarjetasBindingSource;

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

        private void tarjetasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            tarjetasBindingSource.EndEdit();
            var selectedTarjeta = commB.SetEntity<ControlEntity.Tarjeta>(tarjetasBindingSource.Current);
            if (selectedTarjeta != null) commB.UpdateEntity<Tarjeta>(selectedTarjeta);
            tarjetasBindingSource.ResetBindings(true);
        }

        public override bool ValidateFields()
        {
            return Validator(descripcionTextBox, ValidationTypes.Text,
                "Debe digitar una descripción válida.");
        }
    }
}
