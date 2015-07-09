using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataBase.Repository;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModel.Repository;

namespace SocietyAnalysisWeb.DataBase
{
    public interface IUnitOfWork
    {
        IRepository<Person> Persons { get; }

        IRepository<Education> Educations { get; }

        IRepository<EducationalEstablishment> EducationalEstablishments { get; }

        IRepository<Job> Jobs { get; }

        IRepository<Company> Companies { get; }

        IRepository<Ownership> Ownerships { get; }

        IRepository<Language> Languages { get; }

        IRepository<LivingPlace> LivingPlaces { get; }

        IRepository<City> Cities { get; }

        IRepository<Country> Countries { get; }

        IRepository<Visit> Visits { get; }

        void Save();
    }
}
