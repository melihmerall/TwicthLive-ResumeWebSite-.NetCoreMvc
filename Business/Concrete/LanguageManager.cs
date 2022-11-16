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
    public class LanguageManager:ILanguageService
    {
        private ILanguageDal _languageDal;

        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }

        public List<Language> GetList()
        {
            return _languageDal.GetList();
        }

        public Language GetById(int id)
        {
            return _languageDal.Get(x=>x.Id == id);
        }

        public void TAdd(Language entity)
        {
            _languageDal.Create(entity);
        }
        
        public void TRemove(Language entity)
        {
            _languageDal.Delete(entity);
        }

        public void TUpdate(Language entity)
        {
            _languageDal.Update(entity);
        }
    }
}
