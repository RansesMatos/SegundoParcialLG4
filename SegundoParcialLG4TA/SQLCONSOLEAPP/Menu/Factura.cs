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
            decimal monto;
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
                    File.AppendAllLines("D:lp4.txt", new String[] { ($"{item.ProductID,5} {producto.ProductName,5}{ item.Quantity,5 }{ item.UnitPrice,5 }{ item.Discount,5} {monto = ((item.UnitPrice * item.Quantity)-Convert.ToInt16(item.Discount)),5}") });
                    Console.WriteLine(item.ProductID + "\t" + item.Quantity + "\t" + producto.ProductName + "\t" + item.UnitPrice + "\t" + item.Discount);
                }
            }


        }




        public void facturaOrden()
        {
            
            OrderData OD = new OrderData();
            

            Console.WriteLine(" ID Cliente: ");
            var id = Console.ReadLine();
            Console.WriteLine(" ID empleado: ");
            try
            {
                var ide = Convert.ToInt16(Console.ReadLine());
                Orders orders = new Orders()
                {
                    CustomerID = id,
                    EmployeeID = ide,
                    OrderDate = DateTime.Today

                };

            }
            catch (Exception)
            {
                Console.WriteLine(" Error solo se permiten perminten numero ");
                Console.ReadLine();
                facturaOrden();
               
            }
           

            
           

            try
            {
                OD.Insertar(orders);
            }
            catch (Exception)
            {

                Console.WriteLine("El valor introducido esta incorrecto ");
                Console.WriteLine("Precione una tecla para volver");
                Console.ReadKey();
                MenuPrincipal mnu = new MenuPrincipal();
                mnu.MenuP();
            }


            


            Console.WriteLine(" Nombre Cliente: ");
            Console.WriteLine(id);

            OD.Save(orders);

            FacturaDetalle();

        }

        public void FacturaDetalle()
        {
            decimal monto;
            decimal total = 0;
            int cantidad = 0;
            int productos;
            OrderData OD = new OrderData();
            OrdenDetailData ODD = new OrdenDetailData();
            var ID = OD.GetAuto();


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
                    if (Orden_list.Count == 0 ) 
                    {
                        //Orden_list.RemoveAll();
                        Console.WriteLine("El valor introducido esta incorrecto ");

                        Console.WriteLine("Precione una tecla para Eliminar este registro y continuar");
                       Console.ReadKey();
                        FacturaDetalle();

                    }

                    Orden_list.RemoveAt(Orden_list.Count);
                    Console.WriteLine("El valor introducido esta incorrecto ");

                    Console.WriteLine("Precione una tecla para Eliminar este registro y continuar");
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


            Console.WriteLine($"{"IDAriculo",5}| {"Ariculo",5}| {"Precio",5}| {"Cantidad",5}| {"Descuento",5}| {"Cargo Total",5}|");
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

                Console.WriteLine($"{ord.ProductID,5} {name.ProductName,5}{ ord.Quantity,5 }{ ord.UnitPrice,5 }{ ord.Discount,5} {monto = ((ord.UnitPrice * ord.Quantity)-Convert.ToInt16(ord.Discount)),5}");

                cantidad = ord.Quantity + cantidad;
                total = monto + total;

            }

            Console.WriteLine();
            Console.WriteLine("Total De articulos:       " + cantidad + "\t Total A pagar:   " + total);

           

            Console.ReadKey();





        }










    }
}
