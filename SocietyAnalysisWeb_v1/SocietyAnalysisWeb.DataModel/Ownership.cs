using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModel
{
    public class Ownership : BaseEntity
    {
        public string OwnershipName { get; set; }

        public string OwnershipType { get; set; }

        public virtual City City { get; set; }

        public virtual Person Owner { get; set; }
    }
}
