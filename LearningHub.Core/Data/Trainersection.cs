using System;
using System.Collections.Generic;

namespace LearningHub.Core.Data
{
    public partial class Trainersection
    {
        public Trainersection()
        {
            Assignmentsections = new HashSet<Assignmentsection>();
            Examsections = new HashSet<Examsection>();
            Materialsections = new HashSet<Materialsection>();
            Sectionattendances = new HashSet<Sectionattendance>();
            Traineesections = new HashSet<Traineesection>();
        }

        public decimal Tsid { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Courseid { get; set; }
        public string? Material { get; set; }
        public string? Assignment { get; set; }
        public string? Exam { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Userr? User { get; set; }
        public virtual ICollection<Assignmentsection> Assignmentsections { get; set; }
        public virtual ICollection<Examsection> Examsections { get; set; }
        public virtual ICollection<Materialsection> Materialsections { get; set; }
        public virtual ICollection<Sectionattendance> Sectionattendances { get; set; }
        public virtual ICollection<Traineesection> Traineesections { get; set; }
    }
}
