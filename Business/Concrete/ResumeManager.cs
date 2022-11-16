using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ResumeManager:IResumeService
    {

        private readonly IResumeDal _resumeDal;

        public ResumeManager(IResumeDal resumedal)
        {
            _resumeDal = resumedal;
        }
        public List<Resume> GetList()
        {
            return _resumeDal.GetList().ToList();
        }

        public Resume GetById(int id)
        {
            return _resumeDal.Get(x => x.Id == id);
        }

        public void TAdd(Resume entity)
        {
            _resumeDal.Create(entity);
        }

        public void TRemove(Resume entity)
        {
            _resumeDal.Delete(entity);
        }

        public void TUpdate(Resume entity)
        {
            _resumeDal.Update(entity);
        }


    }
}
