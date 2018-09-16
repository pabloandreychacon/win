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

namespace ControlApp.Presentation.Forms.Mantenimientos
{
    public partial class UsuariosForm : Maintenance
    {
        GeneralB userBl = new GeneralB();
        CommonB commB = new CommonB();

        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            try
            {
                var userListBind = commB.GetBindList<Usuario>();//.ToList();

                usuarioBindingSource.DataSource = userListBind;
                usuarioBindingNavigator.BindingSource = usuarioBindingSource;

                //if (userListBind.Count > 0)
                //{
                //    userBl.searchList = SearchMethods.SetProdSearchList(userListBind.ToList()); // prepara busqueda
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

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            usuarioBindingSource.EndEdit();

            var selectedUser = commB.SetEntity<Usuario>(usuarioBindingSource.Current);
            if (selectedUser != null) commB.UpdateEntity<Usuario>(selectedUser);
            usuarioBindingSource.ResetBindings(true);
        }

        public override bool ValidateFields()
        {
            return Validator(nombreTextBox, ValidationTypes.Text, "Debe digitar un nombre válido.") &&
                   (Validator(claveTextBox, ValidationTypes.Text, "Clave no válida."));
        }

        private void claveTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter)) return;
            e.KeyChar = (char)(Convert.ToByte(e.KeyChar) + 1);
        }
    }
}
