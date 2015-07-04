using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataBase.Repository;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModel.Repository;

namespace SocietyAnalysisWeb.DataBase
{
    public class UnitOfWork : IDisposable
    {
        private SocietyContext context;

        private IRepository<Person> persons;
        private IRepository<Education> educations;
        private IRepository<EducationalEstablishment> educationalEstablishment;
        private IRepository<Job> jobs;
        private IRepository<Company> companies;
        private IRepository<Ownership> ownerships;
        private IRepository<Language> languages;
        private IRepository<LivingPlace> livingPlaces;
        private IRepository<City> cities;
        private IRepository<Country> countries;
        private IRepository<Visit> visits;

        private bool disposed = false;

        public UnitOfWork(string connectionString)
        {
            context = new SocietyContext(connectionString);
        }

        public IRepository<Person> Persons
        {
            get
            {
                if (this.persons == null)
                    this.persons = new PersonRepository(context);
                return persons;
            }
        }

        public IRepository<Education> Educations
        {
            get
            {
                if (this.educations == null)
                    this.educations = new EducationRepository(context);
                return educations;
            }
        }

        public IRepository<EducationalEstablishment> EducationalEstablishments
        {
            get
            {
                if (this.educationalEstablishment == null)
                {
                    this.educationalEstablishment = new EducationalEstablishmentRepository(context);
                }
                return this.educationalEstablishment;
            }
        }

        public IRepository<Job> Jobs
        {
            get
            {
                if (this.jobs == null)
                    this.jobs = new JobRepository(context);
                return this.jobs;
            }
        }

        public IRepository<Company> Companies
        {
            get
            {
                if (this.companies == null)
                {
                    this.companies = new CompanyRepository(context);
                }
                return this.companies;
            }
        }

        public IRepository<Ownership> Ownerships
        {
            get
            {
                if (this.ownerships == null)
                {
                    this.ownerships = new OwnershipRepository(context);
                }
                return this.ownerships;
            }
        }

        public IRepository<Language> Languages
        {
            get
            {
                if (this.languages == null)
                {
                    this.languages = new LanguageRepository(context);
                }
                return this.languages;
            }
        }

        public IRepository<LivingPlace> LivingPlaces
        {
            get
            {
                if (this.livingPlaces == null)
                {
                    this.livingPlaces = new LivingPlaceRepository(context);
                }
                return this.livingPlaces;
            }
        }

        public IRepository<City> Cities
        {
            get
            {
                if (this.cities == null)
                {
                    this.cities = new CityRepository(context);
                }
                return this.cities;
            }
        }

        public IRepository<Country> Countries
        {
            get
            {
                if (this.countries == null)
                {
                    this.countries = new CountryRepository(context);
                }
                return this.countries;
            }
        }

        public IRepository<Visit> Visits
        {
            get
            {
                if (this.visits == null)
                {
                    this.visits = new VisitRepository(context);
                }
                return this.visits;
            }
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
