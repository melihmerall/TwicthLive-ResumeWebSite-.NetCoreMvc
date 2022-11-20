using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Dtos.EducationDtos
{
    public class UpdateEducationDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string SchoolName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
        public float GraduationAverage { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
