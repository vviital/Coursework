using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModel
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthTime { get; set; }

        public bool? Sex { get; set; }

        public bool? WasMarried { get; set; }

        public string Citizenship { get; set; }

        public string Nationality { get; set; }

        public string EducationLevel { get; set; }

        public bool? StudiesNow { get; set; }

        public int? ChildrenNumber { get; set; }

        public string Race { get; set; }

        public string Religion { get; set; }

        public string PoliticalOutlook { get; set; }

        public virtual Language NativeLanguage { get; set; }

        public virtual LivingPlace LivingPlace { get; set; }

        public virtual List<Person> Parents { get; set; }

        public virtual List<Person> Children { get; set; }

        public virtual List<Education> Educations { get; set; }

        public virtual List<Language> KnownLanguages { get; set; }

        public virtual List<Job> Jobs { get; set; }

        public virtual List<Visit> Visits { get; set; }

        public virtual List<Ownership> Ownerships { get; set; } 
    }
}
