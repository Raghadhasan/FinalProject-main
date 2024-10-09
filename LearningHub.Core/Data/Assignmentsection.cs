using System;
using System.Collections.Generic;

namespace LearningHub.Core.Data
{
    public partial class Assignmentsection
    {
        public Assignmentsection()
        {
            Traineesections = new HashSet<Traineesection>();
        }
        public decimal Asec { get; set; }
        public decimal? Trainercourse { get; set; }
        public string? Assignmentfile { get; set; }
        public decimal? Assignmentmark { get; set; }
        public DateTime? Assignmentduration { get; set; }

        public virtual ICollection<Traineesection> Traineesections { get; set; }

        public virtual Trainersection? TrainercourseNavigation { get; set; }
    }
}
