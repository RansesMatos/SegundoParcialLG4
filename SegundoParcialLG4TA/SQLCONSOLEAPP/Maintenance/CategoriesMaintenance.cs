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
        public Categories GetById(int? idcategory)
        {
            var query = entities.Categories.FirstOrDefault(i => i.CategoryID == idcategory);
            return query;
        }
        public bool Insert(Categories categories)
        {
            try
            {
                entities.Categories.Add(categories);
                entities.SaveChanges();
                Console.WriteLine("Datos insertados con exito");
                return true;
            }
            catch (Exception)
            {
                if (String.IsNullOrEmpty(categories.CategoryName) || String.IsNullOrEmpty(categories.Description))
                {
                    Console.WriteLine("Debe insertar el nombre o descripcion de la categoria");
                };

                return false;
            }
              
        }
        public bool Update(Categories categories)
        {
            try
            {
                var query = (from a in entities.Categories where a.CategoryID == categories.CategoryID select a).FirstOrDefault();

                query.CategoryName = categories.CategoryName;
                query.Description = categories.Description;
                query.Picture = categories.Picture = null;

                entities.SaveChanges();
                Console.WriteLine("Datos actualizados correctamente");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Datos ocurrio un error al intentar actualizar");
                return false;
            }
        }
        public bool Delete(int?  idcategorie)
        {
            try
            {
                var resultado = entities.Categories.Where(a => a.CategoryID == idcategorie).Select(x => x).FirstOrDefault();
                entities.Categories.Remove(resultado);
                Console.WriteLine("Datos eliminados correctamente");
                entities.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un error al tratar de eliminar datos");
                return false;
            }
        }

        //
    }
}
