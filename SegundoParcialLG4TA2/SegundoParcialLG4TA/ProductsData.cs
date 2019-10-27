using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialLG4TA
{
    public class ProductsData
    {
        NorthwindEntities conection = new NorthwindEntities();
        public List<Products> GetAll()
        {
            return conection.Products.ToList();
        }

        public bool Insert(Products productsInsert)
        {
            try
            {
                conection.Products.Add(productsInsert);
                conection.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool Update(Products productsUpdate)
        {
            try
            {
                var query = (from a in conection.Products
                             where a.ProductID == productsUpdate.ProductID
                             select a).FirstOrDefault();
            
              
                   query.ProductName = productsUpdate.ProductName;
                   query.SupplierID = productsUpdate.SupplierID;
                   query.CategoryID = productsUpdate.CategoryID;
                   query.QuantityPerUnit = productsUpdate.QuantityPerUnit;
                   query.UnitPrice = productsUpdate.UnitPrice;
                   query.UnitsInStock = productsUpdate.UnitsInStock;
                   query.UnitsOnOrder = productsUpdate.UnitsOnOrder;
                   query.ReorderLevel = productsUpdate.ReorderLevel;
                   query.Discontinued = productsUpdate.Discontinued;
                
                conection.SaveChanges();
            
                return true;
            }
            catch (Exception)
            {
                return false;
            }
         
        }

        public bool Delete(Products productsDelete)
        {
            try
            {
                var resultadoDelete = conection.Products.Where(a => a.ProductID == productsDelete.ProductID).Select(x => x).FirstOrDefault();
                conection.Products.Remove(resultadoDelete);
                conection.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
