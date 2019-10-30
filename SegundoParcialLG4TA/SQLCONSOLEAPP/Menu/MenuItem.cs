


using SQLCONSOLEAPP.Data;
using SQLCONSOLEAPP.Maintenance;
using SQLCONSOLEAPP.Menu;
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
            ProductsMaintenance data = new ProductsMaintenance();
            
            do
                {
                    Console.Clear(); //Limpiar la pantalla
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[A]Agregar");
                    Console.Write("[E]Eliminar");
                    Console.Write("[B]Buscar");
                    Console.Write("[U]Actualizar");
                    Console.Write("[Esc]Salir  ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seleccione opcion...");
                //Console Ranses

                var queryProducts = data.GetProducts();

                Console.WriteLine($"{"Id Producto",5}   {"Nombre Producto",10}   {"Suplidor Id",11}   {"Categoria Id",12}   {"Cantidad por unidad",13}   {"Precio por unidad",14}   {"Unidades en Stock",15}   {"Unidades en Orden",16}   {"Nivel de Reorden",17}");
                foreach (var item in queryProducts)
                {
                    Console.WriteLine($"{item.ProductID,5}   {item.ProductName,10}   {item.SupplierID,11}   {item.CategoryID,12}   {item.QuantityPerUnit,13}   {item.UnitPrice,14}   {item.UnitsInStock,15}   {item.UnitsOnOrder,16}   {item.ReorderLevel,17}");
                }

                sa = Console.ReadKey(true);
                switch (sa.Key)
                { 
                        case ConsoleKey.A:
                        Console.Clear();
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
                            products.UnitPrice= Convert.ToInt32(Console.ReadLine());

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
                            Console.WriteLine("Ingrese el ID del producto que deseas eliminar");
                            var ProductID = Convert.ToInt32(Console.ReadLine());
                            data.Delete(ProductID);

                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case ConsoleKey.B:
                            Console.WriteLine("Ud seleccionó la opción Buscar Producto");
                            Console.WriteLine("Ingrese el id del producto que desea buscar");
                            var idproduct = Convert.ToInt32(Console.ReadLine());
                            var query = data.GetById(idproduct);
                            Console.Clear();
                            Console.WriteLine($"{"Id Producto",5}   {"Nombre Producto",10}   {"Suplidor Id",11}   {"Categoria Id",12}   {"Cantidad por unidad",13}   {"Precio por unidad",14}   {"Unidades en Stock",15}   {"Unidades en Orden",16}   {"Nivel de Reorden",17}");
                            Console.WriteLine($"{query.ProductID,5}   {query.ProductName,10}   {query.SupplierID,11}   {query.CategoryID,12}   {query.QuantityPerUnit,13}   {query.UnitPrice,14}   {query.UnitsInStock,15}   {query.UnitsOnOrder,16}   {query.ReorderLevel,17}");
                            Console.Write("Presione una tecla para continuar");
                            Console.ReadKey();
                            break;

                        case ConsoleKey.U:
                            Console.WriteLine("Ud seleccionó la opción Buscar Producto");

                            Console.WriteLine("Ingrese el Id del producto que desea modificar");
                            products.ProductID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese el nombre del producto");
                            products.ProductName = Console.ReadLine();

                            Console.WriteLine("Ingrese el id del suplidor");
                            products.SupplierID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese el id de la categoria");
                            products.CategoryID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese la cantidad por unidad ");
                            products.QuantityPerUnit = Console.ReadLine();

                            Console.WriteLine("Ingrese el precio por unidad");
                            products.UnitPrice = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese las unidades de stock");
                            products.UnitsInStock = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Ingrese las unidades en orden");
                            products.UnitsOnOrder = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Ingrese el nivel de reordenamiento");
                            products.ReorderLevel = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Ingrese si esta activo el producto");
                            products.Discontinued = Convert.ToBoolean(Console.ReadLine());

                            data.Update(products);

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
            Categories categories = new Categories();
            CategoriesMaintenance maintenance = new CategoriesMaintenance();
            do
            {
               
                Console.Clear(); //Limpiar la pantalla
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[A]Agregar");
                Console.Write("[E]Eliminar");
                Console.Write("[B]Buscar");
                Console.Write("[U]Actualizar");
                Console.Write("[Esc]Salir  ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seleccione opcion...");

                var aa = maintenance.GetCategories();
                Console.WriteLine($"{"Id Categoria",5}      {"Nombre Categoria",10}      {"Descripcion",-10}"); 
                foreach (var item in aa)
                {
                    Console.WriteLine($"{item.CategoryID,5}            {item.CategoryName,10}             {item.Description,-10}");
                }

                sa = Console.ReadKey(true);

                switch (sa.Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine("seleccionó la opción Agregar Producto Categorias ");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.E:
                        Console.Clear();
                        Console.WriteLine("Ud seleccionó la opción Eliminar Categorias");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:
                        Console.Clear();
                        Console.WriteLine("Ud seleccionó la opción Buscar Categorias");
                        Console.WriteLine("Indique el Id de la Cateria a buscar");

                        var idcategorie = Convert.ToInt32(Console.ReadLine());
                        var query = maintenance.GetById(idcategorie);

                        Console.WriteLine($"{"Id Categoria",5}      {"Nombre Categoria",10}      {"Descripcion",-10}");
                        Console.WriteLine($"{query.CategoryID,5}            {query.CategoryName,10}             {query.Description,-10}");
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
   

