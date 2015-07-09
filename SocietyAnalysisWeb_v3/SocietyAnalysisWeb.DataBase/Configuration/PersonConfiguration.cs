using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModel;

namespace SocietyAnalysisWeb.DataBase.Configuration
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            HasKey(o => o.Id);

            HasOptional(o => o.LivingPlace).WithMany(o => o.Tenants);

            HasMany(o => o.Parents).WithMany(o => o.Children);

            HasMany(o => o.Visits).WithRequired(o => o.Visitor);

            HasMany(o => o.Ownerships).WithOptional(o => o.Owner);

            HasMany(o => o.Jobs).WithRequired(o => o.Employee);

            HasMany(o => o.Educations).WithRequired(o => o.Student);

            HasMany(o => o.KnownLanguages).WithMany(o => o.Speakers);

            HasOptional(o => o.NativeLanguage).WithMany(o => o.NativeSpeakers);
        }
    }
}
