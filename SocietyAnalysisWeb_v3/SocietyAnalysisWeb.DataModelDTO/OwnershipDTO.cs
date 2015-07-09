using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModelDTO
{
    public class OwnershipDTO : BaseEntityDTO
    {
        public string OwnershipName { get; set; }

        public string OwnershipType { get; set; }

        public virtual CityDTO City { get; set; }

        public virtual PersonDTO Owner { get; set; }
    }
}
