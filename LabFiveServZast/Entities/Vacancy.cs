using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFiveServZast.Entities
{
    public class Vacancy
    {
        public int Id { get; set; }
        public int EmployerId { get; set; }
        public Employer Employer { get; set; }
        public string Post { get; set; }
        public int Salary { get; set; }
    }
}
