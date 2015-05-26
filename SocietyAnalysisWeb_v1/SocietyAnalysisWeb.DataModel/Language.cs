using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModel
{
    public class Language : BaseEntity
    {
        public string LanguageName { get; set; }

        public virtual List<Person> Speakers { get; set; }

        public virtual List<Person> NativeSpeakers { get; set; }
    }
}
