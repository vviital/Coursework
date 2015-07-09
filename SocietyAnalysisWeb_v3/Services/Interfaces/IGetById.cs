using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModelDTO;

namespace Services.Interfaces
{
    public interface IGetById
    {
        PersonDTO GetPersonById(int id);

        CityDTO GetCityById(int id);

        CompanyDTO GetCompanyById(int id);

        CountryDTO GetCountryById(int id);

        EducationalEstablishmentDTO GetEducationalEstablishmentById(int id);

        EducationDTO GetEducationById(int id);

        JobDTO GetJobById(int id);

        LanguageDTO GetLanguageById(int id);

        LivingPlaceDTO GetLivingPlaceById(int id);

        OwnershipDTO GetOwnershipById(int id);

        VisitDTO GetVisitById(int id);
    }
}
