﻿using SQLCONSOLEAPP.Data;
using SQLCONSOLEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCONSOLEAPP.Menu
{
    //dd
    public class Factura
    {
        public void factura()
        {
            decimal monto;
            decimal total = 0;
            int cantidad = 0;
            int productos;
            DateTime fecha;
            DateTime fecha2;
            DateTime fecha3;
            OrderData OD = new OrderData();
            OrdenDetailData ODD = new OrdenDetailData();
            // OrdenDetail detalle = new OrdenDetail();
            Console.WriteLine(" Numero de Factura: ");
            var IDO= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" ID Cliente: ");
            var id= Console.ReadLine();
            Console.WriteLine(" ID empleado: ");
            var ide = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Fecha de la orden ");
            fecha = Convert.ToDateTime( Console.ReadLine());         
            Console.WriteLine(" Fecha de la Envio: ");
            fecha3 = Convert.ToDateTime( Console.ReadLine());


            Orders orders = new Orders()
            {
                CustomerID = id,
                EmployeeID = ide,
                OrderDate = fecha,
                RequiredDate= fecha,
                ShippedDate=fecha3
                        
            };

            try
            {
                OD.Insertar(orders);
            }
            catch (Exception e)
            {

                throw e;
            }      
            
            Console.WriteLine(" Nombre Cliente: ");
           // orden.Nombre_cliente = Console.ReadLine();
            Console.WriteLine("# de productos a registrar: ");
            productos = Convert.ToInt16(Console.ReadLine());

            List<Order_Details> Orden_list = new List<Order_Details>();
            Console.WriteLine("Introducir Articulo, Precio, Cantidad, Descuento : ");
            do
            {
               
             
                Orden_list.Add(new Order_Details(IDO, Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine())));
                             
            }
            while (productos > Orden_list.Count);

        

            Console.WriteLine();
            Console.WriteLine();
            //Numero de la orden
            Console.WriteLine("000" + IDO);
           //nombre del cliente
           //Console.Write(orden.Nombre_cliente);

            Console.WriteLine();
            //Detalle de la orden

            //Order_Details order_De = new Order_Details();
            Console.WriteLine("\t Ariculo \t| Precio \t| Cantidad \t| Descuento \t| Cargo Total |  ");
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
                }
                catch (Exception e)
                {

                    throw e;
                }



                Console.WriteLine(ord.Products + "/t" + ord.Quantity + "/t"
                    + ord.UnitPrice + "/t" + +(monto = (ord.UnitPrice * ord.Quantity)));

                cantidad = ord.Quantity + cantidad;
                total = monto + total;

            }

            Console.WriteLine();
            Console.WriteLine("Total De articulos:       " + cantidad + "\t Total A pagar:   " + total);

            Console.ReadKey();
        }











    }
}
