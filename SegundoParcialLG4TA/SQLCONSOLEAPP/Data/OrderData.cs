using SegundoParcialLG4TA.Menu;
using SQLCONSOLEAPP.Menu;
using SQLCONSOLEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCONSOLEAPP.Data
{
    public class OrderData
    {
        NorthwindEntities n = new NorthwindEntities();

        public OrderData()
        {

        }
        public Orders GetById(int orderID)
        {
            var Z = n.Set<Orders>().FirstOrDefault(x => x.OrderID == orderID);
            return Z;



        }
        public Orders GetAuto()
        {
            var Z = n.Set<Orders>().Find(n.Orders.Max(p => p.OrderID));
            return Z;



        }



        public List<Orders> ObtenerFacturas()
        {



            return n.Orders.ToList();



        }

        public bool Insertar(Orders orders)
        {

            try
            {


                n.Orders.Add(orders);
                n.SaveChanges();



                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("El nombre del Cliente no Existe");
                Console.ReadKey();
                Factura FA = new Factura();
                FA.facturaOrden();
                return false;
            }
        }

        public bool Eliminar(Orders orders)
        {

            try
            {


                var resultado = n.Orders.Where(a => a.OrderID == orders.OrderID).Select(x => x).FirstOrDefault();
                n.Orders.Remove(resultado);
                n.SaveChanges();


                return true;
            }
            catch (Exception) { return false; }

        }

        public bool Actualizar(Orders orders)
        {

            try
            {


                var resultado = n.Orders.Where(a => a.Order_Details == orders.Order_Details).Select(x => x).FirstOrDefault();
                resultado.OrderID = orders.OrderID;
                n.SaveChanges();

                return true;
            }
            catch (Exception) { return false; }

        }
        public bool Save(Orders orders)
        {

            try
            {


            
                n.SaveChanges();


                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Error al guardar Presione una tecla para continuar");
                Console.ReadKey();
                Factura FA = new Factura();
                FA.facturaOrden();
                return false;
            }
        }

    }
}
