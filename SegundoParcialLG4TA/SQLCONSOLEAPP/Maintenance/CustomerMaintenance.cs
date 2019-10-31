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
        public bool Insert(string customer)
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
                SqlConnection sql = new SqlConnection("data source=DESKTOP-IC6ES0H;initial catalog=Northwind;integrated security=True");
                {
                    SqlCommand command = new SqlCommand("INSERT INTO CUSTOMERS (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax) VALUES(@pathCsv)", sql);
                    command.Parameters.AddWithValue("@pathCsv", customer);

                    sql.Open();
                    command.ExecuteNonQuery();
                    sql.Close();
                }
                Console.WriteLine("Exitos");
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
