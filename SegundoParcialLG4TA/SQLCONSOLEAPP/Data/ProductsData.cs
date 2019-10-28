using SQLCONSOLEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCONSOLEAPP.Data
{
    public class ProductsData
    {
        NorthwindEntities entities = new NorthwindEntities();

        public List<Products> GetAll()
        {
            return entities.Products.ToList();
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
                Console.WriteLine("Ocurrio un problema al intentar insertar datos");
                return false;
            }
        }

    }
}
