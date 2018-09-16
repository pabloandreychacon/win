using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
////using ControlData;
////using ControlData.DataEntitiesModel;

namespace ControlControls.User
{
    public partial class test3StoredProc : Form
    {
        ////Proveedore currentProveedor;

        public test3StoredProc()
        {
            InitializeComponent();
        }

        private void test3StoredProc_Load(object sender, EventArgs e)
        {
            ////using (var ctx = new ControlEntities())
            ////{
            ////    try
            ////    {
                    
            ////        currentProveedor = new Proveedore();
            ////        //var proveedorQuery = ctx.GetProveedor(1);
            ////        //   //ctx.getArticle(1);
            ////        //currentProveedor = proveedorQuery.ToList().First();
            ////        PopulateFields();
            ////    }
            ////    catch (Exception ex)
            ////    {
            ////        MessageBox.Show(ex.Message);
            ////    }

            ////}
        }

        private void PopulateFields()
        {
            ////lblId.Text = currentProveedor.IdProveedor.ToString();
            ////txtDescripcion.Text = currentProveedor.Descripcion;
            ////txtTelefono.Text = currentProveedor.Telefono;
        }
    }
}
