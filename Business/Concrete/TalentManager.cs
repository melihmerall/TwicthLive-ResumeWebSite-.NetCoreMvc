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
    public class TalentManager:ITalentService
    {
        private ITalentDal _talentDal;

        public TalentManager(ITalentDal talentDal)
        {
            _talentDal = talentDal;
        }

        public List<Talent> GetList()
        {
            return _talentDal.GetList();
        }

        public Talent GetById(int id)
        {
            return _talentDal.Get(x=>x.Id == id);
        }

        public void TAdd(Talent entity)
        {
            _talentDal.Create(entity);
        }

        public void TRemove(Talent entity)
        {
            _talentDal.Delete(entity);
        }

        public void TUpdate(Talent entity)
        {
            _talentDal.Update(entity);
        }
    }
}
