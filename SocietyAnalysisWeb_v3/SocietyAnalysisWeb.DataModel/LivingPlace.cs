using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModel
{
    public class LivingPlace : BaseEntity
    {
        public int? Home { get; set; }

        public string Street { get; set; }

        public virtual City City { get; set; }

        public virtual List<Person> Tenants { get; set; }
    }
}
