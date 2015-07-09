using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModel
{
    public class EducationalEstablishment : BaseEntity
    {
        public string Name { get; set; }

        public string EducationType { get; set; }

        public string WebSite { get; set; }

        public virtual City City { get; set; }

        public virtual List<Education> Educations { get; set; }
    }
}
