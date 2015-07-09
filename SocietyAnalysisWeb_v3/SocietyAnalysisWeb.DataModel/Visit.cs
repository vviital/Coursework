using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModel
{
    public class Visit : BaseEntity
    {
        public DateTime? Begin { get; set; }

        public DateTime? End { get; set; }

        public string Purpose { get; set; }

        public virtual Person Visitor { get; set; }

        public virtual City City { get; set; }
    }
}
