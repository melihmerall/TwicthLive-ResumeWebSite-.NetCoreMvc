using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace Business.Concrete
{
    public class HobbyManager: IHobbyService
    {

        private IHobbyDal _hobbyDal;

        public HobbyManager(IHobbyDal hobbyDal)
        {
            _hobbyDal = hobbyDal;
        }

        public List<Hobby> GetList()
        {
            return _hobbyDal.GetList().ToList();
        }

        public Hobby GetById(int id)
        {
            return _hobbyDal.Get(x=>x.Id == id);
        }

        public void TAdd(Hobby entity)
        {
            _hobbyDal.Create(entity);
        }

        public void TRemove(Hobby entity)
        {
            _hobbyDal.Delete(entity);
        }

        public void TUpdate(Hobby entity)
        {
            _hobbyDal.Update(entity);
        }
    }
}
