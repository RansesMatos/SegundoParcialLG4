using SQLCONSOLEAPP.Data;
using SQLCONSOLEAPP.Maintenance;
using SQLCONSOLEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SegundoParcialLG4TA.Menu;

namespace SQLCONSOLEAPP.Menu
{
    //dd
    public class Factura
    {

        OrderData OD = new OrderData();
        Orders orders = new Orders();
        ProductsMaintenance PM = new ProductsMaintenance();
        public void Imprimir()
        {
            OrdenDetailData ODD = new OrdenDetailData();
            Console.WriteLine("Inserta el ID de la Factura");
            var buscar = Console.ReadLine();
            var x = OD.GetById(Convert.ToInt32(buscar));
            if (x == null)
            {
                Console.WriteLine("No existe Ese numero de orden");
                Console.ReadKey();
                MenuPrincipal mnu = new MenuPrincipal();
                mnu.MenuP();
            }
            else
            {
                try
                {
                    File.WriteAllLines("D:lp4.txt", new String[] { x.OrderID + "\t" + x.CustomerID + "\t" + x.EmployeeID + "\t" + x.OrderDate });

                    Console.WriteLine(x.OrderID + "\t" + x.CustomerID + "\t" + x.EmployeeID + "\t" + x.OrderDate);

                }
                catch (Exception e)
                {

                    throw e;
                }


                var Detalle = ODD.ObtenerFacturasDetalle().Where(z => z.OrderID == Convert.ToInt32(buscar));


                File.AppendAllLines("D:lp4.txt", new String[] { "IDAriculo\t|\tAriculo\t|\tPrecio\t|\tCantidad\t|\tDescuento\t|\tCargo Total\t| " });


                foreach (var item in Detalle)
                {
                    var producto = PM.GetById(item.ProductID);
                    File.AppendAllLines("D:lp4.txt", new String[] { item.ProductID + "\t" + producto.ProductName + "\t" + item.Quantity + "\t" + item.UnitPrice + "\t" + item.Discount });
                    Console.WriteLine(item.ProductID + "\t" + item.Quantity + "\t" + producto.ProductName + "\t" + item.UnitPrice + "\t" + item.Discount);
                }
            }


        }




        public void factura()
        {
            decimal monto;
            decimal total = 0;
            int cantidad = 0;
            int productos;

            OrderData OD = new OrderData();
            OrdenDetailData ODD = new OrdenDetailData();


            Console.WriteLine(" ID Cliente: ");
            var id = Console.ReadLine();
            Console.WriteLine(" ID empleado: ");
            var ide = Convert.ToInt16(Console.ReadLine());

            try
            {
                var todo = OD.ObtenerFacturas();
            }
            catch (Exception e)
            {

                throw e;
            }



            Orders orders = new Orders()
            {
                CustomerID = id,
                EmployeeID = ide,
                OrderDate = DateTime.Today

            };

            try
            {
                OD.Insertar(orders);
            }
            catch (Exception e)
            {

                Console.WriteLine("El valor introducido esta incorrecto ");
                Console.WriteLine("Precione una tecla para volver");
                Console.ReadKey();
                MenuPrincipal mnu = new MenuPrincipal();
                mnu.MenuP();
            }


            var ID = OD.GetAuto();


            Console.WriteLine(" Nombre Cliente: ");
            Console.WriteLine(id);

            Console.WriteLine("# de productos a registrar: ");
            productos = Convert.ToInt16(Console.ReadLine());

            List<Order_Details> Orden_list = new List<Order_Details>();



            do
            {
                Console.WriteLine("Introducir  ID Articulo, Cantidad, Descuento : ");
                try
                {
                    var producto = PM.GetById(Convert.ToInt16(Console.ReadLine()));
                    Orden_list.Add(new Order_Details(ID.OrderID, producto.ProductID, Convert.ToInt16(producto.UnitPrice), Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine())));
                }
                catch
                {
                    Console.WriteLine("El valor introducido esta incorrecto ");

                    Console.WriteLine("Precione una tecla para volver");
                    Console.ReadKey();
                    MenuPrincipal mnu = new MenuPrincipal();
                    mnu.MenuP();

                }



                //Orden_list.Add(new Order_Details(ID.OrderID, Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine())));

            }
            while (productos > Orden_list.Count);



            Console.WriteLine();
            Console.WriteLine();
            //Numero de la orden
            Console.WriteLine(ID.OrderID);
            //nombre del cliente


            Console.WriteLine();
            //Detalle de la orden


            Console.WriteLine("IDAriculo\t|Ariculo\t|Precio\t|Cantidad\t|Descuento\t|Cargo Total|  ");
            foreach (Order_Details ord in Orden_list)
            {
                Order_Details order_De = new Order_Details()

                {
                    OrderID = ord.OrderID,
                    ProductID = ord.ProductID,
                    UnitPrice = ord.UnitPrice,
                    Quantity = ord.Quantity,
                    Discount = ord.Discount
                };

                try
                {
                    ODD.Insertar(order_De);
                    ODD.SAVE(order_De);
                }
                catch (Exception)
                {
                    Console.WriteLine("El valor introducido esta incorrecto ");

                    Console.WriteLine("Precione una tecla para volver");
                    Console.ReadKey();
                    MenuPrincipal mnu = new MenuPrincipal();
                    mnu.MenuP();
                }

                var name = PM.GetById(ord.ProductID);

                Console.WriteLine(ord.ProductID + "\t" + name.ProductName + "\t" + ord.Quantity + "\t"
                    + ord.UnitPrice + "\t" + +(monto = (ord.UnitPrice * ord.Quantity)));

                cantidad = ord.Quantity + cantidad;
                total = monto + total;

            }

            Console.WriteLine();
            Console.WriteLine("Total De articulos:       " + cantidad + "\t Total A pagar:   " + total);

            //OD.Save(orders);


            Console.ReadKey();
        }











    }
}
