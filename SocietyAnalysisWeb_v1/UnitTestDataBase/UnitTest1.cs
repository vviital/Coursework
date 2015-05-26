using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocietyAnalysisWeb.DataBase;
using SocietyAnalysisWeb.DataBase.Repository;
using SocietyAnalysisWeb.DataModel;

namespace UnitTestDataBase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateDataBase()
        {
            Person person = new Person()
            {
                FirstName = "Alex",
                Surname = "Kuznechov",
                Sex = true,
                WasMarried = false,
                Nationality = "belarus",
                Citizenship = "belarus",
                EducationLevel = "secondary education",
                PoliticalOutlook = "liberal",
                StudiesNow = true,
                Race = "White",
                Religion = "Catholic",
                BirthTime = new DateTime(1994, 2, 11),
                ChildrenNumber  = 0,
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
                CountryName = "Belarus",
                Cities = new List<City>()
            };

            City city1 = new City()
            {
                CityName = "Grodno",
                Country = country1,
                Companies = new List<Company>(),
                Visits = new List<Visit>(),
                Ownerships = new List<Ownership>(),
                EducationalEstablishments = new List<EducationalEstablishment>(),
                Dwelling = new List<LivingPlace>()
            };

            City city2 = new City()
            {
                CityName = "Minsk",
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
                LanguageName = "Belarusan",
                NativeSpeakers = new List<Person>() { person },
                Speakers = new List<Person>() { person }
            };

            Language language2 = new Language()
            {
                LanguageName = "Russian",
                NativeSpeakers = new List<Person>(),
                Speakers = new List<Person>() { person }
            };

            Education education = new Education()
            {
                AcquisitionYear = new DateTime(2012, 9, 1),
                IsFullTimeEducation = true,
                IsPaidEducation = false,
                Speciality = "Software development",
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
                EducationType = "higher education"
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

            education.EducationalEstablishment = establishment;

            job.Company = company;

            using (var context = new SocietyContext())
            {
                BaseRepository<Person> repository = new PersonRepository(context);
                BaseRepository<Country> countryRepository = new CountryRepository(context);

                if (repository.GetAll() == null || repository.GetAll().Count() == 0)
                {
                    repository.Add(person);
                    repository.Save();
                }

                List<Person> allPersons = repository.GetAll().ToList();

                List<Country> allCountries = countryRepository.GetAll().ToList();



            }
        }
    }
}
