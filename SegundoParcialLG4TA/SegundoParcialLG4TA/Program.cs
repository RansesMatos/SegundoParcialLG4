using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialLG4TA
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsData products = new ProductsData();

            #region Select

              var _getall = products.GetAll();

            #endregion

            #region Insert

            //Products productss = new Products { ProductID = 78, ProductName = "Yuca", SupplierID =2, CategoryID = 2, QuantityPerUnit  = "10 boxes",UnitPrice=18, UnitsInStock = 12, UnitsOnOrder = 0,ReorderLevel = 15, Discontinued = false };
            //products.Insert(productss);

            #endregion

            #region Update
            //Products productss = new Products { ProductID = 78, ProductName = "Batata", SupplierID =2, CategoryID = 2, QuantityPerUnit  = "10 boxes",UnitPrice=18, UnitsInStock = 12, UnitsOnOrder = 0,ReorderLevel = 15, Discontinued = false };
            //products.Update(productss);
            #endregion

            #region Delete

            products.Delete(_getall[50]);
            #endregion
        }
    }
}
