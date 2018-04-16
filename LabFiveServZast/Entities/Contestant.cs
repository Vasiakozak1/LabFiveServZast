using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFiveServZast.Entities
{
    public class Contestant
    {
        public int Id { get; set; }
        public int IdActivityTypeId { get; set; }
        public ActivityType ActivityType { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Qualification { get; set; }
        public int DesirableSalary { get; set; }
    }
}
