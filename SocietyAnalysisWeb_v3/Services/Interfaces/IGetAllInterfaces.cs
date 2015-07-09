using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModelDTO;

namespace Services.Interfaces
{
    public interface IGetAllInterfaces
    {
        IEnumerable<PersonDTO> GetAllPersons();

        IEnumerable<CountryDTO> GetAllCountries();

        IEnumerable<CityDTO> GetAllCities();

        IEnumerable<EducationDTO> GetAllEducations();

        IEnumerable<EducationalEstablishmentDTO> GetAllEducationalEstablishments();

        IEnumerable<JobDTO> GetAllJobs();

        IEnumerable<LanguageDTO> GetAllLanguages();

        IEnumerable<LivingPlaceDTO> GetAlllLivingPlaces();

        IEnumerable<OwnershipDTO> GetAllOwnerships();

        IEnumerable<VisitDTO> GetAllVisits();

        IEnumerable<CompanyDTO> GetAllCompanies();
    }
}
