using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AboutManager:IAboutService
    {
        private IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public List<About> GetList()
        {
            return _aboutDal.GetList();
        }

        public List<About> GetAll()
        {
            return _aboutDal.GetAll();
        }

        public About GetById(int id)
        {
            return _aboutDal.Get(x=>x.Id == id);
        }



        public void TAdd(About entity)
        {
            _aboutDal.Create(entity);
        }

        public void TRemove(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }

    }
}
