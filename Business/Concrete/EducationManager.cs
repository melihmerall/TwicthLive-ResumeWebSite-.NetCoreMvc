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
    public class EducationManager:IEducationService
    {
        private IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public List<Education> GetList()
        {
            return _educationDal.GetList().ToList();
        }

        public List<Education> GetAll()
        {
            throw new NotImplementedException();
        }

        public Education GetById(int id)
        {
            return _educationDal.Get(x=>x.Id == id);
        }

        public void TAdd(Education entity)
        {
            _educationDal.Create(entity);
        }

        public void TRemove(Education entity)
        {
            _educationDal.Delete(entity);
        }

        public void TUpdate(Education entity)
        {
            _educationDal.Update(entity);
        }
    }
}
