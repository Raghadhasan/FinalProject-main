using System;
using System.Collections.Generic;

namespace LearningHub.Core.Data
{
    public partial class Course
    {
        public Course()
        {
            Traineesections = new HashSet<Traineesection>();
            Trainersections = new HashSet<Trainersection>();
        }

        public decimal Courseid { get; set; }
        public string Coursename { get; set; } = null!;
        public string? Coursemeetinglink { get; set; }
        public DateTime? Coursestarttime { get; set; }
        public DateTime? Courseendtime { get; set; }

        public virtual ICollection<Traineesection> Traineesections { get; set; }
        public virtual ICollection<Trainersection> Trainersections { get; set; }
    }
}
