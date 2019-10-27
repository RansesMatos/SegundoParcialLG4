using SQLCONSOLEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCONSOLEAPP.Data
{
    public class OrdenDetailData
    {
        public OrdenDetailData()
        {

        }


        public List<Order_Details> ObtenerFacturas()
        {

            using (NorthwindEntities n = new NorthwindEntities())
            {

                return n.Order_Details.ToList();
            }


        }

        public bool Insertar(Order_Details ORD)
        {

            try
            {
                using (NorthwindEntities n = new NorthwindEntities())
                {

                    n.Order_Details.Add(ORD);
                    n.SaveChanges();

                }
                return true;
            }
            catch (Exception) { return false; }
        }

        public bool Eliminar(Order_Details order_details)
        {

            try
            {
                using (NorthwindEntities n = new NorthwindEntities())
                {

                    var resultado = n.Order_Details.Where(a => a.OrderID == order_details.OrderID).Select(x => x).FirstOrDefault();
                    n.Order_Details.Remove(resultado);
                    n.SaveChanges();

                }
                return true;
            }
            catch (Exception) { return false; }

        }

        public bool Actualizar(Order_Details order_details)
        {

            try
            {
                using (NorthwindEntities n = new NorthwindEntities())
                {

                    var resultado = n.Order_Details.Where(a => a.Products == order_details.Products).Select(x => x).FirstOrDefault();
                    resultado.OrderID = order_details.OrderID;
                    n.SaveChanges();

                }
                return true;
            }
            catch (Exception) { return false; }

        }

    }
}
