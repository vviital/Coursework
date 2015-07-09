using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModelDTO
{
    public class VisitDTO : BaseEntityDTO
    {
        public DateTime Begin { get; set; }

        public DateTime End { get; set; }

        public string Purpose { get; set; }

        public virtual PersonDTO Visitor { get; set; }

        public virtual CityDTO City { get; set; }
    }
}
