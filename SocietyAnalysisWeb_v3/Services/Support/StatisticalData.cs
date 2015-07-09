using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModelDTO;

namespace Services.Support
{
    public class StatisticalData
    {
        public List<PersonDTO> Male { get; set; }

        public List<PersonDTO> Female { get; set; }

        public int MalePercentage { get; set; }

        public int FemalePercentage { get; set; }

        public List<int[]> AgesStatistic { get; set; }

        public Dictionary<string, int[]> RaceStatistic { get; set; }
    }
}
