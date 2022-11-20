using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Dtos.ResusmeDtos
{
    public class AddResumeDto
    {
        public string Name { get; set; }

        public int AboutId { get; set; }

        public int EducationId { get; set; }

        public int ExperienceId { get; set; }


        public int HobbyId { get; set; }


        public int LanguageId { get; set; }
        public int PortfolioId { get; set; }

        public int ReferenceId { get; set; }

        public int SocialId { get; set; }

        public int TalentId { get; set; }
    }
}
