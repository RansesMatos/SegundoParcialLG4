using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SEGUNDOLP4.DATA.DATA
{
    public interface IBaseRepository<T> where T : class
    {


        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();

        //Task<ICollection<T>> GetAll<T>() where T : class;
        //Task<T> Get<T>(Expression<Func<T, bool>> predicate) where T : class;
        //Task<ICollection<T>> Gets<T>(Expression<Func<T, bool>> predicate) where T : class;
        //Task<int> Add<T>(T entity) where T : class;
        //Task<int> AddRange<T>(IEnumerable<T> entities);
        //Task<bool> Update<T>(T entity) where T : class;
        //void Delete<T>(T entity) where T : class;

    }

}
