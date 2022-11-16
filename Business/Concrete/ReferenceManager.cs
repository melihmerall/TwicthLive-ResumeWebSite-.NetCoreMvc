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
    public class ReferenceManager:IReferenceService
    {
        private IReferenceDal _referenceDal;

        public ReferenceManager(IReferenceDal referenceDal)
        {
            _referenceDal = referenceDal;
        }

        public List<Reference> GetList()
        {
            return _referenceDal.GetList();
        }

        public Reference GetById(int id)
        {
            return _referenceDal.Get(x=>x.Id == id);
        }

        public void TAdd(Reference entity)
        {
            _referenceDal.Create(entity);
        }

        public void TRemove(Reference entity)
        {
            _referenceDal.Delete(entity);
        }

        public void TUpdate(Reference entity)
        {
            _referenceDal.Update(entity);
        }
    }
}
