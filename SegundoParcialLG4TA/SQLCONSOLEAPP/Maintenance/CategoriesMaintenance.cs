using SQLCONSOLEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCONSOLEAPP.Maintenance
{
    public class CategoriesMaintenance
    {
        NorthwindEntities entities = new NorthwindEntities();
        public List<Categories> GetCategories()
        {
            return entities.Categories.ToList();
        }
        //ddd
        public Categories GetById(int? idcategory)
        {
            var query = entities.Categories.FirstOrDefault(i => i.CategoryID == idcategory);
            return query;
        }
    }
}
