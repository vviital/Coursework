using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModel;

namespace SocietyAnalysisWeb.DataBase.Configuration
{
    public class EducationConfiguration : EntityTypeConfiguration<Education>
    {
        public EducationConfiguration()
        {
            HasKey(o => o.Id);

            HasOptional(o => o.EducationalEstablishment).WithMany(o => o.Educations);
        }
    }
}
