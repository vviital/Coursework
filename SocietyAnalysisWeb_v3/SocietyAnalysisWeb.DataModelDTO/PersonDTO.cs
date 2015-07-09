using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModelDTO
{
    public class PersonDTO : BaseEntityDTO
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public DateTime BirthTime { get; set; }

        public bool Sex { get; set; }

        public bool WasMarried { get; set; }

        public string Citizenship { get; set; }

        public string Nationality { get; set; }

        public string EducationLevel { get; set; }

        public bool StudiesNow { get; set; }

        public int ChildrenNumber { get; set; }

        public string Race { get; set; }

        public string Religion { get; set; }

        public string PoliticalOutlook { get; set; }

        public virtual LanguageDTO NativeLanguage { get; set; }

        public virtual LivingPlaceDTO LivingPlace { get; set; }

        public virtual List<int> Parents { get; set; }

        public virtual List<int> Children { get; set; }

        public virtual List<int> Educations { get; set; }

        public virtual List<int> KnownLanguages { get; set; }

        public virtual List<int> Jobs { get; set; }

        public virtual List<int> Visits { get; set; }

        public virtual List<int> Ownerships { get; set; } 
    }
}
