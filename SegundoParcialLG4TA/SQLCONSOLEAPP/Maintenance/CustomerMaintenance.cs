using SQLCONSOLEAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCONSOLEAPP.Maintenance
{
    public class CustomerMaintenance
    {
        NorthwindEntities entities = new NorthwindEntities();
    

        public bool Insert(Customers customers)
        {
            //try
            //{
            //    entities.Customers.Add(customer);
            //    return true;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
            
            try
            {
                entities.Customers.Add(customers);
                entities.SaveChanges();
                Console.WriteLine("Datos insertados con exitos");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un error");
                return false;
            }
        }
    }
}
