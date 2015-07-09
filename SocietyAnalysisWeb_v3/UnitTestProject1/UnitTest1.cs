using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Policy;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Services;
using SocietyAnalysisWeb.DataBase;
using SocietyAnalysisWeb.DataBase.Repository;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModelDTO;

namespace UnitTestDataBase
{
    public class c1
    {
        public string S = null;
        public List<int> value;
    }

    public class c2
    {
        public int value;
    }

    public class c3
    {
        public string S = "some value";
        public List<c2> list;
    }


    //public interface ITypeConverter<TSource, TDestination>
    //{
    //    TDestination Convert(TSource source);
    //}

    public class TypeTypeConverter : ITypeConverter<c2, Int32>
    {
        public int Convert(ResolutionContext obj)
        {
            c2 value = (c2)obj.SourceValue;
            return value.value;
        }
    }

    public class TypeConverter : ITypeConverter<BaseEntity, int>
    {
        public int Convert(ResolutionContext obj)
        {
            BaseEntity city = (BaseEntity) obj.SourceValue;
            return city.Id;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateDataBase()
        {
            Person person = new Person()
            {
                FirstName = "Александр",
                Surname = "Кузнецов",
                Sex = true,
                WasMarried = false,
                Nationality = "Беларус",
                Citizenship = "Беларусь",
                EducationLevel = "среднее образование",
                PoliticalOutlook = "либеральные",
                StudiesNow = true,
                Race = "Европеец",
                Religion = "Католик",
                BirthTime = new DateTime(1994, 2, 11),
                ChildrenNumber = 0,
                Children = new List<Person>(),
                Visits = new List<Visit>(),
                LivingPlace = new LivingPlace(),
                Jobs = new List<Job>(),
                NativeLanguage = new Language(),
                Educations = new List<Education>(),
                Ownerships = new List<Ownership>(),
                KnownLanguages = new List<Language>(),
                Parents = new List<Person>()
            };

            Country country1 = new Country()
            {
                CountryName = "Беларусь",
                Cities = new List<City>()
            };

            City city1 = new City()
            {
                CityName = "Гродно",
                Country = country1,
                Companies = new List<Company>(),
                Visits = new List<Visit>(),
                Ownerships = new List<Ownership>(),
                EducationalEstablishments = new List<EducationalEstablishment>(),
                Dwelling = new List<LivingPlace>()
            };

            City city2 = new City()
            {
                CityName = "Минск",
                Country = country1,
                Companies = new List<Company>(),
                Visits = new List<Visit>(),
                Ownerships = new List<Ownership>(),
                EducationalEstablishments = new List<EducationalEstablishment>(),
                Dwelling = new List<LivingPlace>()
            };

            City city3 = new City()
            {
                CityName = "Могилев",
                Country = country1,
                Companies = new List<Company>(),
                Visits = new List<Visit>(),
                Ownerships = new List<Ownership>(),
                EducationalEstablishments = new List<EducationalEstablishment>(),
                Dwelling = new List<LivingPlace>()
            };

            City city4 = new City()
            {
                CityName = "Гомель",
                Country = country1,
                Companies = new List<Company>(),
                Visits = new List<Visit>(),
                Ownerships = new List<Ownership>(),
                EducationalEstablishments = new List<EducationalEstablishment>(),
                Dwelling = new List<LivingPlace>()
            };

            City city5 = new City()
            {
                CityName = "Витебск",
                Country = country1,
                Companies = new List<Company>(),
                Visits = new List<Visit>(),
                Ownerships = new List<Ownership>(),
                EducationalEstablishments = new List<EducationalEstablishment>(),
                Dwelling = new List<LivingPlace>()
            };

            City city6 = new City()
            {
                CityName = "Брест",
                Country = country1,
                Companies = new List<Company>(),
                Visits = new List<Visit>(),
                Ownerships = new List<Ownership>(),
                EducationalEstablishments = new List<EducationalEstablishment>(),
                Dwelling = new List<LivingPlace>()
            };

            country1.Cities.Add(city1);
            country1.Cities.Add(city2);

            LivingPlace livingPlace = new LivingPlace()
            {
                City = city1,
                Home = 1,
                Street = "SomeStreet",
                Tenants = new List<Person>() { person }
            };

            Language language1 = new Language()
            {
                LanguageName = "Беларуский",
                NativeSpeakers = new List<Person>() { person },
                Speakers = new List<Person>() { person }
            };

            Language language2 = new Language()
            {
                LanguageName = "Русский",
                NativeSpeakers = new List<Person>(),
                Speakers = new List<Person>() { person }
            };

            Language language3 = new Language()
            {
                LanguageName = "Китайский",
                NativeSpeakers = new List<Person>(),
                Speakers = new List<Person>() { person }
            };

            Language language4 = new Language()
            {
                LanguageName = "Польский",
                NativeSpeakers = new List<Person>(),
                Speakers = new List<Person>() { person }
            };

            Language language5 = new Language()
            {
                LanguageName = "Украинский",
                NativeSpeakers = new List<Person>(),
                Speakers = new List<Person>() { person }
            };

            Education education = new Education()
            {
                AcquisitionYear = new DateTime(2012, 9, 1),
                IsFullTimeEducation = true,
                IsPaidEducation = false,
                Speciality = "программное обеспечение информационных технологий",
                LearningTime = 5,
                Student = person,
                EducationalEstablishment = new EducationalEstablishment()
            };

            EducationalEstablishment establishment = new EducationalEstablishment()
            {
                City = city1,
                Educations = new List<Education>() { education },
                Name = "Grodno State University named Yanka Kupala",
                WebSite = "grsu.by",
                EducationType = "высшее образование"
            };

            EducationalEstablishment bsu = new EducationalEstablishment()
            {
                City = city2,
                Educations = new List<Education>(),
                Name = "Belarusian State University",
                WebSite = "http://www.bsu.by/en/main.aspx",
                EducationType = "высшее образование"
            };

            Job job = new Job()
            {
                PositionAtWork = "developer",
                Employee = person,
                TypeOfEmployment = "recruitment",
                Company = new Company()
            };

            Company company = new Company()
            {
                Jobs = new List<Job>() { job },
                City = city1,
                ProductType = "Software",
                CompanyName = "Epam"
            };

            Ownership ownership = new Ownership()
            {
                City = city1,
                Owner = person,
                OwnershipName = "Some ownership",
                OwnershipType = "owns"
            };

            Visit visit = new Visit()
            {
                Begin = new DateTime(2015, 6, 1),
                End = new DateTime(2015, 6, 12),
                City = city2,
                Purpose = "recreation",
                Visitor = person
            };

            person.Jobs.Add(job);
            person.KnownLanguages.Add(language1);
            person.KnownLanguages.Add(language2);
            person.KnownLanguages.Add(language3);
            person.KnownLanguages.Add(language4);
            person.KnownLanguages.Add(language5);
            person.NativeLanguage = language1;
            person.LivingPlace = livingPlace;
            person.Educations.Add(education);
            person.Visits.Add(visit);
            person.Ownerships.Add(ownership);

            country1.Cities.Add(city1);
            country1.Cities.Add(city2);

            city1.Companies.Add(company);
            city1.Dwelling.Add(livingPlace);
            city1.EducationalEstablishments.Add(establishment);
            city1.Ownerships.Add(ownership);

            city2.Visits.Add(visit);
            city2.EducationalEstablishments.Add(bsu);

            education.EducationalEstablishment = establishment;

            job.Company = company;


            {
                UnitOfWork unitOfWork = new UnitOfWork("connectionString");


                if (unitOfWork.Persons.GetAll() == null || unitOfWork.Persons.GetAll().Count() == 0)
                {
                    unitOfWork.Persons.Add(person);
                    unitOfWork.Cities.Add(city3);
                    unitOfWork.Cities.Add(city4);
                    unitOfWork.Cities.Add(city5);
                    unitOfWork.Cities.Add(city6);
                    unitOfWork.Save();
                }

                List<Person> allPersons = unitOfWork.Persons.GetAll().ToList();

                List<Country> allCountries = unitOfWork.Countries.GetAll().ToList();

                foreach (var _person in allPersons)
                {
                    Console.WriteLine(_person.FirstName + " " + _person.Surname);
                }
                foreach (var _country in allCountries)
                {
                    Console.WriteLine(_country.CountryName);
                }
            }
        }

        
        [TestMethod]
        public void Test()
        {
            GetServices services = new GetServices(new UnitOfWork("connectionString"));
            List<PersonDTO> persons = services.GetAllPersons().ToList();

            int num = 0;
            num++;
            //GetServices services = new GetServices(new UnitOfWork("connectionString"));

            //CityDTO city = services.GetCityById(1);

            //int num = 0;
            //num++;
            //CountryDTO country = services.GetCountryById(1);

            //int num = 0;
            //num++;
            //c3 i1 = new c3() {list = new List<c2>() {new c2(){value = 1}, new c2(){value = 4}, new c2(){value = 10} }};

            //Mapper.CreateMap<c2, int>().ConvertUsing(new TypeTypeConverter());
            //Mapper.CreateMap<c3, c1>().ForMember(dest => dest.value, temp => temp.MapFrom(sour => sour.list));

            //var i2 = Mapper.Map<c3, c1>(i1);

            //int num = 0;
            //num++;
            //List<City> cities = new List<City>() {new City(), new City(), new City()};
            //cities[0].Id = 1;
            //cities[1].Id = 2;
            //cities[2].Id = 5;
            //Country country = new Country() {Id = 10, Cities = cities, CountryName = "Belarus"};


            //Mapper.CreateMap<City, int>().ConvertUsing(new TypeConverter());
            //Mapper.CreateMap<Country, CountryDTO>()
            //    .ForMember(dest => dest.CountryName, temp => temp.MapFrom(sour => sour.CountryName))
            //    .ForMember(dest => dest.Cities, temp => temp.MapFrom(sour => sour.Cities));

            //var countryDto = Mapper.Map<Country, CountryDTO>(country);

            //int num = 0;
            //num++;
        }
    }
}
