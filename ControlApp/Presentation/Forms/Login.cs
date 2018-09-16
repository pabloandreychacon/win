using ControlBusiness.Business;
using BaseHelpers.Helpers;
using BaseForms.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace ControlApp.Presentation.Forms
{
    public partial class Login : Basic
    {
        GeneralB userBl = new GeneralB();

        public Login()
        {
            InitializeComponent();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (Validator(txtUser, ValidationTypes.Text, "Debe digitar un usuario válid.") &&
                   (Validator(txtPass, ValidationTypes.Text, "Password no válido.")))
            {
                var encodedPassword = Tools.CodeDecode.Encode(txtPass.Text.Trim());
                var curUser = userBl.GetUsuario(txtUser.Text.Trim(), encodedPassword);
                if (curUser.Any())
                {
                    foreach (var UsuarioActivo in curUser)
                    {
                        if (UsuarioActivo.Activo == false)
                        {
                            MessageBox.Show("Usuario inactivo. Por favor verifique.");
                            return;
                        }
                        Tools.UserCredentials.UserName = txtUser.Text.Trim();
                        Tools.UserCredentials.UserId = UsuarioActivo.IdUsuario;
                        Tools.UserCredentials.IsAdmin = UsuarioActivo.Administrador;
                    }
                    Tools.FormManager.DestroyForm("Main");                    
//#if !DEBUG
                    userBl.SaveBitacora("Entrada al sistema Control",
                        false, Tools.UserCredentials.UserId);
//#endif
                    var main = new ControlApp.Presentation.Forms.Main();
                    main.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrectos. Por favor verifique.");
                    return;
                }
            }
            else
            {
                txtUser.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
#if DEBUG
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["User"])) txtUser.Text = ConfigurationManager.AppSettings["User"].ToString();
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["Password"])) txtPass.Text = ConfigurationManager.AppSettings["Password"].ToString();
#endif
        }
    }
}
