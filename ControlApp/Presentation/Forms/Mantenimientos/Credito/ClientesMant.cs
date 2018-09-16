using ControlBusiness.Business;
using BaseForms.Forms;
using BaseHelpers.Helpers;
using ControlEntity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ControlApp.Presentation.Forms.Mantenimientos.Credito
{
    public partial class ClientesMant : Maintenance
    {
        CreditoB credB = new CreditoB();
        CommonB commB = new CommonB();

        public ClientesMant()
        {
            InitializeComponent();
        }

        private void ClientesMant_Load(object sender, EventArgs e)
        {
            try
            {
                var clieList = commB.GetBindList<Cliente>();//.ToList();
                clienteBindingSource.DataSource = clieList;
                clienteBindingNavigator.BindingSource = clienteBindingSource;
                if (clieList.Count > 0)
                {
                    ControlBusiness.BusinessHelpers.LocalData.searchClientesList = 
                        credB.SetClienteSearchList(clieList.ToList()); // prepara busqueda
                }
                else
                {
                    btnFind.Enabled = false;
                }
                var frecList = commB.GetList<ControlEntity.FrecuenciasPago>();
                idFrecuenciaPagoComboBox.DataSource = frecList;
                idFrecuenciaPagoComboBox.DisplayMember = "Descripcion";
                idFrecuenciaPagoComboBox.ValueMember = "IdFrecuenciaPago";
                idFrecuenciaPagoComboBox.DataBindings.Add("SelectedValue", clienteBindingSource, "IdFrecuenciaPago", true);
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            clienteBindingSource.EndEdit();
            var selectedCliente = commB.SetEntity<Cliente>(clienteBindingSource.Current);
            if (selectedCliente != null) commB.UpdateEntity<Cliente>(selectedCliente);
            clienteBindingSource.ResetBindings(true); 
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (ControlBusiness.BusinessHelpers.LocalData.searchClientesList != null && ControlBusiness.BusinessHelpers.LocalData.searchClientesList.Count > 0)
            {
                var searchTable = ControlBusiness.BusinessHelpers.LocalData.searchClientesList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, OrderKeys, "Id");
                searchForm.ShowDialog();
                this.bindingNavigatorPositionItem.Text = searchForm.SelectedKey;
                this.bindingNavigatorPositionItem.Focus();
                this.btnFind.Focus();
            }
        }

        public override bool ValidateFields()
        {
            return Validator(nombreTextBox, ValidationTypes.Text,
                "Debe digitar un nombre válido.") && 
                Validator(idFrecuenciaPagoComboBox, ValidationTypes.Text, 
                "Debe seleccionar una frecuencia de pago");
        }
    }
}
