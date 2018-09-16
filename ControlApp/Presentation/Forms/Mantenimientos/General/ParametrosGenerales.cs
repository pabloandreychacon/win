using ControlBusiness.Business;
using ControlBusiness.BusinessHelpers;
using BaseForms.Forms;
using System;
using System.Windows.Forms;

namespace ControlApp.Presentation.Forms.Mantenimientos.General
{
    public partial class ParametrosGenerales : Maintenance
    {
        GeneralB genB = new GeneralB();
        CommonB commB = new CommonB();

        public ParametrosGenerales()
        {
            InitializeComponent();
        }

        private void ParametrosGenerales_Load(object sender, EventArgs e)
        {
            try
            {
                var catListBind = commB.GetBindList<ControlEntity.ParametrosGeneral>();
                parametrosGeneralBindingSource.DataSource = catListBind;
                parametrosGeneralBindingNavigator.BindingSource = parametrosGeneralBindingSource;
                btnFind.Enabled = false;
                var redList = LocalData.GetRedondeoList();
                redondeoComboBox.DataSource = redList;
                redondeoComboBox.DisplayMember = "Redondeo";
                redondeoComboBox.ValueMember = "Redondeo";
                redondeoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "Redondeo", true));
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void parametrosGeneralBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            parametrosGeneralBindingSource.EndEdit();
            var selectedPar = commB.SetEntity<ControlEntity.ParametrosGeneral>(parametrosGeneralBindingSource.Current);
            if (selectedPar != null) commB.UpdateEntity<ControlEntity.ParametrosGeneral>(selectedPar);
            parametrosGeneralBindingSource.ResetBindings(true);
        }

        public override bool ValidateFields()
        {
            return Validator(redondeoComboBox, ValidationTypes.Text,
                "Debe digitar un redondeo válido.");
        }


    }
}
