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

        public OrderData()
        {

        }
            

            public List<Orders> ObtenerFacturas()
            {

                using (NorthwindEntities n = new NorthwindEntities())
                {

                    return n.Orders.ToList();
                }


            }

            public bool Insertar(Orders orders)
            {

                try
                {
                    using (NorthwindEntities n = new NorthwindEntities())
                    {

                        n.Orders.Add(orders);
                        n.SaveChanges();

                    }
                    return true;
                }
                catch (Exception e) 
            {
                Console.WriteLine("Error "+ e);
                return false; 
            }
            }

            public bool Eliminar(Orders orders)
            {

                try
                {
                    using (NorthwindEntities n = new NorthwindEntities())
                    {

                        var resultado = n.Orders.Where(a => a.OrderID == orders.OrderID).Select(x => x).FirstOrDefault();
                        n.Orders.Remove(resultado);
                        n.SaveChanges();

                    }
                    return true;
                }
                catch (Exception) { return false; }

            }

            public bool Actualizar(Orders orders)
            {

                try
                {
                    using (NorthwindEntities n = new NorthwindEntities())
                    {

                       var resultado = n.Orders.Where(a => a.Order_Details == orders.Order_Details).Select(x => x).FirstOrDefault();
                        resultado.OrderID = orders.OrderID;
                        n.SaveChanges();

                    }
                    return true;
                }
                catch (Exception) { return false; }

            }

    }
}
