using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLCONSOLEAPP.Maintenance;
using SQLCONSOLEAPP.Models;

namespace SegundoParcialLG4TA.Menu
{
    public class MenuMaintenace
    {
     
        public void  Menu()
        {
             
           ConsoleKeyInfo op;

                do
                {
                    Console.Clear(); //Limpiar la pantalla
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[P]Productos");
                    Console.Write("[C]Categorias");
                    Console.Write("[T]Teritoritorios");
                    Console.Write("[Esc]Salir  ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seleccione opcion...");
                    op = Console.ReadKey(true);

                    //métodos son acciones, las propiedades son valores
                    switch (op.Key)
                    {
                        case ConsoleKey.P:
                        MenuItem MI = new MenuItem();
                        MI.productos();
                       
                        Console.ReadKey();
                        break;

                        case ConsoleKey.C:
                        MenuItem MI2 = new MenuItem();
                        MI2.Categorias();
                        Console.ReadKey();
                            break;

                        case ConsoleKey.T:
                        MenuItem MI3 = new MenuItem();
                        MI3.Territorios();
                        Console.ReadKey();
                            break;

                        case ConsoleKey.Escape:
                            Console.WriteLine("Saliendo al menu principal");

                            break;
                    }
                } while (op.Key != ConsoleKey.Escape);

           
        
        }   
        
    }
}
