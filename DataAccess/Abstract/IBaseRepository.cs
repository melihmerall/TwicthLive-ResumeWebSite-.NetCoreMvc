using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBaseRepository<T> where T:class,new()
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
