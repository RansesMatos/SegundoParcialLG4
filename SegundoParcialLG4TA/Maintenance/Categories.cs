using SegundoParcialLG4TA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance
{
    public class Categories
    {
        NorthwindEntities conection = new NorthwindEntities();
        public List<Categories> GetAll()
        {
            return conection.Categories.ToList();
        }
    }
}
