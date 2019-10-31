
using SQLCONSOLEAPP.Menu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SQLCONSOLEAPP.Models;
using SQLCONSOLEAPP.Maintenance;

namespace SegundoParcialLG4TA.Menu
{
    public class MenuPrincipal
    {
        public void MenuP()
        {
            Factura FA = new Factura();
            Customers customer = new Customers();
            Customers ss = new Customers();
            CustomerMaintenance maintenance = new CustomerMaintenance();

            ConsoleKeyInfo sa;
            do
            {
                Console.Clear(); //Limpiar la pantalla
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[M]Mantenimientos");
                Console.Write("[F]Facturación");
                Console.Write("[C]Cargar CSV de Clientes");
                Console.Write("[I]Imprimir Factura");
                Console.Write("[Esc]Salir  ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seleccione opcion...");
                sa = Console.ReadKey(true);
                switch (sa.Key)
                {
                    case ConsoleKey.M:
                        Console.WriteLine("seleccionó la opción Mantenimientos");
                        MenuMaintenace ma = new MenuMaintenace();
                        ma.Menu();                        
                        Console.ReadKey();
                        break;

                    case ConsoleKey.F:
                        Console.WriteLine("Ud seleccionó la opción Facturacion");
                        //Factura FA = new Factura();
                        FA.facturaOrden();
                       
                        Console.ReadKey();
                        break;

                    case ConsoleKey.C:
                        Console.WriteLine("Ud seleccionó la opción de cargar un Archivo CSV");
                        var appSettings = ConfigurationManager.AppSettings["pathCsv"];
                        string content = File.ReadAllText(appSettings, Encoding.UTF8);
                        CustomerMaintenance cm = new CustomerMaintenance();
                        Console.WriteLine(content);

                        //var path = @"C:\Users\well\Source\Repos\SegundoParcialLG4mod\SegundoParcialLG4TA\SQLCONSOLEAPP\Files\prueba.csv";

                        List<Customers> mia = File.ReadAllLines("C:\\prueba.csv")
                                           .Skip(1)
                                           .Select(v => Customers.FromCsv(v))
                                           .ToList();

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.I:
                        Console.WriteLine("Ud seleccionó la opción Imprimir una factura");
                        Console.Write("Presione una tecla para continuar...");

                        FA.Imprimir();
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
