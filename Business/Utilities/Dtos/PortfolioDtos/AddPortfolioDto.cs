using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Dtos.PortfolioDtos
{
    public class AddPortfolioDto
    {
        public string Name { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }

    }
}
