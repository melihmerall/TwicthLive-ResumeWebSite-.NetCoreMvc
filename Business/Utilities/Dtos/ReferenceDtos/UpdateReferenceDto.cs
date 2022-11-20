using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Dtos.ReferenceDtos
{
    public class UpdateReferenceDto
    {
        public string NameSurname { get; set; }
        public string JobTitle { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        
    }
}
