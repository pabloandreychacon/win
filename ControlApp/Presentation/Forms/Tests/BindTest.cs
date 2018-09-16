using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Entity;
////using ControlData.DataEntitiesModel;

namespace ControlApp.Presentation.Forms
{
    public partial class BindTest : Form
    {
        ////ControlEntities db;

        public BindTest()
        {
            InitializeComponent();
        }

        private void BindTest_Load(object sender, EventArgs e)
        {
            try
            {
                ////db = new ControlEntities();
                ////////var query = db.Proveedores.Where(d => d.Productos.Any());
                ////////proveedorBindingSource.DataSource = query.ToList();

                ////////productosBindingSource.DataSource = query.ToList();
                ////////productosBindingSource.DataMember = "Descripcion";
                ////////productosDataGridView.DataSource = productosBindingSource;
                //////productoBindingSource.DataSource = query.ToList();

                //////productoDataGridView.DataSource = query.ToList();
                ////db.Proveedores.Where(d => d.Productos.Any()).OrderBy(p => p.IdProveedor).Load();
                ////proveedorBindingSource.DataSource = db.Proveedores.Local.ToBindingList();
                //////db.Productos.Load();
                ////////productosBindingSource.DataSource = db.Productos.Local.ToBindingList();
                //////////productosBindingSource.DataMember = "Descripcion";
                ////////productosDataGridView.DataSource = productosBindingSource;
                //////productosDataGridView.DataMember = "Descripcion";
                //////db.Proveedores.Include("Productos").Load();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        private void proveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //    //Business.ControlBL x = new ControlBL();
            //    //x.UpdateProducto(currentProduct, currentProduct);
            //db.SaveChanges();
        }

        private void proveedorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            ////db.SaveChanges();
        }

        private void proveedorBindingSource_PositionChanged(object sender, EventArgs e)
        {
            ////var cur = (Proveedore)proveedorBindingSource.Current;
            //////var queryList = db.Productos.Where(p => p.IdProveedor == cur.IdProveedor).ToList();
            ////var queryList = (from p in db.Productos
            ////                where p.IdProveedor == cur.IdProveedor
            ////                select new {p.Descripcion, p.Codigo}).ToList();
            ////productosBindingSource.DataSource = queryList;
            ////productosDataGridView.DataSource = productosBindingSource;
        }

        private void BindTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
