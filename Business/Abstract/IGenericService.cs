using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenericService<T> where T:class,new()
    {
        List<T> GetList();
        List<T> GetAll();
        T GetById(int id);
        void TAdd(T entity);
        void TRemove(T entity);
        void TUpdate(T entity);
    }
}
