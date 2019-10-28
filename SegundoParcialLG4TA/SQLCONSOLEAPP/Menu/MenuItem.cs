


using SQLCONSOLEAPP.Data;
using SQLCONSOLEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialLG4TA.Menu
{
    public class MenuItem
    {

        //private readonly CategoryService _context;

        //public MenuItem()
        //{

        //}
        //public MenuItem(CategoryService context)
        //{
        //    _context = context;
        //}


        public void productos()
        {
                    ConsoleKeyInfo sa;
            Products products = new Products();
            ProductsData data = new ProductsData();
            
                do
                {
                    Console.Clear(); //Limpiar la pantalla
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[A]Agregar");
                    Console.Write("[E]Eliminar");
                    Console.Write("[B]Buscar");
                    Console.Write("[Esc]Salir  ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seleccione opcion...");
                    sa = Console.ReadKey(true);

                    switch (sa.Key)
                    {

                        case ConsoleKey.A:
                            Console.WriteLine("seleccionó la opción Agregar Producto ");

                            Console.WriteLine("Ingrese el Id del producto");
                            products.ProductID =Convert.ToInt32( Console.ReadLine());

                            Console.WriteLine("Ingrese el nombre del producto");
                            products.ProductName = Console.ReadLine();

                            Console.WriteLine("Ingrese el id del suplidor");
                            products.SupplierID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese el id de la categoria");
                            products.CategoryID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese la cantidad por unidad ");
                            products.QuantityPerUnit  = Console.ReadLine();

                            Console.WriteLine("Ingrese el precio por unidad");
                            products.QuantityPerUnit=Console.ReadLine();

                            Console.WriteLine("Ingrese las unidades de stock");
                            products.UnitsInStock = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Ingrese las unidades en orden");
                            products.UnitsOnOrder = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Ingrese el nivel de reordenamiento");
                            products.ReorderLevel = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Ingrese si esta activo el producto");
                            products.Discontinued = Convert.ToBoolean(Console.ReadLine());

                            data.Insert(products);


                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case ConsoleKey.E:
                            Console.WriteLine("Ud seleccionó la opción Eliminar Producto");
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case ConsoleKey.B:
                            Console.WriteLine("Ud seleccionó la opción Buscar Producto");
                             var produc = data.GetAll();
                       
                         foreach (var item in produc)
                        {
                           Console.WriteLine(item.ProductID+"   "+item.ProductName);
                            Console.WriteLine(); 
                        }
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                            break;


                        case ConsoleKey.Escape:
                            Console.WriteLine("Retornando");
                            break;
                    }

                } while (sa.Key != ConsoleKey.Escape);

            
      }
        public void Categorias()
        {

            ConsoleKeyInfo sa;
            do
            {
               
                Console.Clear(); //Limpiar la pantalla
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[A]Agregar");
                Console.Write("[E]Eliminar");
                Console.Write("[B]Buscar");
                Console.Write("[Esc]Salir  ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seleccione opcion...");
                
               
                
                // CA.GetAll();
                

                 sa = Console.ReadKey(true);
                

              

                

                switch (sa.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("seleccionó la opción Agregar Producto Categorias ");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.E:
                        Console.WriteLine("Ud seleccionó la opción Eliminar Categorias");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:
                        Console.WriteLine("Ud seleccionó la opción Buscar Categorias");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;


                    case ConsoleKey.Escape:
                        Console.WriteLine("Retornando");
                        break;
                }

            } while (sa.Key != ConsoleKey.Escape);

        }
        public void Territorios()

        {
            ConsoleKeyInfo sa;
            do
            {
                Console.Clear(); //Limpiar la pantalla
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[A]Agregar");
                Console.Write("[E]Eliminar");
                Console.Write("[B]Buscar");
                Console.Write("[Esc]Salir  ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seleccione opcion...");
                sa = Console.ReadKey(true);

                switch (sa.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("seleccionó la opción Agregar Territorios  ");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.E:
                        Console.WriteLine("Ud seleccionó la opción Eliminar Territorios");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:
                        Console.WriteLine("Ud seleccionó la opción Buscar Territorios");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;


                    case ConsoleKey.Escape:
                        Console.WriteLine("Retornando ");
                        break;
                }

            } while (sa.Key != ConsoleKey.Escape);

        }
    }
}   
   

