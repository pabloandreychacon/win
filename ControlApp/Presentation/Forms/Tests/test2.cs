using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Entity.Core.Objects;
//using System.Data.Entity;

namespace BaseControls.User
{
    public partial class test2 : Form
    {
        ////List<Producto> productsList;
        int currentProductIndex = 0;

        public test2()
        {
            InitializeComponent();
        }

        private void test2_Load(object sender, EventArgs e)
        {
            ////using (var ctx = new ControlEntities())
            ////{
            ////    try
            ////    {
            ////        productsList = new List<Producto>();
            ////        var productosQuery = ctx.Productos.Where(p => p.Descripcion != string.Empty);
            ////        productsList = productosQuery.ToList();
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
            ////Producto currentProduct = productsList[currentProductIndex];
            ////txtCodigo.Text = currentProduct.Codigo;
            ////txtdescrip.Text = currentProduct.Descripcion;
            ////lblid.Text = currentProduct.IdProducto.ToString();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            currentProductIndex = 0;
            PopulateFields();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (currentProductIndex == 0)
            {
                MessageBox.Show("No previous product");
            }
            else
            {
                currentProductIndex -= 1;
                PopulateFields();
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //if (currentProductIndex == productsList.Count - 1)
            //{
            //    MessageBox.Show("No next author");
            //    PopulateFields();
            //}
            //else
            //{
            //    currentProductIndex += 1;
            //    PopulateFields();
            //}
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            ////currentProductIndex = productsList.Count - 1;
            ////PopulateFields();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //// primero update luego send to db
            //Producto currentProduct = productsList[currentProductIndex];
            //currentProduct.Codigo = txtCodigo.Text;
            //currentProduct.Descripcion = txtdescrip.Text;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ////// primero update luego send to db
            ////using (var ctx = new ControlEntities())
            ////{
            ////    try
            ////    {
            ////        Producto currentProduct = productsList[currentProductIndex];
            ////        ctx.Entry(currentProduct).State = currentProduct.IdProducto == -1 ?
            ////                       EntityState.Added :
            ////                       EntityState.Modified; 
            ////        int rowsAffected = ctx.SaveChanges();
            ////        MessageBox.Show(rowsAffected.ToString() + " changes made.");
            ////    }
            ////    catch (Exception ex)
            ////    {
            ////        MessageBox.Show(ex.Message);
            ////    }
                
            ////}
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clear, new, update
            txtdescrip.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            lblid.Text = "Not saved yet";
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            ////using (var ctx = new ControlEntities())
            ////{
            ////    try
            ////    {
            ////        Producto newProducto = new Producto();
            ////        newProducto.Codigo = txtCodigo.Text;
            ////        newProducto.Descripcion = txtdescrip.Text;
            ////        newProducto.IdProducto = -1; //To make it obvious that it's new
            ////        productsList.Add(newProducto);

            ////        //Productos selectedProducto = (Productos)cboProductos.SelectedItem;
            ////        //int selectedProductoID = selectedProducto.IdProducto;

            ////        //var existencia = new Existencias
            ////        //{
            ////        //    Existencia = Convert.ToInt16(existenciasUpDown.Value),
            ////        //    IdProducto = selectedProductoID
            ////        //};
            ////        //ctx.Existencias.Add(existencia);
            ////        //ctx.SaveChanges();

            ////        ctx.Productos.Add(newProducto);
            ////        //Set the index to the last, new item.
            ////        currentProductIndex = productsList.Count - 1;
            ////        PopulateFields();
            ////    }
            ////    catch (Exception ex)
            ////    {
            ////        MessageBox.Show(ex.Message);
            ////    }
            ////}
        }
    }
}