using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModelDTO
{
    public class CompanyDTO : BaseEntityDTO
    {
        public string CompanyName { get; set; }

        public string ProductType { get; set; }

        public virtual CityDTO City { get; set; }

        public virtual List<int> Jobs { get; set; } 
    }
}
