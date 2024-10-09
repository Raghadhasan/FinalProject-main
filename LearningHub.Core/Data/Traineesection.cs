using System;
using System.Collections.Generic;

namespace LearningHub.Core.Data
{
    public partial class Traineesection
    {
        public decimal Tsid { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Courseid { get; set; }
        public decimal? Trainerid { get; set; }
        public decimal? Traineemark { get; set; }
        public decimal? Assignmentid { get; set; }
        public string? AssignmentSolutionFile { get; set; }
        public string? Traineesolution { get; set; }



        public virtual Course? Course { get; set; }
        public virtual Trainersection? Trainer { get; set; }
        public virtual Userr? User { get; set; }
        public virtual Assignmentsection? Assignmentsection { get; set; }

    }
}
