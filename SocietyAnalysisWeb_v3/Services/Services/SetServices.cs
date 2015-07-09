using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;
using Services.Support;
using SocietyAnalysisWeb.DataBase;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModelDTO;

namespace Services.Services
{
    public class SetServices : IAddInterfaces
    {
        private IUnitOfWork uow;

        public SetServices(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public void AddPerson(ModelView model)
        {
            Person person = new Person()
            {
                FirstName = model.Person.FirstName,
                Surname = model.Person.Surname,
                Nationality = model.Person.Nationality,
                ChildrenNumber = model.Person.ChildrenNumber,
                PoliticalOutlook = model.Person.PoliticalOutlook,
                Sex = model.Sex == "Мужской",
                Religion = model.Person.Religion,
                Citizenship = model.Person.Citizenship,
                Race = model.Person.Race,
                NativeLanguage = uow.Languages.GetById(model.LanguageId),
                LivingPlace = new LivingPlace() { City = uow.Cities.GetById(model.CountryId)},
                BirthTime = model.Person.BirthTime
            };
            if (model.LanguageId != -1)
            {
                person.NativeLanguage = uow.Languages.GetById(model.LanguageId);
            }
            foreach (var item in model.KnownLanguageId)
            {
                if (item != -1)
                {
                    if (person.KnownLanguages == null)
                        person.KnownLanguages = new List<Language>();
                    person.KnownLanguages.Add(uow.Languages.GetById(item));
                }
            }
            if (model.EduId != -1)
            {
                Education education = new Education()
                {
                    EducationalEstablishment = uow.EducationalEstablishments.GetById(model.EduId),
                    AcquisitionYear = model.DateTime,
                    Speciality = model.Speciality,
                    LearningTime = model.DurationEducation,
                    Student = person,
                    IsFullTimeEducation = model.formEduId == "Заочная"
                };
                person.StudiesNow = true;
                person.Educations = new List<Education>();
                person.Educations.Add(education);
            }
            uow.Persons.Add(person);
            uow.Save();
        }
    }
}
