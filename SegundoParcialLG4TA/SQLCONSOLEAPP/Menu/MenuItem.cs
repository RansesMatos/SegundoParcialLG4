


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
   

