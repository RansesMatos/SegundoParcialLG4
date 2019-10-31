using SQLCONSOLEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCONSOLEAPP.Maintenance
{
    public class TerritoriesMaintenance
    {
        NorthwindEntities entities = new NorthwindEntities();
        public List<Territories> GetTerritories()
        {
            return entities.Territories.ToList();
        }
        public Territories GetById(string idTerritorie)
        {
            var query = entities.Territories.FirstOrDefault(i => i.TerritoryID == idTerritorie);
            return query;
        }
        public bool Insert(Territories territorie)
        {
            try
            {
                entities.Territories.Add(territorie);
                entities.SaveChanges();
                Console.WriteLine("Datos insertados con exito");
                return true;
            }
            catch (Exception)
            {
                if (String.IsNullOrEmpty(territorie.TerritoryDescription))
                {
                    Console.WriteLine("Debe insertar la descripcion del Territorio");
                };
                return false;
            }

        }
        public bool Update(Territories territorie)
        {
            try
            {
                var query = (from a in entities.Territories where a.TerritoryID == territorie.TerritoryID select a).FirstOrDefault();

                query.TerritoryDescription = territorie.TerritoryDescription;
                query.RegionID = territorie.RegionID;
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
        public bool Delete(string idTerritorie)
        {
            try
            {
                var resultado = entities.Territories.Where(a => a.TerritoryID == idTerritorie).Select(x => x).FirstOrDefault();
                entities.Territories.Remove(resultado);
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
    }
}
