using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModelDTO
{
    public class CountryDTO : BaseEntityDTO
    {
        public string CountryName { get; set; }

        public virtual List<int> Cities { get; set; } 
    }
}
