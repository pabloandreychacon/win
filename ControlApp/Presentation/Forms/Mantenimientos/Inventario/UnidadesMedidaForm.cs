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

namespace ControlApp.Presentation.Forms.Mantenimientos.Inventario
{
    public partial class UnidadesMedidaForm : Maintenance
    {
        InventarioB inventB = new InventarioB();
        CommonB commB = new CommonB();

        public UnidadesMedidaForm()
        {
            InitializeComponent();
        }

        private void UnidadesMedida_Load(object sender, EventArgs e)
        {
            try
            {
                var cajListBind = commB.GetBindList<ControlEntity.UnidadesMedida>();
                unidadesMedidaBindingSource.DataSource = cajListBind;
                unidadesMedidaBindingNavigator.BindingSource = unidadesMedidaBindingSource;
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

        private void unidadesMedidaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            unidadesMedidaBindingSource.EndEdit();
            var selectedUni = commB.SetEntity<UnidadesMedidaForm>(unidadesMedidaBindingSource.Current);
            if (selectedUni != null) commB.UpdateEntity<UnidadesMedidaForm>(selectedUni);
            unidadesMedidaBindingSource.ResetBindings(true); 
        }

        public override bool ValidateFields()
        {
            return Validator(descripcionTextBox, ValidationTypes.Text, "Debe digitar una descripción válida.")
                && Validator(nombreCortoTextBox, ValidationTypes.Text, "Debe digitar un nombre corto válido.");
        }
    }
}
