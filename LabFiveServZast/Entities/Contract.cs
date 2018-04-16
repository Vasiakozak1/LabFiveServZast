using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFiveServZast.Entities
{
    public class Contract
    {
        public int VacancyId { get; set; }
        public Vacancy Vacancy { get; set; }
        public int ContestantId { get; set; }
        public Contestant Contestant { get; set; }
        public int Commission { get; set; }
    }
}
