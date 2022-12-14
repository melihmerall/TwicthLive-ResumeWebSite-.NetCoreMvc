using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Dtos.LanguageDtos
{
    public class UpdateLanguageDto
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedDate { get; set; } 
    }
}
