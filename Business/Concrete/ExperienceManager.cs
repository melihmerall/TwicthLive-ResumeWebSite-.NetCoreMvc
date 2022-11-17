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
    public class ExperienceManager:IExperienceService
    {
        private IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public List<Experience> GetList()
        {
            return _experienceDal.GetList().ToList();
        }

        public List<Experience> GetAll()
        {
            throw new NotImplementedException();
        }

        public Experience GetById(int id)
        {
            return _experienceDal.Get(x=>x.Id == id);
        }

        public void TAdd(Experience entity)
        {
            _experienceDal.Create(entity);
        }

        public void TRemove(Experience entity)
        {
            _experienceDal.Delete(entity);
        }

        public void TUpdate(Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}
