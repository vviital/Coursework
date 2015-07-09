using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModel
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }

        public virtual Country Country { get; set; }

        public virtual List<LivingPlace> Dwelling { get; set; }

        public virtual List<Visit> Visits { get; set; }

        public virtual List<Company> Companies { get; set; }

        public virtual List<EducationalEstablishment> EducationalEstablishments { get; set; }

        public virtual List<Ownership> Ownerships { get; set; } 
    }
}
