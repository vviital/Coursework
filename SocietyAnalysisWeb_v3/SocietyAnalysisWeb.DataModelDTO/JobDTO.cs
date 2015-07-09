using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModelDTO
{
    public class JobDTO : BaseEntityDTO
    {
        public string PositionAtWork { get; set; }

        public string TypeOfEmployment { get; set; }

        public virtual PersonDTO Employee { get; set; }

        public virtual CompanyDTO Company { get; set; }
    }
}
