using SQLCONSOLEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCONSOLEAPP.Maintenance
    {
    public class ProductsMaintenance
    {
        NorthwindEntities entities = new NorthwindEntities();
        public List<Products> GetProducts()
        {
            return entities.Products.ToList();
        }
        //dd
        public Products GetById ( int? idproduct)
        {
            var query = entities.Products.FirstOrDefault(i => i.ProductID == idproduct);
           
            return query;
        }
        public bool Insert(Products products)
        {
            try
            {
                entities.Products.Add(products);
                entities.SaveChanges();
                Console.WriteLine("Datos insertados con exito");
                return true;
            }
            catch (Exception)
            {
                if (products.ProductName == null)
                {
                    Console.WriteLine("Debe Ingresar el Nombre del Producto");
                }
                else
                {
                    if (products.SupplierID == null)
                    {
                        Console.WriteLine("Debe Ingresar el Id del Suplidor");
                    }
                    else
                    {
                        if (products.CategoryID == null)
                        {
                            Console.WriteLine("Debe Ingresar el Id del Categoria");
                        }
                        else
                        {
                            if (products.QuantityPerUnit == null)
                            {
                                Console.WriteLine("Debe Ingresar la cantidad por unidad");
                            }
                            else
                            {
                                if (products.UnitPrice == null)
                                {
                                    Console.WriteLine("Debe Ingresar el precio por unidad");
                                }
                                else
                                {
                                    if (products.UnitsInStock == null)
                                    {
                                        Console.WriteLine("Debe Ingresar la unidad en stock");
                                    }
                                    else
                                    {
                                        if (products.UnitsOnOrder == null)
                                        {
                                            Console.WriteLine("Debe Ingresar el orden de la unidad");
                                        }
                                        else
                                        {
                                            if (products.ReorderLevel == null)
                                            {
                                                Console.WriteLine("Debe Ingresar el nivel de reorden");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("Ocurrio un problema al intentar insertar datos");
                return false;
            }
        }
        public bool Delete(int productsId)
        {
            try
            {
                var resultado = entities.Products.Where(a => a.ProductID == productsId).Select(x => x).FirstOrDefault();
                entities.Products.Remove(resultado);
                entities.SaveChanges();
                Console.WriteLine("Datos eliminados correctamente");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un error al tratar de eliminar datos");
                return false;
            }
        }
        public bool Update(Products products)
        {
            try
            {
                var query = (from a in entities.Products where a.ProductID == products.ProductID select a).FirstOrDefault();

                query.ProductName = products.ProductName;
                query.SupplierID = products.SupplierID;
                query.CategoryID = products.CategoryID;
                query.QuantityPerUnit = products.QuantityPerUnit;
                query.UnitPrice = products.UnitPrice;
                query.UnitsInStock = products.UnitsInStock;
                query.UnitsOnOrder = products.UnitsOnOrder;
                query.ReorderLevel = products.ReorderLevel;
                query.Discontinued = products.Discontinued;

               
                entities.SaveChanges();
                Console.WriteLine("Datos actualizados correctamente");
                return true;
            }
            catch (Exception)
            {
                if (products.ProductName == null)
                {
                    Console.WriteLine("Debe Ingresar el Nombre del Producto");
                }
                else
                {
                    if (products.SupplierID == null)
                    {
                        Console.WriteLine("Debe Ingresar el Id del Suplidor");
                    }
                    else
                    {
                        if (products.CategoryID == null)
                        {
                            Console.WriteLine("Debe Ingresar el Id del Categoria");
                        }
                        else
                        {
                            if (products.QuantityPerUnit == null)
                            {
                                Console.WriteLine("Debe Ingresar la cantidad por unidad");
                            }
                            else
                            {
                                if (products.UnitPrice == null)
                                {
                                    Console.WriteLine("Debe Ingresar el precio por unidad");
                                }
                                else
                                {
                                    if (products.UnitsInStock == null)
                                    {
                                        Console.WriteLine("Debe Ingresar la unidad en stock");
                                    }
                                    else
                                    {
                                        if (products.UnitsOnOrder == null)
                                        {
                                            Console.WriteLine("Debe Ingresar el orden de la unidad");
                                        }
                                        else
                                        {
                                            if (products.ReorderLevel == null)
                                            {
                                                Console.WriteLine("Debe Ingresar el nivel de reorden");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("Ocurrio un problema al intentar actualizar los datos");
                return false;
            }
        }
    }
}
