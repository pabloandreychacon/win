using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Entity;

namespace ControlControls.User
{
    public partial class tests : Form
    {
        ////Existencia currentExistencia;

        public tests()
        {
            InitializeComponent();
        }

        private void tests_Load(object sender, EventArgs e)
        {
            ////using(var ctx = new ControlEntities()){
            ////    try
            ////    {
            ////        ctx.Productos.Load();

            ////        ////var datos = from p in ControlCtx.Products select p;
            ////        //bSTable.DataSource = ControlCtx.Products.Local.ToBindingList();
            ////        ////bSTable.DataSource = datos;
            ////        //bNTable.BindingSource = bSTable;
            ////        cboProductos.DataSource = ctx.Productos.Local.ToBindingList();
            ////        cboProductos.DisplayMember = "Descripcion";


            ////        dgvProductos.DataSource = ctx.Productos.Local.ToBindingList();
            ////    }
            ////    catch (Exception ex)
            ////    {
            ////        MessageBox.Show(ex.Message);
            ////    }
                
            ////}
        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////using (var ctx = new ControlEntities())
            ////{
            ////    Producto selectedProducto = (Producto)cboProductos.SelectedItem;
            ////    int selectedProductoID = selectedProducto.IdProducto;

            ////    IQueryable<Existencia> existenciaQuery = from prod in ctx.Existencias
            ////                                              where prod.Producto.IdProducto == selectedProductoID
            ////                                              select prod;

            ////    List<Existencia> selectedExistencia = existenciaQuery.ToList();

            ////    if (selectedExistencia != null && selectedExistencia.Count > 0) {
            ////        currentExistencia = selectedExistencia.First();
            ////    }
            ////    else
            ////    {
            ////        currentExistencia = null;
            ////    }
            ////}

            PopulateFields();
        }

        private void PopulateFields()
        {
            ////if (currentExistencia != null)
            ////{
            ////    IdExistenciaLbl.Text = currentExistencia.IdProducto.ToString();
            ////    existenciasUpDown.Value = (decimal)currentExistencia.Cantidad;
            ////    addBtn.Enabled = false;
            ////    deleteBtn.Enabled = true;
            ////    updateBtn.Enabled = true;
            ////}
            ////else
            ////{
            ////    IdExistenciaLbl.Text = "No tiene existencias";
            ////    existenciasUpDown.Value = 0;
            ////    addBtn.Enabled = true;
            ////    deleteBtn.Enabled = false;
            ////    updateBtn.Enabled = false;
            ////}
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ////using (var ctx = new ControlEntities())
            ////{
            ////    try
            ////    {
            ////        Producto selectedProducto = (Producto)cboProductos.SelectedItem;
            ////        int selectedProductoID = selectedProducto.IdProducto;

            ////        var existencia = new Existencia { 
            ////            Cantidad = Convert.ToInt16(existenciasUpDown.Value),
            ////            IdProducto = selectedProductoID
            ////        };
            ////        ctx.Existencias.Add(existencia);
            ////        ctx.SaveChanges();

            ////        //Productos selectedProduct = (Productos)cboProductos.SelectedItem;

            ////        //var existencia = ctx.Existencias.Find(selectedProduct);

            ////        ////existencia.Productos..Posts.Add
                    
            ////        ////Existencias newExistencia = new Existencias { 
            ////        ////    Existencia = Convert.ToInt16(existenciasUpDown.Value) };
                    
            ////        //////newExistencia.Productos = selectedProduct;
            ////        //////newExistencia.Existencia = Convert.ToInt16(existenciasUpDown.Value);

            ////        ////ctx.Existencias.Add(newExistencia);

            ////        ////var blog = new Blog { Name = "ADO.NET Blog" };
            ////        ////context.Blogs.Add(blog);
            ////        ////context.SaveChanges();

            ////        ////ctx.Existencias.Add(newExistencia);
            ////        ////INSERT against database and get new PayrollID
            ////        ////ctx.Entry(newExistencia).State = EntityState.Added;
                    
                   
            ////    }
            ////    catch (Exception ex)
            ////    {
            ////        MessageBox.Show(ex.Message);
            ////    }
            ////}
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            ////using (var ctx = new ControlEntities())
            ////{
            ////    try
            ////    {
            ////        currentExistencia.Cantidad = Convert.ToInt16(existenciasUpDown.Value);
            ////        ctx.Entry(currentExistencia).State = EntityState.Modified;
            ////        int rowsAffected = ctx.SaveChanges();
            ////        MessageBox.Show(rowsAffected.ToString() +
            ////        " changes made to the table");
            ////    }
            ////    catch (Exception ex)
            ////    {

            ////        MessageBox.Show(ex.Message);
            ////    }


            ////}
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
        ////    using (var ctx = new ControlEntities())
        ////    {
        ////        try
        ////        {

                    

        ////            Producto selectedProducto = (Producto)cboProductos.SelectedItem;
        ////            int selectedProductoID = selectedProducto.IdProducto;

        ////            IQueryable<Existencia> existenciaQuery =
        ////                from prod in ctx.Existencias
        ////                where prod.Producto.IdProducto == selectedProductoID
        ////                select prod;

        ////            List<Existencia> selectedExistencia = existenciaQuery.ToList();

        ////            var query = (from p in ctx.Existencias
        ////                         where p.IdProducto == selectedProductoID
        ////                         select p).Single();

        ////            ctx.Existencias.Remove(query);

        ////            //if (selectedExistencia != null && selectedExistencia.Count > 0)
        ////            //{
        ////            //    currentExistencia = selectedExistencia.First();
        ////            //    ctx.Existencias.Remove(currentExistencia);
        ////            //    //ctx.DeleteObject(currentExistencia);
        ////            //    ctx.SaveChanges();
        ////            //    currentExistencia = null;
        ////            //    PopulateFields();
        ////            //}
        ////            ctx.SaveChanges();
        ////            currentExistencia = null;
        ////            PopulateFields();
        ////        }
        ////        catch (Exception ex)
        ////        {

        ////            MessageBox.Show(ex.Message);
        ////        }
        ////    }
        }

    }
}
