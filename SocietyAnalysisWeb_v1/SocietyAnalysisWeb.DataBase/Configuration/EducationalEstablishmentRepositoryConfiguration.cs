﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModel;

namespace SocietyAnalysisWeb.DataBase.Configuration
{
    public class EducationalEstablishmentRepositoryConfiguration : EntityTypeConfiguration<EducationalEstablishment>
    {
        public EducationalEstablishmentRepositoryConfiguration()
        {
            HasKey(o => o.Id);

            HasOptional(o => o.City).WithMany(o => o.EducationalEstablishments);
        }
    }
}
