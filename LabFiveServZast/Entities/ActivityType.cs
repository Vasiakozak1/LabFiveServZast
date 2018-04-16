using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFiveServZast.Entities
{
    public class ActivityType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employer> Employers { get; set; }
        public virtual ICollection<Contestant> Contestants { get; set; }
    }
}
