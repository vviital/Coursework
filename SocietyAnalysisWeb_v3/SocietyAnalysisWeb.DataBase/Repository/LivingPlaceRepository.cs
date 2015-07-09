using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModel.Repository;

namespace SocietyAnalysisWeb.DataBase.Repository
{
    public class LivingPlaceRepository : BaseRepository<LivingPlace>, ILivingPlaceRepository
    {
        public LivingPlaceRepository(SocietyContext context)
            : base(context)
        {
            
        }
    }
}
