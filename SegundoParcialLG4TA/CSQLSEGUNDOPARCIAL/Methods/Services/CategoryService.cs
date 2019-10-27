using SEGUNDOLP4.DATA.DATA;
using SEGUNDOLP4.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSQLSEGUNDOPARCIAL.Methods.Services
{
    public class CategoryService 
    {
        private readonly IBaseRepository _repository;
       
        public CategoryService(IBaseRepository repository)
        {
            this._repository = repository;
            
        }
       public async Task<int> Insert(Categories categories)
        {
            try
            {
                return await _repository.Add(categories);


            }
            catch
            {
                return 0;
            }

        }

        public void GetAll(Categories categories)
        {
            try
            {
                var item =  _repository.GetAll<Categories>();
               

            }
            catch(Exception e)
            {
                throw e;
            }
            
        }


    }
}
