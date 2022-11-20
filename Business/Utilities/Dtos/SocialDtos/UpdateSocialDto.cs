using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Dtos.SocialDtos
{
    public class UpdateSocialDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        
    }
}
