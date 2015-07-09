using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModelDTO
{
    public class CityDTO : BaseEntityDTO
    {
        public string CityName { get; set; }

        public virtual CountryDTO Country { get; set; }

        public virtual List<int> Dwelling { get; set; }

        public virtual List<int> Visits { get; set; }

        public virtual List<int> Companies { get; set; }

        public virtual List<int> EducationalEstablishments { get; set; }

        public virtual List<int> Ownerships { get; set; } 
    }
}
