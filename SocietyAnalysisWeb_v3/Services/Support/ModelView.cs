using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModelDTO;
using System.Web.Mvc;

namespace Services.Support
{
    public class ModelView
    {
        public IEnumerable<SelectListItem> Cities { get; set; }

        public IEnumerable<SelectListItem> Races { get; set; }

        public IEnumerable<SelectListItem> Languages { get; set; }

        public int CountryId { get; set; }

        public IEnumerable<SelectListItem> Sexs { get; set; }

        public IEnumerable<SelectListItem> Edu { get; set; }

        public IEnumerable<SelectListItem> formEdu { get; set; }

        public int EduId { get; set; }

        public string Sex { get; set; }

        public int LanguageId { get; set; }

        public List<int> KnownLanguageId { get; set; }

        public EducationDTO EducationDto { get; set; }

        public string formEduId { get; set; }

        public string Speciality { get; set; }

        public DateTime? DateTime { get; set; }

        public int DurationEducation { get; set; }

        public ModelView()
        {
            Races = new List<SelectListItem>()
            {
                new SelectListItem(){Text = string.Empty, Value = "-1"},
                new SelectListItem(){Text = "Европеец", Value = "Европеец"},
                new SelectListItem(){Text = "Азиат", Value = "Азиат"},
                new SelectListItem(){Text = "Ариец", Value = "Ариец"},
                new SelectListItem(){Text = "Клингон", Value = "Клингон"},
                new SelectListItem(){Text = "Ромулан", Value = "Ромулан"},
                new SelectListItem(){Text = "Борг", Value = "Борг"}
            };

            Sexs = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "Мужской", Value = "Мужской"},
                new SelectListItem(){Text = "Женский", Value = "Женский"}
            };

            this.formEdu = new List<SelectListItem>()
            {
                new SelectListItem(){Text = string.Empty, Value = "-1"},
                new SelectListItem(){Text = "Очная", Value = "Очная"},
                //new SelectListItem(){Text = "Очно-заочная", Value = "Очно-заочная"},
                new SelectListItem(){Text = "Заочная", Value = "Заочная"},
                //new SelectListItem(){Text = "Экстернат", Value = "Экстернат"}
            };

            KnownLanguageId = new List<int>();
            KnownLanguageId.Add(-1);
            KnownLanguageId.Add(-1);
            KnownLanguageId.Add(-1);
        }

        public PersonDTO Person { get; set; }
    }
}
