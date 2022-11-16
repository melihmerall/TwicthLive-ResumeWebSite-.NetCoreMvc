using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Reference : BaseEntity
    {
        public string NameSurname { get; set; }
        public string JobTitle { get; set; }
    }
}
