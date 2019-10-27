using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialLG4TA.Menu
{
    public class MenuPrincipal
    {
        public void MenuP()
        {
            ConsoleKeyInfo sa;
            do
            {
                Console.Clear(); //Limpiar la pantalla
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[B]Mantenimientos");
                Console.Write("[F]Facturación");
                Console.Write("[C]Cargar CSV de Clientes");
                Console.Write("[I]Imprimir Factura");
                Console.Write("[Esc]Salir  ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seleccione opcion...");
                sa = Console.ReadKey(true);
                switch (sa.Key)
                {
                    case ConsoleKey.B:
                        Console.WriteLine("seleccionó la opción Mantenimientos");
                        MenuMaintenace ma = new MenuMaintenace();
                        ma.Menu();                        
                        Console.ReadKey();
                        break;

                    case ConsoleKey.F:
                        Console.WriteLine("Ud seleccionó la opción Eliminar");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.C:
                        Console.WriteLine("Ud seleccionó la opción Buscar");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.I:
                        Console.WriteLine("Ud seleccionó la opción Buscar");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Programa finalizado");
                        

                        break;
                }

            } while (sa.Key != ConsoleKey.Escape);
        }
    }
}
