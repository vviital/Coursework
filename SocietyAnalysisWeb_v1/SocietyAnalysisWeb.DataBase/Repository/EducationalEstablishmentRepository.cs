using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModel.Repository;

namespace SocietyAnalysisWeb.DataBase.Repository
{
    public class EducationalEstablishmentRepository : BaseRepository<EducationalEstablishment>, IEducationalEstablishmentRepository
    {
        public EducationalEstablishmentRepository(SocietyContext context)
            : base(context)
        {
            
        }
    }
}
