using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Dtos.ReferenceDtos
{
    public class AddReferenceDto
    {
        public string NameSurname { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
