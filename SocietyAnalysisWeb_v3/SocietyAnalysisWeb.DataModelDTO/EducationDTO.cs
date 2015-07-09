using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModelDTO
{
    public class EducationDTO : BaseEntityDTO
    {
        public string Speciality { get; set; }

        public DateTime AcquisitionYear { get; set; }

        public decimal LearningTime { get; set; }

        public bool IsPaidEducation { get; set; }

        public bool IsFullTimeEducation { get; set; }

        public virtual PersonDTO Student { get; set; }

        public virtual EducationalEstablishmentDTO EducationalEstablishment { get; set; }
    }
}
