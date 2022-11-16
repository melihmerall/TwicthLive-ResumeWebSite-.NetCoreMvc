using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SocialManager:ISocialService
    {
        private ISocialDal _socialDal;

        public SocialManager(ISocialDal socialDal)
        {
            _socialDal = socialDal;
        }

        public List<Social> GetList()
        {
            return _socialDal.GetList();
        }

        public Social GetById(int id)
        {
            return _socialDal.Get(x => x.Id == id);
        }

        public void TAdd(Social entity)
        {
            _socialDal.Create(entity);
        }

        public void TRemove(Social entity)
        {
            _socialDal.Delete(entity);
        }

        public void TUpdate(Social entity)
        {
            _socialDal.Update(entity);
        }
    }
}
