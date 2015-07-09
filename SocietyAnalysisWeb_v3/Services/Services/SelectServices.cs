using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using AutoMapper;
using Services.Interfaces;
using Services.Support;
using SocietyAnalysisWeb.DataBase;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModelDTO;

namespace Services.Services
{
    public class SelectServices : ISelectServices
    {
        private IUnitOfWork uow;

        public SelectServices(IUnitOfWork uow)
        {
            this.uow = uow;
            Mapper.CreateMap<BaseEntity, int>().ConvertUsing(new TypeConverter());
            Mapper.CreateMap<Country, CountryDTO>();
            Mapper.CreateMap<City, CityDTO>();
            Mapper.CreateMap<Company, CompanyDTO>();
            Mapper.CreateMap<EducationalEstablishment, EducationalEstablishmentDTO>();
            Mapper.CreateMap<LivingPlace, LivingPlaceDTO>();
            Mapper.CreateMap<Language, LanguageDTO>();
            Mapper.CreateMap<Person, PersonDTO>();
            Mapper.CreateMap<Ownership, OwnershipDTO>();
            Mapper.CreateMap<Education, EducationDTO>();
            Mapper.CreateMap<Visit, VisitDTO>();
            Mapper.CreateMap<Job, JobDTO>();
        }

        public int Count()
        {
            return this.uow.Persons.GetAll().Count();
        }

        public int Count(bool sex)
        {
            return this.uow.Persons.GetMany(o => o.Sex == sex).Count();
        }

        public List<PersonDTO> GetBySex(bool sex)
        {
            List<Person> persons = this.uow.Persons.GetMany(o => o.Sex == sex).ToList();
            return Mapper.Map<List<Person>, List<PersonDTO>>(persons);
        }
        
        public List<int[]> GetBySexByAge()
        {
            bool sex = true;
            List<int[]> counts = new List<int[]>()
            {
                new int[12],
                new int[12]
            };
            int all = 0;
            for (int iter = 0; iter < 2; ++iter)
            {
                List<PersonDTO> person = Mapper.Map<List<Person>, List<PersonDTO>>(uow.Persons.GetMany(o => o.Sex == sex).ToList());
                foreach (var item in person)
                {
                    DateTime today = DateTime.Today;
                    DateTime birth = item.BirthTime;
                    int age = (today - birth).Days/365;
                    age /= 10;
                    if (age < 12)
                    {
                        all++;
                        counts[iter][age]++;
                    }
                }
                sex ^= true;
            }
            for (int iter = 0; iter < 2; ++iter)
            {
                for (int i = 0; i < counts[iter].Count(); ++i)
                {
                    counts[iter][i] = counts[iter][i]*100/all;
                }
            }
            return counts;
        }

        public Dictionary<string, int[]> GetByRaceAndAge()
        {
            List<PersonDTO> person = Mapper.Map<List<Person>, List<PersonDTO>>(this.uow.Persons.GetMany(o => o.Race != null).ToList());
            Dictionary<string, int[]> dictionary = new Dictionary<string, int[]>();
            int all = 0;
            foreach (var item in person)
            {
                if (dictionary.ContainsKey(item.Race) == false)
                {
                    dictionary.Add(item.Race, new int[12]);
                }
                
                DateTime today = DateTime.Today;
                DateTime birth = item.BirthTime;
                int age = (today - birth).Days / 365;
                age /= 10;
                if (age < 12)
                {
                    all++;
                    dictionary[item.Race][age]++;
                }
                
            }
            foreach (var item in dictionary)
            {
                for (int i = 0; i < item.Value.Count(); ++i)
                {
                    item.Value[i] = item.Value[i]*100/all;
                }
            }
            return dictionary;
        }

        public Dictionary<string, int[]> GetByReligion()
        {
            List<PersonDTO> person = Mapper.Map<List<Person>, List<PersonDTO>>(this.uow.Persons.GetMany(o => o.Religion != null).ToList());
            Dictionary<string, int[]> dictionary = new Dictionary<string, int[]>();
            int all = 0;
            foreach (var item in person)
            {
                if (dictionary.ContainsKey(item.Religion) == false)
                {
                    dictionary.Add(item.Religion, new int[12]);
                }

                DateTime today = DateTime.Today;
                DateTime birth = item.BirthTime;
                int age = (today - birth).Days / 365;
                age /= 10;
                if (age < 12)
                {
                    all++;
                    dictionary[item.Religion][age]++;
                }
            }
            foreach (var item in dictionary)
            {
                for (int i = 0; i < item.Value.Count(); ++i)
                {
                    item.Value[i] = item.Value[i] * 100 / all;
                }
            }
            return dictionary;
        }

        public Dictionary<string, int[]> GetByNationality()
        {
            List<PersonDTO> person = Mapper.Map<List<Person>, List<PersonDTO>>(this.uow.Persons.GetMany(o => o.Nationality != null).ToList());
            Dictionary<string, int[]> dictionary = new Dictionary<string, int[]>();
            int all = 0;
            foreach (var item in person)
            {
                if (dictionary.ContainsKey(item.Nationality) == false)
                {
                    dictionary.Add(item.Nationality, new int[12]);
                }

                DateTime today = DateTime.Today;
                DateTime birth = item.BirthTime;
                int age = (today - birth).Days / 365;
                age /= 10;
                if (age < 12)
                {
                    all++;
                    dictionary[item.Nationality][age]++;
                }

            }
            foreach (var item in dictionary)
            {
                for (int i = 0; i < item.Value.Count(); ++i)
                {
                    item.Value[i] = item.Value[i] * 100 / all;
                }
            }
            return dictionary;
        }

        public Dictionary<string, int[]> GetByEducation()
        {
            List<Person> persons = uow.Persons.GetAll().ToList();
            List<EducationalEstablishment> est = uow.EducationalEstablishments.GetAll().ToList();
            List<EducationalEstablishment> establishments = this.uow.EducationalEstablishments.GetAll().Where(o => o.Educations.Any()).ToList();
            List<EducationalEstablishmentDTO> educational =
                Mapper.Map<List<EducationalEstablishment>, List<EducationalEstablishmentDTO>>(establishments);
            Dictionary<string, int[]> dictionary = new Dictionary<string, int[]>();
            foreach (var item in educational)
            {
                foreach (var edu in item.Educations)
                {
                    DateTime today = DateTime.Today;
                    Education education = uow.Educations.GetById(edu);
                    if (education.Student.BirthTime == null) continue;
                    DateTime birth = (DateTime)education.Student.BirthTime;
                    int age = (today - birth).Days / 365;
                    age /= 10;
                    if (dictionary.ContainsKey(item.Name) == false)
                    {
                        dictionary.Add(item.Name, new int[12]);
                    }
                    dictionary[item.Name][age]++;
                }
            }
            return dictionary;
        }
    }
}
