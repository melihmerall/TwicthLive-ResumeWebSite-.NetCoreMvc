using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfTalentDal : EfBaseRepository<Talent,ResumeContext>, ITalentDal
    {
    }
}
