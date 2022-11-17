using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Entities.Concrete
{
    public class About: BaseEntity
    {
        public About()
        {
            Resumes = new HashSet<Resume>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
