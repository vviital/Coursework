using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModel
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }

        public string ProductType { get; set; }

        public virtual City City { get; set; }

        public virtual List<Job> Jobs { get; set; } 
    }
}
