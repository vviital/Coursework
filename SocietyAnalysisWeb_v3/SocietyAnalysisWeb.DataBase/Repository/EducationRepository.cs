using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModel.Repository;

namespace SocietyAnalysisWeb.DataBase.Repository
{
    public class EducationRepository : BaseRepository<Education>, IEducationRepository
    {
        public EducationRepository(SocietyContext context)
            : base(context)
        {
            
        }
    }
}
