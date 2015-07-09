using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModel.Repository;

namespace SocietyAnalysisWeb.DataBase.Repository
{
    public class VisitRepository : BaseRepository<Visit>, IVisitRepository
    {
        public VisitRepository(SocietyContext context)
            : base(context)
        {
            
        }
    }
}
