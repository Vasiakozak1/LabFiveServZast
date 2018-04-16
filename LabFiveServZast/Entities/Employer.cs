using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFiveServZast.Entities
{
    public class Employer
    {
        public int Id { get; set; }
        public int IdActivityTypeId { get; set; }
        public ActivityType ActivityType { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Vacancy> Vacancies { get; set; }
    }
}
