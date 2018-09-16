using ControlBusiness.Business;
using ControlEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ControlTests
{
    [TestClass]
    public class UnitTest1
    {
        private ControlBusiness.Business.CommonB CreateProductosBL()
        {
            ControlEntities ctx = new ControlEntities();
            var mockControlRepository = new MockControlRepository(ctx);
            //  var inventBL = new InventarioB();
            //var inventBL = new InventarioB(mockControlRepository);
            var commB = new CommonB(mockControlRepository);
            commB.CreateEntity(new Producto()
            {
                IdProducto = 0,
                Codigo = "First Producto code",
                Descripcion = "Descrip 1",
                Proveedore = new Proveedore()
                {
                    IdProveedor = 0,
                    Descripcion = "Proveedor One",
                    Telefono = "Tel 1"
                }
            });
            commB.CreateEntity(new Producto()
            {
                IdProducto = 1,
                Codigo = "Second Producto code",
                Descripcion = "Descrip 2",
                Proveedore = new Proveedore()
                {
                    IdProveedor = 1,
                    Descripcion = "Proveedor 2",
                    Telefono = "Tel 2"
                }
            });
            commB.CreateEntity(new Producto()
            {
                IdProducto = 2,
                Codigo = "Third Producto code",
                Descripcion = "Descrip 3",
                Proveedore = new Proveedore()
                {
                    IdProveedor = 2,
                    Descripcion = "Proveedor 3",
                    Telefono = "Tel 3"
                }
            });
            return commB;
        }

        [TestMethod]
        public void SimpleProductsInsert() {
            // Arrange
            var controlProdBL = CreateProductosBL();
            // Act
            controlProdBL.CreateEntity(new Producto()
            {
                IdProducto = 34,
                Codigo = "4 Producto code",
                Descripcion = "Descrip 4",
                Proveedore = new Proveedore()
                {
                    IdProveedor = 1,
                    Descripcion = "Proveedor 2",
                    Telefono = "Tel 2"
                }
            });
            var myProd = (from p in controlProdBL.GetList<Producto>()
                         where p.IdProducto == 34
                         select p).First();
            // Assert
            Assert.AreEqual(myProd.IdProducto, 34);
            //controlProdBL.Dispose();
        }
        [TestMethod]
        [ExpectedException(typeof(DuplicateAdministratorException))]
        public void AdministratorAssignmentRestrictionOnInsert()
        {
            var controlProdBL = CreateProductosBL();
            controlProdBL.CreateEntity(new Producto()
            {
                IdProducto = 0,
                Codigo = "4 Producto code",
                Descripcion = "Descrip 4",
                Proveedore = new Proveedore()
                {
                    IdProveedor = 1,
                    Descripcion = "Proveedor 2",
                    Telefono = "Tel 2"
                }
            });
        }

        [TestMethod]
        [ExpectedException(typeof(DuplicateAdministratorException))]
        public void AdministratorAssignmentRestrictionOnUpdate()
        {
            var controlProdBL = CreateProductosBL();
            var origProducto = (from p in controlProdBL.GetList<Producto>() 
                                  where p.Descripcion == "Second Producto code"
                                  select p).First();

            var producto = (from d in controlProdBL.GetList<Producto>()
                              where d.Descripcion == "Second Producto code"
                              select d).First();
            producto.Codigo = "Descrip 2 cambiada";
            //controlProdBL.UpdateProducto(producto, origProducto);
            controlProdBL.UpdateEntity<Producto>(producto);
        }
    }
}
