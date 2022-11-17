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
    public class PortfolioManager : IPortfolioService
    {
        private IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public List<Portfolio> GetList()
        {
            return _portfolioDal.GetList();
        }

        public List<Portfolio> GetAll()
        {
            throw new NotImplementedException();
        }

        public Portfolio GetById(int id)
        {
            return _portfolioDal.Get(x => x.Id == id);
        }

        public void TAdd(Portfolio entity)
        {
            _portfolioDal.Create(entity);
        }

        public void TRemove(Portfolio entity)
        {
            _portfolioDal.Delete(entity);
        }

        public void TUpdate(Portfolio entity)
        {
            _portfolioDal.Update(entity);
        }
    }
}
