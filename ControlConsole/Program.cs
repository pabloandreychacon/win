using ControlConsole.DependencyInjectionExample;
using ControlEntity.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using ControlEntity;
using BaseHelpers.Helpers;

namespace ControlConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTrans();
            Console.ReadLine();

            object mynumber = "1050.00";
            var dec = BaseHelpers.Helpers.Tools.NumericValidators.IsNumeric(mynumber);
            Console.Write(dec);
            Console.ReadLine();
            var round = new RoundTest();
            round.TestRound();

            decimal value = 0;
            decimal value2 = 0;
            decimal value3 = 0;
            value = 1324.249m;
            value2 = 1310.519m;
            value3 = 1370.234m;
            Console.WriteLine("Ninguno {0} = {1}", value, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Ninguno));

            Console.WriteLine("Centecimales {0} = {1}", value, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Centecimales));
            Console.WriteLine("Centecimales {0} = {1}", value2, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value2,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Centecimales));
            Console.WriteLine("Centecimales {0} = {1}", value3, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value3,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Centecimales));

            Console.WriteLine("Decimales {0} = {1}", value, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Decimales));
            Console.WriteLine("Decimales {0} = {1}", value2, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value2,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Decimales));
            Console.WriteLine("Decimales {0} = {1}", value3, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value3,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Decimales));

            Console.WriteLine("SinDecimales {0} = {1}", value, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.SinDecimales));
            Console.WriteLine("SinDecimales {0} = {1}", value2, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value2,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.SinDecimales));
            Console.WriteLine("SinDecimales {0} = {1}", value3, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value3,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.SinDecimales));

            Console.WriteLine("Unidades {0} = {1}", value, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Unidades));
            Console.WriteLine("Unidades {0} = {1}", value2, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value2,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Unidades));
            Console.WriteLine("Unidades {0} = {1}", value3, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value3,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Unidades));

            Console.WriteLine("Decenas {0} = {1}", value, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Decenas));
            Console.WriteLine("Decenas {0} = {1}", value2, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value2,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Decenas));
            Console.WriteLine("Decenas {0} = {1}", value3, BaseHelpers.Helpers.Tools.Redondeo.ApplyRound(value3,
                BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes.Decenas));
                        
            Console.ReadLine();

            var encodedPassword = BaseHelpers.Helpers.Tools.CodeDecode.Encode("1");
            Console.WriteLine("clave de 1: {0}", encodedPassword);
            // test generics
            bool b1 = true, b2 = false;
            Console.WriteLine("Before swap: {0}, {1}", b1, b2);
            GenericMethods.Swap<bool>(ref b1, ref b2);
            Console.WriteLine("After swap: {0}, {1}", b1, b2);

            ControlEntities db = new ControlEntities();
            var pl = db.Proveedores.ToList();

            //GenericMethods.GetSnapshot<ProveedoresDtos.ProvListSearch>(pl);

            GenericMethods.DisplayBaseClass<int>();
            GenericMethods.DisplayBaseClass<string>();
            // struct Point
            Point<int> p = new Point<int>(10, 10);
            // Point using double.
            Point<double> p2 = new Point<double>(5.4, 3.3);
            // class Coordenada
            Coordenada<int> c = new Coordenada<int>(10,10);
            // Coordenada using double.
            Coordenada<double> c2 = new Coordenada<double>(5.4, 3.3);

            byte[] array = new byte[] {1,2,3 };
            var xxx = reversed(array, array.Length);
            for (int i = 0; i < xxx.Length; i++)
            {
                Console.WriteLine(xxx[i]);
            }
            Console.ReadLine();
            // pasandolo como parametro en el constructor
            //InjectedRepository repoInjected = new InjectedRepository();
            //InjectedClaseFinal final = new InjectedClaseFinal(repoInjected);
            //final.getShit();
            // sin parametros, usa constructor por defecto, el cual enlaza con el repo
            InjectedClaseFinal finalSimple = new InjectedClaseFinal();
            finalSimple.getShit(); // llama al getShit de ClaseFinal que a su vez llama getShit de InjectedRepository     

            // se agrego entityframework y se hizo reference a ControlData
            // se creo un connectionstring
            var testc = new testLinq();
            var prods = testc.GetProdExistencias(4);

            foreach (var item in prods)
            {
                Console.WriteLine(item.Cantidad);
            }
            Console.ReadLine();
        }

        private static void DoTrans()
        {
            using (var context = new ControlEntities())
            {
                context.Database.Connection.Open();
                using (var dbcxtransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Categoria newCat = new Categoria()
                        {
                            Descripcion = "Tran Test"                            
                        };
                        context.Categorias.Add(newCat);
                        context.SaveChanges();
                        Bitacora newBitacora = new Bitacora()
                        {
                            //Descripcion = "TranTest"
                            //,Error = true
                            //,Fecha = DateTime.Now
                            //,IdUsuario = 1
                        };
                        context.Bitacoras.Add(newBitacora);
                        context.SaveChanges();
                        dbcxtransaction.Commit();
                        context.Database.Connection.Close();
                        Console.WriteLine("Data Saved Successfully. Transaction Commited");                        
                    }
                    catch
                    {                       
                        dbcxtransaction.Rollback();
                        context.Database.Connection.Close();
                        Console.WriteLine("Error Occured during data saved. Transaction Rolled Back");
                    }
                }
                Console.WriteLine("Categorias");
                var queryListCat = (from b in context.Categorias
                                    select b).ToList();
                foreach (var item in queryListCat)
                {
                    Console.WriteLine(item.Descripcion);
                }
                Console.WriteLine("Bitacoras");
                var queryList = (from b in context.Bitacoras
                                 select b).ToList();
                foreach (var item in queryList)
                {
                    Console.WriteLine(item.Descripcion + item.IdUsuario.ToString());
                }
                context.Database.Connection.Close();
            }
        }

        public static byte[] reversed(byte[] curArray, int size) {
            //int size = curArray.Length;
            byte[] temp = new byte[size];
            //byte[] temp;
            int x = 0;
            for (int i = curArray.Length-1; i >= 0; i--)
            {
                temp[x] = curArray[i];
                x++;
            }
            return temp;// temp;
        }
    }
    
    public class testLinq : IDisposable {
        ControlEntities db = new ControlEntities();
        public List<Existencia> GetExistencias() {
            return db.Existencias.ToList();
        }
        public IEnumerable<Existencia> GetProdExistencias(int prod)
        {
            var q = from e in GetExistencias()
                    where e.IdProducto == prod
                    select new Existencia { Cantidad = e.Cantidad };
            //return q.ToList(); // error
            return q;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }

    public class RoundTest
    {
        public void TestRound()
        {
            decimal result = 0.0m;
            decimal posValue = 322m;
            decimal negValue = -3.45m;

            // By default, round a positive and a negative value to the nearest even number. 
            // The precision of the result is 1 decimal place.

            result = Math.Round(posValue, 1);
            Console.WriteLine("{0,4} = Math.Round({1,5}, 1)", result, posValue);
            result = Math.Round(negValue, 1);
            Console.WriteLine("{0,4} = Math.Round({1,5}, 1)", result, negValue);
            Console.WriteLine();

            // Round a positive value to the nearest even number, then to the nearest number away from zero. 
            // The precision of the result is 1 decimal place.

            result = Math.Round(posValue, 1, MidpointRounding.ToEven);
            Console.WriteLine("{0,4} = Math.Round({1,5}, 1, MidpointRounding.ToEven)", result, posValue);
            result = Math.Round(posValue, 1, MidpointRounding.AwayFromZero);
            Console.WriteLine("{0,4} = Math.Round({1,5}, 1, MidpointRounding.AwayFromZero)", result, posValue);
            Console.WriteLine();

            // Round a negative value to the nearest even number, then to the nearest number away from zero. 
            // The precision of the result is 1 decimal place.

            result = Math.Round(negValue, 1, MidpointRounding.ToEven);
            Console.WriteLine("{0,4} = Math.Round({1,5}, 1, MidpointRounding.ToEven)", result, negValue);
            result = Math.Round(negValue, 1, MidpointRounding.AwayFromZero);
            Console.WriteLine("{0,4} = Math.Round({1,5}, 1, MidpointRounding.AwayFromZero)", result, negValue);
            Console.WriteLine();

        }

    }
}
