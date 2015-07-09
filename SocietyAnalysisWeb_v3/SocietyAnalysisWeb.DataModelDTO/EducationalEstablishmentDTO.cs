using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModelDTO
{
    public class EducationalEstablishmentDTO : BaseEntityDTO
    {
        public string Name { get; set; }

        public string EducationType { get; set; }

        public string WebSite { get; set; }

        public virtual CityDTO City { get; set; }

        public virtual List<int> Educations { get; set; }
    }
}
