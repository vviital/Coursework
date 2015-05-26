using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModel
{
    public class Country : BaseEntity
    {
        public string CountryName { get; set; }

        public virtual List<City> Cities { get; set; } 
    }
}
