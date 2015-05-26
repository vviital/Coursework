using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModel
{
    public class Job : BaseEntity
    {
        public string PositionAtWork { get; set; }

        public string TypeOfEmployment { get; set; }

        public virtual Person Employee { get; set; }

        public virtual Company Company { get; set; }
    }
}
