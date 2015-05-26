using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModel.Repository;

namespace SocietyAnalysisWeb.DataBase.Repository
{
    public class CityRepository :  BaseRepository<City>, ICityRepository
    {
        public CityRepository(SocietyContext context)
            : base(context)
        {
            
        }
    }
}
