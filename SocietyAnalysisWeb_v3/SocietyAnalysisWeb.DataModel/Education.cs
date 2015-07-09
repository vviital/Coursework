using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModel
{
    public class Education : BaseEntity
    {
        public string Speciality { get; set; }

        public DateTime? AcquisitionYear { get; set; }

        public decimal? LearningTime { get; set; }

        public bool? IsPaidEducation { get; set; }

        public bool? IsFullTimeEducation { get; set; }

        public virtual Person Student { get; set; }

        public virtual EducationalEstablishment EducationalEstablishment { get; set; }
    }
}
