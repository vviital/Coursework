using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Support;
using SocietyAnalysisWeb.DataModelDTO;

namespace Services.Interfaces
{
    public interface ISelectServices
    {
        List<PersonDTO> GetBySex(bool sex);

        List<int[]> GetBySexByAge();

        int Count(bool sex);

        int Count();

        Dictionary<string, int[]> GetByRaceAndAge();

        Dictionary<string, int[]> GetByReligion();

        Dictionary<string, int[]> GetByNationality();

        Dictionary<string, int[]> GetByEducation();

        //List<Pair<string, double>> GetByNativeLanguage();

        //List<Pair<int, double>> GetByNumberOfLanguages();

        //List<Pair<int, double>> GetByChild();
    }
}
