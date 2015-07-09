﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModelDTO
{
    public class LivingPlaceDTO : BaseEntityDTO
    {
        public int Home { get; set; }

        public string Street { get; set; }

        public virtual CityDTO City { get; set; }

        public virtual List<int> Tenants { get; set; }
    }
}
