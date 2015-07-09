using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Services.Interfaces;
using Services.Support;
using SocietyAnalysisWeb.DataBase;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModelDTO;

namespace Services.Services
{
    public class GetServices : IGetById, IGetAllInterfaces
    {
        private IUnitOfWork DataBase { get; set; }

        public GetServices(IUnitOfWork uow)
        {
            DataBase = uow;
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

        public CountryDTO GetCountryById(int id)
        {
            Country country = DataBase.Countries.GetById(id);
            return Mapper.Map<Country, CountryDTO>(country);
        }

        public CityDTO GetCityById(int id)
        {
            City city = DataBase.Cities.GetById(id);
            return Mapper.Map<City, CityDTO>(city);
        }

        public PersonDTO GetPersonById(int id)
        {
            Person person = DataBase.Persons.GetById(id);
            return Mapper.Map<Person, PersonDTO>(person);
        }

        public CompanyDTO GetCompanyById(int id)
        {
            Company company = DataBase.Companies.GetById(id);
            return Mapper.Map<Company, CompanyDTO>(company);
        }

        public EducationalEstablishmentDTO GetEducationalEstablishmentById(int id)
        {
            EducationalEstablishment educationalEstablishment = DataBase.EducationalEstablishments.GetById(id);
            return Mapper.Map<EducationalEstablishment, EducationalEstablishmentDTO>(educationalEstablishment);
        }

        public EducationDTO GetEducationById(int id)
        {
            Education education = DataBase.Educations.GetById(id);
            return Mapper.Map<Education, EducationDTO>(education);
        }

        public JobDTO GetJobById(int id)
        {
            Job job = DataBase.Jobs.GetById(id);
            return Mapper.Map<Job, JobDTO>(job);
        }

        public LanguageDTO GetLanguageById(int id)
        {
            Language language = DataBase.Languages.GetById(id);
            return Mapper.Map<Language, LanguageDTO>(language);
        }

        public LivingPlaceDTO GetLivingPlaceById(int id)
        {
            LivingPlace livingPlace = DataBase.LivingPlaces.GetById(id);
            return Mapper.Map<LivingPlace, LivingPlaceDTO>(livingPlace);
        }

        public OwnershipDTO GetOwnershipById(int id)
        {
            Ownership ownership = DataBase.Ownerships.GetById(id);
            return Mapper.Map<Ownership, OwnershipDTO>(ownership);
        }

        public VisitDTO GetVisitById(int id)
        {
            Visit visit = DataBase.Visits.GetById(id);
            return Mapper.Map<Visit, VisitDTO>(visit);
        }

        public IEnumerable<PersonDTO> GetAllPersons()
        {
            List<Person> persons = DataBase.Persons.GetAll().ToList();
            return Mapper.Map<List<Person>, List<PersonDTO>>(persons);
        }

        public IEnumerable<CountryDTO> GetAllCountries()
        {
            List<Country> countries = DataBase.Countries.GetAll().ToList();
            return Mapper.Map<List<Country>, List<CountryDTO>>(countries);
        }

        public IEnumerable<CityDTO> GetAllCities()
        {
            List<City> cities = DataBase.Cities.GetAll().ToList();
            return Mapper.Map<List<City>, List<CityDTO>>(cities);
        }

        public IEnumerable<EducationDTO> GetAllEducations()
        {
            List<Education> educations = DataBase.Educations.GetAll().ToList();
            return Mapper.Map<List<Education>, List<EducationDTO>>(educations);
        }

        public IEnumerable<EducationalEstablishmentDTO> GetAllEducationalEstablishments()
        {
            List<EducationalEstablishment> educationalEstablishments = DataBase.EducationalEstablishments.GetAll().ToList();
            return Mapper.Map<List<EducationalEstablishment>, List<EducationalEstablishmentDTO>>(educationalEstablishments);
        }

        public IEnumerable<JobDTO> GetAllJobs()
        {
            List<Job> jobs = DataBase.Jobs.GetAll().ToList();
            return Mapper.Map<List<Job>, List<JobDTO>>(jobs);
        }

        public IEnumerable<LanguageDTO> GetAllLanguages()
        {
            List<Language> languages = DataBase.Languages.GetAll().ToList();
            return Mapper.Map<List<Language>, List<LanguageDTO>>(languages);
        }

        public IEnumerable<LivingPlaceDTO> GetAlllLivingPlaces()
        {
            List<LivingPlace> livingPlaces = DataBase.LivingPlaces.GetAll().ToList();
            return Mapper.Map<List<LivingPlace>, List<LivingPlaceDTO>>(livingPlaces);
        }

        public IEnumerable<OwnershipDTO> GetAllOwnerships()
        {
            List<Ownership> ownerships = DataBase.Ownerships.GetAll().ToList();
            return Mapper.Map<List<Ownership>, List<OwnershipDTO>>(ownerships);
        }

        public IEnumerable<VisitDTO> GetAllVisits()
        {
            List<Visit> visits = DataBase.Visits.GetAll().ToList();
            return Mapper.Map<List<Visit>, List<VisitDTO>>(visits);
        }

        public IEnumerable<CompanyDTO> GetAllCompanies()
        {
            List<Company> companies = DataBase.Companies.GetAll().ToList();
            return Mapper.Map<List<Company>, List<CompanyDTO>>(companies);
        }
    }
}
