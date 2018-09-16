using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BaseHelpers.Helpers;
using BaseForms.Forms;

namespace ControlApp.Presentation.Forms.Mantenimientos
{
    public partial class BusinessConfig : Basic
    {
        public BusinessConfig()
        {
            InitializeComponent();
        }

        private void BusinessConfig_Load(object sender, EventArgs e)
        {
            try
            {
                txtAddress.Text = ConfigurationManager.AppSettings["Direccion"];
                txtId.Text = ConfigurationManager.AppSettings["Cedula"];
                txtName.Text = ConfigurationManager.AppSettings["NombreNegocio"];
                txtPhone.Text = ConfigurationManager.AppSettings["Telefono"];
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //ControlBusiness.BusinessHelpers.Tools.DoError
            }
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config =
        ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //Borramos la configuración actual
            config.AppSettings.Settings.Remove("Direccion");
            config.AppSettings.Settings.Remove("Cedula");
            config.AppSettings.Settings.Remove("NombreNegocio");
            config.AppSettings.Settings.Remove("Telefono");
            config.Save(ConfigurationSaveMode.Modified);
            //Force a reload of the changed section.
            ConfigurationManager.RefreshSection("appSettings");
            //Grabamos la configuración nueva
            config.AppSettings.Settings.Add("Direccion", txtAddress.Text);
            config.AppSettings.Settings.Add("Cedula", txtId.Text);
            config.AppSettings.Settings.Add("NombreNegocio", txtName.Text);
            config.AppSettings.Settings.Add("Telefono", txtPhone.Text);
            // Save the configuration file.
            config.Save(ConfigurationSaveMode.Modified);
            //Force a reload of the changed section.
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("Datos guardados exitosamente.");
        }
    }
}
