using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModelDTO
{
    public class LanguageDTO : BaseEntityDTO
    {
        public string LanguageName { get; set; }

        public virtual List<int> Speakers { get; set; }

        public virtual List<int> NativeSpeakers { get; set; }
    }
}
