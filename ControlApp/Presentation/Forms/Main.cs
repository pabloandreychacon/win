using ControlBusiness.Business;
using BaseHelpers.Helpers;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ControlApp.Presentation.Forms
{
    public partial class Main : BaseForms.Forms.Mdi
    {
        GeneralB userBl = new GeneralB();

        public Main()
        {
            InitializeComponent();
        }

        private void Mdi_Load(object sender, EventArgs e)
        {            
            Text += " - " + Tools.UserCredentials.UserName.Trim();
            SetMenu();
            confirmarSalirToolStripMenuItem1.Checked = PromptOnExit;
        }  

        private void SetMenu()
        {
            var curUser = userBl.GetUsuarioById(Tools.UserCredentials.UserId);
            if (curUser.Any())
            {
                foreach (var usuarioActivo in curUser)
                {
                    if (usuarioActivo.Mantenimientos) mantenimientosToolStripMenuItem.Enabled = true;
                    if (usuarioActivo.Otros) otrosToolStripMenuItem.Enabled = true;
                    if (usuarioActivo.Procesos) procesosToolStripMenuItem.Enabled = true;
                    if (usuarioActivo.Reportes) reportesToolStripMenuItem.Enabled = true;
                    if (usuarioActivo.Consultas) consultasToolStripMenuItem.Enabled = true;
                    // algunos items deben ser solo para usuario tipo administrador
                    if (usuarioActivo.Administrador) configurarToolStripMenuItem.Enabled = true;
                }
            }
        }

        #region menu items click

        #region inventario
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProductosForm")) return;
            var formToShow = new Forms.Mantenimientos.ProductosForm { MdiParent = this };
            formToShow.Show();
        }
        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("UnidadesMedida")) return;
            var formToShow = new Forms.Mantenimientos.Inventario.UnidadesMedidaForm { MdiParent = this };
            formToShow.Show();
        }
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("Categorias")) return;
            var formToShow = new Forms.Mantenimientos.Inventario.CategoriasForms { MdiParent = this };
            formToShow.Show();
        }
        private void existenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ExistenciasConsulta")) return;
            var formToShow = new Forms.Consultas.ExistenciasConsulta { MdiParent = this };
            formToShow.Show();
        }
        private void ajustesInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("AjusteInventarioForm")) return;
            var formToShow = new Forms.Procesos.AjusteInventarioForm { MdiParent = this };
            formToShow.Show();
        }
        private void notasDebitoCreditoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("NotaDebitoCreditoForm")) return;
            var formToShow = new Forms.Procesos.NotaDebitoCreditoForm { MdiParent = this };
            formToShow.Show();
        }
        #endregion

        #region general
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("UsuariosForm")) return;
            var formToShow = new Forms.Mantenimientos.UsuariosForm { MdiParent = this };
            formToShow.Show();
        }
        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("BusinessConfig")) return;
            var formToShow = new Forms.Mantenimientos.BusinessConfig { MdiParent = this };
            formToShow.Show();
        }
        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ParametrosGenerales")) return;
            var formToShow = new Forms.Mantenimientos.General.ParametrosGenerales { MdiParent = this };
            formToShow.Show();
        }
        #endregion

        #region proveedores
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProveedoresForm")) return;
            var formToShow = new Forms.Mantenimientos.ProveedoresForm { MdiParent = this };
            formToShow.Show();
        }
        #endregion        

        #region ventas
        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("Cajas")) return;
            var formToShow = new Forms.Mantenimientos.CajasForm { MdiParent = this };
            formToShow.Show();
        }

        private void parametrosVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ParametrosVentas")) return;
            var formToShow = new Forms.Mantenimientos.Ventas.ParametrosVentas { MdiParent = this };
            formToShow.Show();
        }
        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("Ventas")) return;
            var formToShow = new Forms.Consultas.Ventas { MdiParent = this };
            formToShow.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("PuntoVenta")) return;
            var formToShow = new Forms.Procesos.PuntoVenta { MdiParent = this };
            formToShow.Show();
        }
        private void formasPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void anulacionFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("AnulacionFacturasForm")) return;
            var formToShow = new Forms.Procesos.AnulacionFacturasForm { MdiParent = this };
            formToShow.Show();
        }
        #endregion ventas

        #region credito
        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("Clientes")) return;
            var formToShow = new Forms.Mantenimientos.Credito.ClientesMant { MdiParent = this };
            formToShow.Show();
        }
        private void lineasCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("LineasCredito")) return;
            var formToShow = new Forms.Mantenimientos.Credito.LineasCredito { MdiParent = this };
            formToShow.Show();
        }
        private void frecuenciasPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("FrecuenciasPago")) return;
            var formToShow = new Forms.Mantenimientos.Credito.FrecuenciasPago { MdiParent = this };
            formToShow.Show();
        }
        #endregion

        #region bancos
        private void bancosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("BancosMantenimiento")) return;
            var formToShow = new Forms.Mantenimientos.Bancos.BancosMantenimiento { MdiParent = this };
            formToShow.Show();
        }

        private void tarjetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("TajetasMant")) return;
            var formToShow = new Forms.Mantenimientos.Bancos.TarjetasMant { MdiParent = this };
            formToShow.Show();
        }
        #endregion        

        #region sistema
        private void confirmarSalirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            confirmarSalirToolStripMenuItem1.Checked = !(confirmarSalirToolStripMenuItem1.Checked);
            PromptOnExit = confirmarSalirToolStripMenuItem1.Checked;
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\LunaSoftware\Control\", "PromptOnExit", PromptOnExit);
        }
               
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reiniciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            var Login = new Login();
            Login.Show();
        }
        #endregion

        #region reports
        private void ventasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("VentasReport")) return;
            var formToShow = new Forms.Reportes.Ventas.VentasReport { MdiParent = this };
            formToShow.Show();
        }
        #endregion

        #endregion click




    }
}
