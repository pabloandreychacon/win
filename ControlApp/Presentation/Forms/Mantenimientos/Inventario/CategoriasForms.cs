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

namespace ControlApp.Presentation.Forms.Mantenimientos.Inventario
{
    public partial class CategoriasForms : Maintenance
    {
        InventarioB InventB = new InventarioB();
        CommonB commB = new CommonB();

        public CategoriasForms()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            try
            {
                var catListBind = commB.GetBindList<Categoria>();
                categoriaBindingSource.DataSource = catListBind;
                categoriaBindingNavigator.BindingSource = categoriaBindingSource;

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

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            categoriaBindingSource.EndEdit();
            var selectedCat = commB.SetEntity<Categoria>(categoriaBindingSource.Current);
            if (selectedCat != null) commB.UpdateEntity<Categoria>(selectedCat);
            categoriaBindingSource.ResetBindings(true);
        }

        public override bool ValidateFields()
        {
            return Validator(descripcionTextBox, ValidationTypes.Text, 
                "Debe digitar una descripción válida.");
        }
    }
}
