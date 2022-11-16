using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Resume
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AboutId { get; set; }
        public virtual About About { get; set; }
        public int EducationId { get; set; }
        public virtual Education Education { get; set; }
        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; }

        public int HobbyId { get; set; }    
        public virtual Hobby Hobby { get; set; }

        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int PortfolioId { get; set; }
        public virtual Portfolio Portfolio { get; set; }
        public int ReferenceId { get; set; }
        public virtual Reference Reference { get; set; }
        public int SocialId { get; set; }
        public virtual Social Social { get; set; }
        public int TalentId { get; set; }
        public virtual Talent Talent { get; set; }
    

        

 


    }
}
